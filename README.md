# DataDumper

* DataDumper is a simple tool to migrate MS-SQL database data from (one) primary database to (another) secondary database with one simple click.

* It requires primary sql connection string, secondary sql connection string to Initiate the table mapping.
  
* User then compares the available records from primary database to secondary database. user can use the checkboxes to mark wanted tables so that the data can be copied from primary table to secondary table.

* When everything seems ok, user presses [DumpData] button to migrate the selected data records.

------------------------------------------------------------------------------------------------------------------------------------

Delete & Update: Deletes all the records from secondary table before migrating the data from primary table.

Template: Template is just a list of table names of the database. Using template, user can avoid checking tables manually. System uses this list as a checklist for migration in the same order so that it can avoid primary key / foreignkey contraints when copying/deletion occur.

Anybody who wants to improve this Utility is welcome. :)
