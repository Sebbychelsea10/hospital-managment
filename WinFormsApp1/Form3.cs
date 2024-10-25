using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public static Form3 instance;

        public Form3()
        {
            InitializeComponent();
            instance = this;
        }

        private void lblButton_Click(object sender, EventArgs e)
        {

            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Connection object
            SQLiteConnection conn = new SQLiteConnection(@"data source = C:\Users\sebas\Documents\hospital managment\hospitaldb.db");
            conn.Open();

            // Connecto to an object
            string query = "SELECT * FROM Patient WHERE UserName = '" + username + "' AND Password = '" + password + "'";

            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("username", username);
            cmd.Parameters.AddWithValue("password", password);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login Successful");
                Form4 form = new Form4();
                form.Show();
            }
            else
            {
                MessageBox.Show("Error");
            }


            conn.Close();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}