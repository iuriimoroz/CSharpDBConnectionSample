using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace DemoDBConnection
{
    public partial class DemoDBConnectionForm : Form
    {
        public DemoDBConnectionForm()
        {
            InitializeComponent();
        }

        private void TestDBConectionButton_Click(object sender, EventArgs e)
        {
            //Variables declaration
            string  connectionString;
            SqlConnection testConnection;

            //Set connection string
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\iurii\source\repos\DemoDBConnection\DemoDBConnection\TestDB.mdf;Integrated Security=True";
            //Assign connection
            testConnection = new SqlConnection(connectionString);
            //Code which test SQL connection
            try
            {
                testConnection.Open();
                MessageBox.Show("Connection open!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to data source");
            }
            finally
            {
                testConnection.Close();
                MessageBox.Show("Connection closed!");
            }

        }

        private void ReadDataFromDBButton_Click(object sender, EventArgs e)
        {
            //Variables declaration
            string connectionString;
            SqlConnection testConnection;
            SqlCommand command;
            SqlDataReader dataReader;
            String sql, Output = "";

            //Set connection string
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\iurii\source\repos\DemoDBConnection\DemoDBConnection\TestDB.mdf;Integrated Security=True";
            //Assign connection
            testConnection = new SqlConnection(connectionString);

            //Define SQL statement
            sql = "Select TutorialID, TutorialName from dbo.tutorials";

            //The command statement (after opening DB connection)
            testConnection.Open();
            command = new SqlCommand(sql, testConnection);
            //Define the data reader
            dataReader = command.ExecuteReader();
            //Get the table values
            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + "\n";
            }
            //Displaying output to the user
            MessageBox.Show(Output);

            //Closing all objects
            dataReader.Close();
            command.Dispose();
            testConnection.Close();
        }
    }
}
