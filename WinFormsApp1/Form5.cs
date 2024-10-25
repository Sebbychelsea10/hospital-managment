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

namespace WinFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void lblLoginIn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Connection object
            SQLiteConnection conn = new SQLiteConnection(@"data source = C:\Users\sebas\Documents\hospital managment\hospitaldb.db");
            conn.Open();

            // Connecto to an object
            string query = "SELECT * FROM Doctor WHERE UserNameId = '" + username + "' AND Password = '" + password + "'";

            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("UserName Id", username);
            cmd.Parameters.AddWithValue("Password", password);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login Successful");
                Form15 form = new Form15();
                form.Show();
            }
            else
            {
                MessageBox.Show("Error");
            }



            conn.Close();

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}

