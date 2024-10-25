using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public static Form2 instance;

        public Form2()
        {
            InitializeComponent();
            instance = this;
        }

        private void lblButton_Click(object sender, EventArgs e)
        {
            string FirstName = txtFirstName.Text;
            string LastName = txtLastName.Text;
            string Email = txtEmail.Text;
            string Username = txtUsername.Text;
            string password = txtPassword.Text;
            string DateOfBirth = txtDateOfBirth.Text;
            string MobileNumber = txtMobileNumber.Text;
            string ConfirmPassword = txtConfirmPassword.Text;

            // Connection object
            SQLiteConnection conn = new SQLiteConnection(@"data source = C:\Users\sebas\Documents\hospital managment\hospitaldb.db");
            conn.Open();

            // Connect to an object
            string query = "SELECT * FROM Patient WHERE Email = '" + Email + "' AND UserName = '" + Username + "' AND First_Name = '" + FirstName + "' AND Last_Name = '" + LastName + "' AND Password = '" + password + "' AND DateOfBirth = '" + DateOfBirth + "' AND MobileNumber = '" + MobileNumber + "' AND ConfirmPassword = '" + ConfirmPassword + "'";

            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("email", Email);
            cmd.Parameters.AddWithValue("First_Name", FirstName);
            cmd.Parameters.AddWithValue("Last_Name", LastName);
            cmd.Parameters.AddWithValue("username", Username);
            cmd.Parameters.AddWithValue("password", password);
            cmd.Parameters.AddWithValue("ConfirmPassword", ConfirmPassword);
            cmd.Parameters.AddWithValue("MobileNumber", MobileNumber);
            cmd.Parameters.AddWithValue("DateOfBirth", DateOfBirth);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            
            




            // string dbquery ="insert into patient( email, Username, Password, DateOfBirth, MobileNumber, ConfirmPassword) values('"+ Email"',"'+' +
            string dbquery = "Insert into patient (First_Name, Last_Name, email, Username, Password, DateOfBirth, MobileNumber, ConfirmPassword) values ('" + FirstName + "','" + LastName + "', '" + Email + "', '" + Username + "', '" + password + "', '" + DateOfBirth + "', '" + MobileNumber + "', '" + ConfirmPassword + "')";
            AmendDatabase(dbquery);
            loadData();


            conn.Close();
        }

        private void loadData()
        {
            SQLiteConnection conn = new SQLiteConnection(@"data source = C:\Users\sebas\Documents\hospital managment\hospitaldb.db");
            conn.Open();

            string query = "Select * from Patient ";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Sign Up Successful");
                Form4 form = new Form4();
                form.Show();


            }



            conn.Close();

        }

        private void AmendDatabase(string txtquery)
        {
            SQLiteConnection conn = new SQLiteConnection(@"data source = C:\Users\sebas\Documents\hospital managment\hospitaldb.db");
            conn.Open();
            string query = txtquery;
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtDateOfBirth.Text = "";
            txtMobileNumber.Text = "";
            txtConfirmPassword.Text = "";


        }
    }
}

