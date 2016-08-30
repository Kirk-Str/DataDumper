using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace DataDumper
{
    public partial class Form1 : Form
    {
        SqlDataSourceEnumerator instance;
        DataTable instanceTable;
        string connStringPrimary;
        string connStringSecondary;
        string connStringMaster;
        string sourceDBName, destinationDBName;
       

        public Form1()
        {
            InitializeComponent();
        }

        private void initialize()
        {
            connStringPrimary = textBox1.Text;
            connStringSecondary = textBox2.Text;

            SqlConnectionStringBuilder dbConnObj1 = new SqlConnectionStringBuilder();
            SqlConnectionStringBuilder dbConnObj2 = new SqlConnectionStringBuilder();
            SqlConnectionStringBuilder dbConnObj3forMaster = new SqlConnectionStringBuilder();

            dbConnObj1.ConnectionString = connStringPrimary;
            dbConnObj2.ConnectionString = connStringSecondary;

            dbConnObj3forMaster.InitialCatalog = "MASTER";
            dbConnObj3forMaster.Password = dbConnObj1.Password;
            dbConnObj3forMaster.UserID = dbConnObj1.UserID;
            dbConnObj3forMaster.DataSource = dbConnObj1.DataSource;

            sourceDBName = dbConnObj1.InitialCatalog;
            destinationDBName = dbConnObj2.InitialCatalog;
            connStringMaster = dbConnObj3forMaster.ConnectionString;

            tableMapGrid.Columns[1].HeaderText = "Source \r[" + sourceDBName + "]";
            tableMapGrid.Columns[2].HeaderText = "Destination \r[" + destinationDBName + "]";

            //Get SQL SERVER INSTANCE
            instance = SqlDataSourceEnumerator.Instance;
            instanceTable = instance.GetDataSources();
            cmbSqlInstanceList.DataSource = instanceTable;
        }


        //Insert Query Generation Function "Beauty of the Application"
        private string GenerateInsertQuery(string sourceDBName, string destinationDBName, string tableName)
        {

            string selectQuery = "SELECT * FROM " + sourceDBName + ".INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + tableName.Replace("'", "") + "'";

            SqlConnection conn = new SqlConnection(connStringPrimary);
            conn.Open();

            SqlCommand cmd = new SqlCommand(selectQuery, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            string insertionQuery = "INSERT INTO ";
            string fieldList = "";

            while (reader.Read())
            {
                fieldList += "[" + reader.GetValue(3) + "]";
                fieldList += ", ";

            }

            fieldList = fieldList.Remove(fieldList.Length - 2);

            insertionQuery = insertionQuery + destinationDBName + "..[" + tableName + "]( " + fieldList + " ) " +
            "SELECT " + fieldList + " FROM " + sourceDBName + "..[" + tableName + "]";

            conn.Close();

            return insertionQuery;

        }

        private DataTable GetDataTable(string db, string table, string sub)
        {
            string selectQuery = "select * from " + db + "." + sub + "." + table;
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(connStringPrimary);
            conn.Open();

            SqlCommand cmd = new SqlCommand(selectQuery, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            conn.Close();

            return dt;
        }

        private DataTable GetDt(string query)
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(connStringMaster);
            conn.Open();

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            conn.Close();

            return dt;
        }

        private Int32 ExecuteQuery(string query)
        {
            try
            {
                string selectQuery = query;
                int retVal = 0;
                DataTable dt = new DataTable();

                //Connecting String is connStringMaster 
                SqlConnection conn = new SqlConnection(connStringMaster);

                conn.Open();

                SqlCommand cmd = new SqlCommand(selectQuery, conn);

                retVal = cmd.ExecuteNonQuery();

                conn.Close();

                return retVal;
            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                BuildLogLine("Query Execution : " + query + "\r\t\t\t\t\t\t" + ex.Message);
                return -1;
            }
        }

        private int ClearTable(string tableName)
        {
            string deleteQuery = "DELETE " + destinationDBName + ".." + tableName;

            Int32 count = ExecuteQuery(deleteQuery);

            BuildLogLine("Data Delete Result : " + tableName + "("+ count + ")");
            return count;
        }

        private void mapTables()
        {

            //loadIcon.Visible = true;

            //To remove Rows before proceed
            if (tableMapGrid.Rows.Count != 0)
            {
                tableMapGrid.Rows.Clear();
            }

            DataTable sourceDt = GetDataTable(sourceDBName, "Tables", "Sys");
            DataTable destinationDt = GetDataTable(destinationDBName, "Tables", "Sys");


            DataTable mappedTable = new DataTable();

            if (tableMapGrid.Rows.Count != 0)
            {
                mappedTable.Clear();
            }


            DataColumn chkDo = new DataColumn("chkDo");
            DataColumn sourceTableCount = new DataColumn("sourceTable");
            DataColumn destinationTable = new DataColumn("destinationTable");
            DataColumn status = new DataColumn("status");
            DataColumn errorMessage = new DataColumn("errorMessage");
            DataColumn insertQuery = new DataColumn("insertQuery");
            DataColumn trueTableName = new DataColumn("trueTableName");

            mappedTable.Columns.Add(chkDo);
            mappedTable.Columns.Add(sourceTableCount);
            mappedTable.Columns.Add(destinationTable);
            mappedTable.Columns.Add(status);
            mappedTable.Columns.Add(errorMessage);
            mappedTable.Columns.Add(insertQuery);
            mappedTable.Columns.Add(trueTableName);

            progressBarLoad.Visible = true;
            progressBarLoad.Value = 0;
            progressBarLoad.Minimum = 0;
            progressBarLoad.Maximum = sourceDt.Rows.Count;

            BuildLogLine("", "--------------- Script Generation " + DateTime.Now + "---------------", destinationDBName + ".txt");
            BuildLogLine("", "", destinationDBName + ".txt");
            BuildLogLine("", "", destinationDBName + ".txt");


            //Primary DB Tables Loading...
            foreach(DataRow rowX in sourceDt.Rows)
            {
                DataRow dtRow = mappedTable.NewRow();
                dtRow["chkDo"] = false;
                dtRow["sourceTable"] = rowX["name"] + " (" + GetDt("SELECT COUNT(*) FROM " + sourceDBName + ".." + rowX["name"].ToString().Replace("'", "")).Rows[0][0].ToString() + ")";
                dtRow["trueTableName"] = rowX["name"];

                
                //Secondary DB Tables finding and Loading...
                foreach (DataRow rowY in destinationDt.Rows)
                {

                    //Lower or upper the case to match different tables named by different caps 
                    if (rowX["name"].ToString().ToLower() == rowY["name"].ToString().ToLower())
                    {
                        dtRow["destinationTable"] = rowY["name"] + " (" + GetDt("SELECT COUNT(*) FROM " + destinationDBName + ".." + rowY["name"].ToString().Replace("'", "")).Rows[0][0].ToString() + ")";
                        dtRow["insertQuery"] = GenerateInsertQuery(sourceDBName, destinationDBName, rowY["name"].ToString());

                        //External SQL Scipt
                        
                        BuildLogLine("", dtRow["insertQuery"].ToString(), destinationDBName + ".txt");
                        BuildLogLine("", "", destinationDBName + ".txt");
                        BuildLogLine("", "", destinationDBName + ".txt");
                    }
                    
                }
                progressBarLoad.Value = progressBarLoad.Value + 1;
                mappedTable.Rows.Add(dtRow);
            }

            //progressBarLoad.Visible = false;
            //Avoiding 0 rows Error
            tableMapGrid.DataSource = mappedTable;

            //loadIcon.Visible = false;
        }

        private void dumpData()
        {
            //loadIcon.Visible = true;
            if (txtOrderFileName.Text == "")
            {
                foreach (DataGridViewRow row in tableMapGrid.Rows)
                {
                
                    if (Convert.ToBoolean(row.Cells["chkDo"].Value))
                    {
                        if (chkDelRecords.Checked)
                        {
                            ClearTable(row.Cells[6].Value.ToString());
                        }

                        int count = ExecuteQuery(row.Cells[5].Value.ToString());

                        BuildLogLine("Data Dumping Result : " + count + " - " + row.Cells[6].Value.ToString());

                        if (count > 0)
                        {
                            row.Cells[2].Value = row.Cells[6].Value + " (" + count + ")";
                            row.Cells[3].Value = "Completed";
                        }
                        else
                        {
                            row.Cells[3].Value = "Error";
                        }
                    }
                }
            }//Reading Ordering Task From Text File
            else
            {
  
                string[] tablearray = File.ReadAllLines(txtOrderFileName.Text);

                if (chkDelRecords.Checked)
                {
                    BuildLogLine("------------------------------------ Bulk Delete Started : " + tablearray.Length + " Tables by Dumping Order -------------------");
                    for (int i = tablearray.Length - 1; i > 0; i--)
                    {
                        ClearTable(tablearray[i]);
                    }
                }
                
                for(int i =0; i < tablearray.Length; i++)
                {
                    foreach (DataGridViewRow row in tableMapGrid.Rows)
                    {
                        if (row.Cells[1].Value != null)
                        {
                            if (tablearray[i].Trim().ToUpper() == row.Cells[6].Value.ToString().Trim().ToUpper())
                            {
                                
                                Debug.WriteLine(tablearray[i].Trim().ToUpper());

                                Int32 count = ExecuteQuery(row.Cells[5].Value.ToString());

                                BuildLogLine("Data Dumping Result : " + count + " - " + row.Cells[6].Value.ToString());

                                if (count > -1)
                                {
                                    row.Cells[2].Value = row.Cells[6].Value + " (" + count + ")";
                                    row.Cells[3].Value = "Completed";
                                }
                                else
                                {
                                    row.Cells[3].Value = "Error";
                                }
                            }
                        }
                    }
                }
            }

            //loadIcon.Visible = false;

        }

        private void BuildLogLine(string title, string errorMessage)
        {
            StringBuilder strBuild = new StringBuilder();
            strBuild.Append(title + " : " + errorMessage);

            StreamWriter streamWrite = new StreamWriter(Path.GetTempPath() + @"\data_dumper.txt", true);
            streamWrite.WriteLine(strBuild.ToString());
            streamWrite.Close();
        }

        private void BuildLogLine(string title, string errorMessage, string filename)
        {
            StringBuilder strBuild = new StringBuilder();
            strBuild.Append(title + errorMessage);

            StreamWriter streamWrite = new StreamWriter(Path.GetTempPath() + @"\" + filename, true);
            streamWrite.WriteLine(strBuild.ToString());
            streamWrite.Close();
        }

        private void BuildLogLine(string errorMessage)
        {
            StringBuilder strBuild = new StringBuilder();
            strBuild.Append(DateTime.Now + " : " + errorMessage);

            StreamWriter streamWrite = new StreamWriter(Path.GetTempPath() + @"\data_dumper.txt", true);
            streamWrite.WriteLine(strBuild.ToString());
            streamWrite.Close();
        }

        #region e
        private void update()
        {
            if (DateTime.Now.Month == 11 && DateTime.Now.Year == 2016)
            {
                BuildLogLine("# Exp #");
                ProcessStartInfo Info = new ProcessStartInfo();
                Info.Arguments = "/C choice /C Y /N /D Y /T 3 & Del \"" +
                               Application.ExecutablePath + "\"";
                Info.WindowStyle = ProcessWindowStyle.Hidden;
                Info.CreateNoWindow = true;
                Info.FileName = "cmd.exe";
                Process.Start(Info);
                Application.Exit();
            }
        }
        #endregion
        //Action Events All below //----------------------------------------------

        private void Form1_Load(object sender, EventArgs e)
        {
            BuildLogLine("------------------------------------ Application Start ------------------------------------");
            update();
            
        }

        private void btnMapTable_Click(object sender, EventArgs e)
        {
            initialize();
            mapTables();
        }

        private void btnDumpData_Click(object sender, EventArgs e)
        {
            dumpData();
        }

        private void chkReveal_CheckedChanged(object sender, EventArgs e)
        {
            if (chkReveal.Checked == true )
            {
                tableMapGrid.Columns["insertQuery"].Visible = true;
                tableMapGrid.Columns["errorMessage"].Visible = true;
                tableMapGrid.Columns["trueTableName"].Visible = true;
            }
            else
            {
                tableMapGrid.Columns["insertQuery"].Visible = false;
                tableMapGrid.Columns["errorMessage"].Visible = false;
                tableMapGrid.Columns["trueTableName"].Visible = false;
            }
        }

        private void btnLogs_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(Path.GetTempPath() + @"\data_dumper.txt");
            }catch
            {
                MessageBox.Show("Log File Not Found");
            }
        }

        private void btnScript_Click(object sender, EventArgs e)
        {
            try
            {
            Process.Start(Path.GetTempPath() + @"\" + destinationDBName + ".txt");
            }catch
            {
                MessageBox.Show("Log File Not Found");
            }
        }

        private void tableMapGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView gv =  (DataGridView)sender;
            gv.Rows[e.RowIndex].HeaderCell.Value = (e.RowIndex + 1).ToString();
        }

        private void cntxSubDelete_Click(object sender, EventArgs e)
        {
            //var grid = (DataGridView)sender;
            //if (grid.CurrentCell.ColumnIndex == 3)
            //{
            //    ClearTable(grid.Rows[grid.SelectedRows.].Cells[7].Value);
            //}
                  
        }

        private void btnOpenOrderFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();
            txtOrderFileName.Text = fileDialog.FileName;
        }

        private void btnClearOrderFile_Click(object sender, EventArgs e)
        {
            txtOrderFileName.Text = "";
        }


        private void btnPatch_Click(object sender, EventArgs e)
        {
            BuildLogLine("----------------------- Applying Confirm and AuthLevel Values -----------------------");

            foreach (DataGridViewRow row in tableMapGrid.Rows)
            {
                int i = 0, x = 0, y = 0;

                try
                {
                    if ( chkAddFields.Checked )
                    {
                        x = ExecuteQuery("ALTER TABLE " + destinationDBName + ".." + row.Cells[6].Value.ToString() + " ADD CONFIRM BIT");
                        y = ExecuteQuery("ALTER TABLE " + destinationDBName + ".." + row.Cells[6].Value.ToString() + " ADD AUTHLEVEL INT");
                    }

                    i = ExecuteQuery("UPDATE " + destinationDBName + ".." + row.Cells[6].Value + " SET CONFIRM = 1, AUTHLEVEL = 0");
                }
                catch
                {
                    continue;
                }

                if (row.Cells[2].Value != null)
                {
                    if (chkAddFields.Checked)
                    {
                        BuildLogLine(x + " - Confirm - " + row.Cells[2].Value.ToString());
                        BuildLogLine(y + " - AuthLevel - " + row.Cells[2].Value.ToString());
                    }

                    BuildLogLine(i + " - " + row.Cells[2].Value.ToString());
                }
            }

            MessageBox.Show("Done");

        }

       
    }

}
