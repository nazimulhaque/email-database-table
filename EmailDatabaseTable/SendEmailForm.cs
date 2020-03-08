using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Linq;
using System.IO;

namespace EmailDatabaseTable
{
    public partial class SendEmailForm : Form
    {
        public SendEmailForm()
        {
            InitializeComponent();
        }

        private void btnGoToSettings_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            this.Hide();
            settingsForm.ShowDialog();
            this.Close();
        }

        private void SendEmailForm_Load(object sender, EventArgs e)
        {
            comboBoxSelectDatabase.DataSource = GetDatabaseList();
            comboBoxSelectTable.DataSource = GetDatabaseTableList();
            comboBoxSelectDate.DataSource = GeteCorrectionTableDateList();
        }

        public List<string> GetDatabaseList()
        {
            List<string> list = new List<string>();

            string databaseServer = Properties.Settings.Default.DatabaseServerIp;
            string userId = Properties.Settings.Default.DatabaseUserId;
            string userPassword = Properties.Settings.Default.DatabaseUserPassword;
            SqlConnection myConnection = new SqlConnection("user id = " + userId + "; password = abc123" + userPassword
                + "; server = " + databaseServer
                + "; Trusted_Connection = yes"
                + "; database = master;"
                + "MultipleActiveResultSets=true; connection timeout = 30");

            using (myConnection)
            {
                myConnection.Open();

                // Set up a command with the given query and associate
                // this with the current connection.
                using (SqlCommand cmd = new SqlCommand("SELECT name from sys.databases", myConnection))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            list.Add(dr[0].ToString());
                        }
                    }
                }

                myConnection.Close();
            }
            return list;
        }

        public List<string> GetDatabaseTableList()
        {
            List<string> list = new List<string>();

            string databaseServer = Properties.Settings.Default.DatabaseServerIp;
            string userId = Properties.Settings.Default.DatabaseUserId;
            string userPassword = Properties.Settings.Default.DatabaseUserPassword;
            string database = comboBoxSelectDatabase.Text;
            SqlConnection myConnection = new SqlConnection("user id = " + userId + "; password = abc123" + userPassword
                + "; server = " + databaseServer
                + "; Trusted_Connection = yes"
                + "; database = " + database
                + "; MultipleActiveResultSets=true; connection timeout = 30");

            using (myConnection)
            {
                myConnection.Open();

                // Set up a command with the given query and associate
                // this with the current connection.
                using (SqlCommand cmd = new SqlCommand("SELECT name from sys.tables", myConnection))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            list.Add(dr[0].ToString());
                        }
                    }
                }

                myConnection.Close();
            }
            return list;
        }
        public List<string> GeteCorrectionTableDateList()
        {
            List<string> list = new List<string>();

            string databaseServer = Properties.Settings.Default.DatabaseServerIp;
            string userId = Properties.Settings.Default.DatabaseUserId;
            string userPassword = Properties.Settings.Default.DatabaseUserPassword;
            string database = comboBoxSelectDatabase.Text;
            string table = comboBoxSelectTable.Text;
            SqlConnection myConnection = new SqlConnection("user id = " + userId + "; password = abc123" + userPassword
                + "; server = " + databaseServer
                + "; Trusted_Connection = yes"
                + "; database = " + database
                + "; MultipleActiveResultSets=true; connection timeout = 30");

            using (myConnection)
            {
                myConnection.Open();

                // Set up a command with the given query and associate
                // this with the current connection.
                using (SqlCommand cmd = new SqlCommand("SELECT DISTINCT cor_date from " + table + " ORDER BY cor_date DESC", myConnection))
                {
                    try
                    {
                        using (IDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                list.Add(dr[0].ToString());
                            }
                        }
                    }
                    catch
                    {
                        return null;
                    }
                }

                myConnection.Close();
            }
            return list;
        }

        private void comboBoxSelectDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxSelectTable.DataSource = null;
            comboBoxSelectTable.DataSource = GetDatabaseTableList();
        }

        private void comboBoxSelectTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxSelectDate.DataSource = null;
            comboBoxSelectDate.DataSource = GeteCorrectionTableDateList();
        }

        public void convertTableToDBF()
        {
            OleDbConnection conn;
            OleDbCommand cmd;
            OleDbDataReader dr;
            string sqlStr = "";
            DataSet myDataSet;
            OleDbDataAdapter myAdapter;
            conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\Temp\\DBF\\;Extended Properties=DBASE IV;");
            conn.Open();
            sqlStr = "Select * from testdbf.dbf";
            //Make a DataSet object
            myDataSet = new DataSet();
            //Using the OleDbDataAdapter execute the query
            myAdapter = new OleDbDataAdapter(sqlStr, conn);
            //Build the Update and Delete SQL Statements
            OleDbCommandBuilder myBuilder = new OleDbCommandBuilder(myAdapter);

            //Fill the DataSet with the Table 
            myAdapter.Fill(myDataSet, "somename");
        }

        public void convertTableToExcel()
        {
            string databaseServer = Properties.Settings.Default.DatabaseServerIp;
            string userId = Properties.Settings.Default.DatabaseUserId;
            string userPassword = Properties.Settings.Default.DatabaseUserPassword;
            string database = comboBoxSelectDatabase.Text;
            string table = comboBoxSelectTable.Text;
            string date = comboBoxSelectDate.Text;
            SqlConnection myConnection = new SqlConnection("user id = " + userId + "; password = abc123" + userPassword
                + "; server = " + databaseServer
                + "; Trusted_Connection = yes"
                + "; database = " + database
                + "; MultipleActiveResultSets=true; connection timeout = 30");

            SqlCommand command = new SqlCommand();
            command.CommandText = "select * from " + table;

            DataTable dataTable = new DataTable();
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command.CommandText, myConnection))
            {
                dataAdapter.Fill(dataTable);
            }

            Excel.Application xlApp = new Excel.Application();

            if (xlApp == null)
            {
                MessageBox.Show("Excel is not properly installed!");
                return;
            }


            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            var lines = new List<string>();

            string[] columnNames = dataTable.Columns
                .Cast<DataColumn>()
                .Select(column => column.ColumnName)
                .ToArray();

            var header = string.Join(",", columnNames.Select(name => $"\"{name}\""));
            lines.Add(header);

            var valueLines = dataTable.AsEnumerable()
                .Select(row => string.Join(",", row.ItemArray.Select(val => $"\"{val}\"")));

            lines.AddRange(valueLines);

            File.WriteAllLines("d:\\excel.csv", lines);

            xlWorkBook.SaveAs("d:\\csharp-Excel.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);

            MessageBox.Show("Excel file created , you can find the file d:\\csharp-Excel.xls");
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            convertTableToExcel();
        }
    }
}
