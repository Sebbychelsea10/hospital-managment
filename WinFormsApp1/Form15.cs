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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.Entity.Infrastructure;

namespace WinFormsApp1
{
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            SQLiteConnection conn = new SQLiteConnection(@"data source = C:\Users\sebas\Documents\hospital managment\hospitaldb.db");
            conn.Open();

            string query = "Select * from patient";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);



            dgvPatients.DataSource = dt;
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
            txtID.Text = "";


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            string txtQuery = "Update patient Set First_Name='" + txtFirstName.Text + "' WHERE Patient_id = '" + txtID.Text + "'";
            AmendDatabase(txtQuery);
            loadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string txtQuery = "delete from patient where Patient_id='" + txtID.Text + "'";
            AmendDatabase(txtQuery);
            loadData();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form9 form = new Form9();
            form.Show();
        }

        private void dgvPatients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvPatients.SelectedRows[0].Cells[0].Value.ToString();
            txtFirstName.Text = dgvPatients.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
