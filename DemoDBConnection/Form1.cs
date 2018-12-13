using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DemoDBConnection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            string  connectionSting;
            SqlConnection testConnection;

            connectionSting = @"Data Source=C:\Users\iurii\Documents\TestDB.accdb";
            testConnection = new SqlConnection(connectionSting);
            testConnection.Open();
            MessageBox.Show("Connection open!");
            testConnection.Close();

        }
    }
}
