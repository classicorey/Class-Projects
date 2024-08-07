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
using System.Diagnostics;

namespace IT481_Unit2_Crooks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.employeesTableAdapter.Fill(this.dataSet1.Employees);
            this.ordersTableAdapter.Fill(this.dataSet1.Orders);
            System.Diagnostics.Debug.WriteLine("Form1_Load() called...");
            txtMessageText.Text = "Warming up. Hang tight."; 
            try
            {
                var datasource = @"(local)\SQLEXPRESS";
                var database = "Northwind";
                var thisUsername = frmLogin.username;
                var thisPassword = frmLogin.password;
                lblUser.Text = "Logged in as " + thisUsername + ".";
                string connString = @"Data Source=" + datasource + ";Initial Catalog=" +
                database + ";Persist Security Info=True;User ID=" + thisUsername + ";Password=" +
                thisPassword;
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                txtMessageText.ForeColor = System.Drawing.Color.Green;
                txtMessageText.Text = "We've connected to the database with those credentials! Select some options below to get started...";
                conn.Close();

                if(thisUsername == "User_Sales")
                {
                    radCustomers.Visible = false;
                    radEmployees.Visible = false;
                    radOrders.Visible =true;
                }

                if (thisUsername == "User_HR")
                {
                    radCustomers.Visible = false;
                    radEmployees.Visible = true;
                    radOrders.Visible = false;
                }

                if (thisUsername == "User_CEO")
                {
                    radCustomers.Visible = true;
                    radEmployees.Visible = true;
                    radOrders.Visible = true;
                }

            }
            catch (Exception ex)
            {
                txtMessageText.Text = "We couldn't establish connection to the database. Error: "+ ex;
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand command = new SqlCommand();
                SqlConnection connection = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True");
                connection.Open();
                txtMessageText.Text = "Let's try inserting that record.";
                command.Connection = connection;
                command.CommandText = "insert into Customers (ID, Company) values('" +
                txtID.Text + "','" + txtCompany.Text + "')";
                command.ExecuteNonQuery();
                txtMessageText.Text = "That record has been successfully inserted!";
                connection.Close();
            }

            catch
            {
                txtMessageText.Text = "I couldn't do that. There was something wrong with your SQL insertion.";
                txtMessageText.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            txtMessageText.ForeColor = System.Drawing.Color.Black;
            SqlCommand command = new SqlCommand();
            SqlConnection connection = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True");
            connection.Open();
            txtMessageText.Text = "I'm counting the records now.";
            command.Connection = connection;
            command.CommandText = "select count(*) from Customers";
            int count = (int)command.ExecuteScalar();
            txtMessageText.Text = "We currently have " + count + " records.";
            connection.Close();
            txtMessageText.ForeColor = System.Drawing.Color.Green;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            bool validInput = true;
            string currentTable = "";
            if (radCustomers.Checked)
            {
                currentTable = "Customers";
            }

            else if (radEmployees.Checked)
            {
                currentTable = "Employees";
            }

            else if (radOrders.Checked)
            {
                currentTable = "Orders";
            }

            else
            {
                validInput = false;
                txtMessageText.Text = "You need to select a table to view before you can get results.";
                txtMessageText.ForeColor = System.Drawing.Color.Red;
            }
            if (validInput == true)
            {

                dataGridView1.DataSource = null;
                try
                {
                    SqlCommand command = new SqlCommand();
                    var datasource = @"(local)\SQLEXPRESS";
                    var database = "Northwind";
                    var thisUsername = frmLogin.username;
                    var thisPassword = frmLogin.password;
                    string connString = @"Data Source=" + datasource + ";Initial Catalog=" +
                    database + ";Persist Security Info=True;User ID=" + thisUsername + ";Password=" +
                    thisPassword;
                    SqlConnection conn = new SqlConnection(connString);
                    conn.Open();
                    txtMessageText.Text = "I'm gathering up the records.";
                    command.Connection = conn;
                    command.CommandText = "select * from " + currentTable;
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    txtMessageText.Text = "All records from the Customers table are successfully retrieved!";
                    txtMessageText.ForeColor = System.Drawing.Color.Green;
                    conn.Close();
                }

                catch (Exception ex)
                {
                    txtMessageText.Text = "Unfortunately I can't let " + frmLogin.username + " view the " + currentTable + " table. \n\nAdvanced Error report: " + ex;
                    txtMessageText.ForeColor = System.Drawing.Color.Red;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                txtMessageText.ForeColor = System.Drawing.Color.Black;
                SqlCommand command = new SqlCommand();
                SqlConnection connection = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True");
                connection.Open();
                txtMessageText.Text = "I'll try deleting that record now.";
                command.Connection = connection;
                command.CommandText = "delete from Customers where CustomerID='" + txtID.Text + "'";
                command.ExecuteNonQuery();
                txtMessageText.Text = "Record successfully deleted!";
                connection.Close();
                txtMessageText.ForeColor = System.Drawing.Color.Green;
            }

            catch
            {
                txtMessageText.Text = "I couldn't do that. There was something wrong with your SQL deletion.";
                txtMessageText.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
