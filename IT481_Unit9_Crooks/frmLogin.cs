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
using System.Windows.Forms.VisualStyles;

namespace IT481_Unit2_Crooks
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txtErrorMessage.Visible = false;
            txtErrorMessage.ForeColor = System.Drawing.Color.Red;
            txtErrorMessage.SelectAll();
            txtErrorMessage.SelectionAlignment = HorizontalAlignment.Center;
            txtErrorMessage.DeselectAll();
            txtPassword.PasswordChar = '\x2022';
        }

        public static string username = "";
        public static string password = "";
        private void btnLogin_Click(object sender, EventArgs e)
        {
            username = txtUsername.Text;
            password = txtPassword.Text;
            if (username == "" || password == "")
            {
                txtErrorMessage.Text = "You need to enter your credentials before connecting to the database.";
                txtErrorMessage.Visible = true;
            }
            else
            {
                var datasource = @"(local)\SQLEXPRESS";
                var database = "Northwind";
                var thisUsername = username;
                var thisPassword = password;
                string connString = @"Data Source=" + datasource + ";Initial Catalog=" +
               database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;
                SqlConnection conn = new SqlConnection(connString);
                try
                {
                    conn.Open();
                    Form1 frm1 = new Form1();
                    frm1.Show();
                    txtErrorMessage.Text = "We've successfully logged you in! The database is open in a new window.";
                    txtErrorMessage.ForeColor = System.Drawing.Color.Green;
                    txtErrorMessage.Visible = true;
                }
                catch
                {
                    txtErrorMessage.Text = "It seems that we can't connect to the database using those credentials.";
                    txtErrorMessage.Visible = true;
                }
            }
        }
    }
}
