namespace DataDumper
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDumpData = new System.Windows.Forms.Button();
            this.cmbSqlInstanceList = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tableMapGrid = new System.Windows.Forms.DataGridView();
            this.chkDo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sourceTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insertQuery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trueTableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntxGridOption = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cntxSubDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMapTable = new System.Windows.Forms.Button();
            this.chkReveal = new System.Windows.Forms.CheckBox();
            this.chkDelRecords = new System.Windows.Forms.CheckBox();
            this.progressBarLoad = new System.Windows.Forms.ProgressBar();
            this.btnLogs = new System.Windows.Forms.Button();
            this.btnScript = new System.Windows.Forms.Button();
            this.btnPatch = new System.Windows.Forms.Button();
            this.chkAddFields = new System.Windows.Forms.CheckBox();
            this.txtOrderFileName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOpenOrderFile = new System.Windows.Forms.Button();
            this.btnClearOrderFile = new System.Windows.Forms.Button();
            this.orderDialog = new System.Windows.Forms.OpenFileDialog();
            this.loadIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tableMapGrid)).BeginInit();
            this.cntxGridOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(641, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Language=British;Data Source=HPI7\\SQL2008r2;Initial catalog=VOPAKPAY;uid=sa;pwd=b" +
    "cc;";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(96, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(641, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Language=British;Data Source=HPI7\\SQL2008r2;Initial catalog=VOPAKPAY;uid=sa;pwd=b" +
    "cc;";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Source DB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destination DB";
            // 
            // btnDumpData
            // 
            this.btnDumpData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDumpData.Location = new System.Drawing.Point(844, 143);
            this.btnDumpData.Name = "btnDumpData";
            this.btnDumpData.Size = new System.Drawing.Size(75, 46);
            this.btnDumpData.TabIndex = 4;
            this.btnDumpData.Text = "Start Dumping";
            this.btnDumpData.UseVisualStyleBackColor = true;
            this.btnDumpData.Click += new System.EventHandler(this.btnDumpData_Click);
            // 
            // cmbSqlInstanceList
            // 
            this.cmbSqlInstanceList.FormattingEnabled = true;
            this.cmbSqlInstanceList.Location = new System.Drawing.Point(96, 12);
            this.cmbSqlInstanceList.Name = "cmbSqlInstanceList";
            this.cmbSqlInstanceList.Size = new System.Drawing.Size(285, 21);
            this.cmbSqlInstanceList.TabIndex = 5;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(388, 11);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(270, 21);
            this.comboBox2.TabIndex = 6;
            // 
            // tableMapGrid
            // 
            this.tableMapGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableMapGrid.BackgroundColor = System.Drawing.Color.Gray;
            this.tableMapGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableMapGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tableMapGrid.ColumnHeadersHeight = 40;
            this.tableMapGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkDo,
            this.sourceTable,
            this.destinationTable,
            this.status,
            this.errorMessage,
            this.insertQuery,
            this.trueTableName});
            this.tableMapGrid.ContextMenuStrip = this.cntxGridOption;
            this.tableMapGrid.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.tableMapGrid.Location = new System.Drawing.Point(96, 123);
            this.tableMapGrid.Name = "tableMapGrid";
            this.tableMapGrid.RowHeadersWidth = 60;
            this.tableMapGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.tableMapGrid.Size = new System.Drawing.Size(720, 303);
            this.tableMapGrid.TabIndex = 7;
            this.tableMapGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.tableMapGrid_CellFormatting);
            // 
            // chkDo
            // 
            this.chkDo.DataPropertyName = "chkDo";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.NullValue = false;
            this.chkDo.DefaultCellStyle = dataGridViewCellStyle4;
            this.chkDo.FalseValue = "false";
            this.chkDo.HeaderText = "✓";
            this.chkDo.Name = "chkDo";
            this.chkDo.TrueValue = "true";
            this.chkDo.Width = 30;
            // 
            // sourceTable
            // 
            this.sourceTable.DataPropertyName = "sourceTable";
            this.sourceTable.HeaderText = "Source Table";
            this.sourceTable.Name = "sourceTable";
            this.sourceTable.ReadOnly = true;
            this.sourceTable.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sourceTable.Width = 230;
            // 
            // destinationTable
            // 
            this.destinationTable.DataPropertyName = "destinationTable";
            this.destinationTable.HeaderText = "Destination Table";
            this.destinationTable.Name = "destinationTable";
            this.destinationTable.ReadOnly = true;
            this.destinationTable.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.destinationTable.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.destinationTable.Width = 230;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // errorMessage
            // 
            this.errorMessage.DataPropertyName = "errorMessage";
            this.errorMessage.HeaderText = "Error Message";
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.errorMessage.Visible = false;
            // 
            // insertQuery
            // 
            this.insertQuery.DataPropertyName = "insertQuery";
            this.insertQuery.HeaderText = "insertQuery";
            this.insertQuery.Name = "insertQuery";
            this.insertQuery.Visible = false;
            this.insertQuery.Width = 200;
            // 
            // trueTableName
            // 
            this.trueTableName.DataPropertyName = "trueTableName";
            this.trueTableName.HeaderText = "TableName";
            this.trueTableName.Name = "trueTableName";
            this.trueTableName.Visible = false;
            // 
            // cntxGridOption
            // 
            this.cntxGridOption.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cntxSubDelete});
            this.cntxGridOption.Name = "cntxGridOption";
            this.cntxGridOption.Size = new System.Drawing.Size(139, 26);
            // 
            // cntxSubDelete
            // 
            this.cntxSubDelete.Name = "cntxSubDelete";
            this.cntxSubDelete.Size = new System.Drawing.Size(138, 22);
            this.cntxSubDelete.Text = "Delete Right";
            this.cntxSubDelete.Click += new System.EventHandler(this.cntxSubDelete_Click);
            // 
            // btnMapTable
            // 
            this.btnMapTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMapTable.Location = new System.Drawing.Point(844, 91);
            this.btnMapTable.Name = "btnMapTable";
            this.btnMapTable.Size = new System.Drawing.Size(75, 46);
            this.btnMapTable.TabIndex = 8;
            this.btnMapTable.Text = "Map Tables";
            this.btnMapTable.UseVisualStyleBackColor = true;
            this.btnMapTable.Click += new System.EventHandler(this.btnMapTable_Click);
            // 
            // chkReveal
            // 
            this.chkReveal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkReveal.AutoSize = true;
            this.chkReveal.Location = new System.Drawing.Point(844, 232);
            this.chkReveal.Name = "chkReveal";
            this.chkReveal.Size = new System.Drawing.Size(90, 17);
            this.chkReveal.TabIndex = 9;
            this.chkReveal.Text = "Reveal Fields";
            this.chkReveal.UseVisualStyleBackColor = true;
            this.chkReveal.CheckedChanged += new System.EventHandler(this.chkReveal_CheckedChanged);
            // 
            // chkDelRecords
            // 
            this.chkDelRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkDelRecords.AutoSize = true;
            this.chkDelRecords.Location = new System.Drawing.Point(844, 209);
            this.chkDelRecords.Name = "chkDelRecords";
            this.chkDelRecords.Size = new System.Drawing.Size(88, 17);
            this.chkDelRecords.TabIndex = 10;
            this.chkDelRecords.Text = "Clear n Insert";
            this.chkDelRecords.UseVisualStyleBackColor = true;
            // 
            // progressBarLoad
            // 
            this.progressBarLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarLoad.Location = new System.Drawing.Point(636, 431);
            this.progressBarLoad.Name = "progressBarLoad";
            this.progressBarLoad.Size = new System.Drawing.Size(180, 23);
            this.progressBarLoad.TabIndex = 11;
            this.progressBarLoad.Visible = false;
            // 
            // btnLogs
            // 
            this.btnLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogs.Location = new System.Drawing.Point(96, 431);
            this.btnLogs.Name = "btnLogs";
            this.btnLogs.Size = new System.Drawing.Size(75, 23);
            this.btnLogs.TabIndex = 12;
            this.btnLogs.Text = "Error Logs";
            this.btnLogs.UseVisualStyleBackColor = true;
            this.btnLogs.Click += new System.EventHandler(this.btnLogs_Click);
            // 
            // btnScript
            // 
            this.btnScript.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnScript.Location = new System.Drawing.Point(177, 431);
            this.btnScript.Name = "btnScript";
            this.btnScript.Size = new System.Drawing.Size(75, 23);
            this.btnScript.TabIndex = 13;
            this.btnScript.Text = "Scripts";
            this.btnScript.UseVisualStyleBackColor = true;
            this.btnScript.Click += new System.EventHandler(this.btnScript_Click);
            // 
            // btnPatch
            // 
            this.btnPatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPatch.Location = new System.Drawing.Point(844, 281);
            this.btnPatch.Name = "btnPatch";
            this.btnPatch.Size = new System.Drawing.Size(92, 23);
            this.btnPatch.TabIndex = 14;
            this.btnPatch.Text = "Patch Confirm";
            this.btnPatch.UseVisualStyleBackColor = true;
            this.btnPatch.Click += new System.EventHandler(this.btnPatch_Click);
            // 
            // chkAddFields
            // 
            this.chkAddFields.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkAddFields.AutoSize = true;
            this.chkAddFields.Location = new System.Drawing.Point(844, 310);
            this.chkAddFields.Name = "chkAddFields";
            this.chkAddFields.Size = new System.Drawing.Size(97, 17);
            this.chkAddFields.TabIndex = 15;
            this.chkAddFields.Text = "Add with Fields";
            this.chkAddFields.UseVisualStyleBackColor = true;
            // 
            // txtOrderFileName
            // 
            this.txtOrderFileName.Location = new System.Drawing.Point(96, 91);
            this.txtOrderFileName.Name = "txtOrderFileName";
            this.txtOrderFileName.Size = new System.Drawing.Size(562, 20);
            this.txtOrderFileName.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Dumping Order";
            // 
            // btnOpenOrderFile
            // 
            this.btnOpenOrderFile.Location = new System.Drawing.Point(664, 89);
            this.btnOpenOrderFile.Name = "btnOpenOrderFile";
            this.btnOpenOrderFile.Size = new System.Drawing.Size(73, 23);
            this.btnOpenOrderFile.TabIndex = 18;
            this.btnOpenOrderFile.Text = "Browse ";
            this.btnOpenOrderFile.UseVisualStyleBackColor = true;
            this.btnOpenOrderFile.Click += new System.EventHandler(this.btnOpenOrderFile_Click);
            // 
            // btnClearOrderFile
            // 
            this.btnClearOrderFile.Location = new System.Drawing.Point(743, 89);
            this.btnClearOrderFile.Name = "btnClearOrderFile";
            this.btnClearOrderFile.Size = new System.Drawing.Size(73, 23);
            this.btnClearOrderFile.TabIndex = 19;
            this.btnClearOrderFile.Text = "Clear";
            this.btnClearOrderFile.UseVisualStyleBackColor = true;
            this.btnClearOrderFile.Click += new System.EventHandler(this.btnClearOrderFile_Click);
            // 
            // loadIcon
            // 
            this.loadIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadIcon.Image = global::DataDumper.Properties.Resources.throbber_full;
            this.loadIcon.Location = new System.Drawing.Point(409, 227);
            this.loadIcon.Name = "loadIcon";
            this.loadIcon.Size = new System.Drawing.Size(94, 94);
            this.loadIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.loadIcon.TabIndex = 20;
            this.loadIcon.TabStop = false;
            this.loadIcon.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(205)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(948, 459);
            this.Controls.Add(this.loadIcon);
            this.Controls.Add(this.btnClearOrderFile);
            this.Controls.Add(this.btnOpenOrderFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOrderFileName);
            this.Controls.Add(this.chkAddFields);
            this.Controls.Add(this.btnPatch);
            this.Controls.Add(this.btnScript);
            this.Controls.Add(this.btnLogs);
            this.Controls.Add(this.progressBarLoad);
            this.Controls.Add(this.chkDelRecords);
            this.Controls.Add(this.chkReveal);
            this.Controls.Add(this.btnMapTable);
            this.Controls.Add(this.tableMapGrid);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.cmbSqlInstanceList);
            this.Controls.Add(this.btnDumpData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableMapGrid)).EndInit();
            this.cntxGridOption.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loadIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDumpData;
        private System.Windows.Forms.ComboBox cmbSqlInstanceList;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView tableMapGrid;
        private System.Windows.Forms.Button btnMapTable;
        private System.Windows.Forms.CheckBox chkReveal;
        private System.Windows.Forms.CheckBox chkDelRecords;
        private System.Windows.Forms.ProgressBar progressBarLoad;
        private System.Windows.Forms.Button btnLogs;
        private System.Windows.Forms.Button btnScript;
        private System.Windows.Forms.Button btnPatch;
        private System.Windows.Forms.CheckBox chkAddFields;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourceTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn errorMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn insertQuery;
        private System.Windows.Forms.DataGridViewTextBoxColumn trueTableName;
        private System.Windows.Forms.ContextMenuStrip cntxGridOption;
        private System.Windows.Forms.ToolStripMenuItem cntxSubDelete;
        private System.Windows.Forms.TextBox txtOrderFileName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOpenOrderFile;
        private System.Windows.Forms.Button btnClearOrderFile;
        private System.Windows.Forms.OpenFileDialog orderDialog;
        private System.Windows.Forms.PictureBox loadIcon;
    }
}

