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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }



        private void btnSubmit_Click(object sender, EventArgs e)
        {

            string Name = txtName.Text;
            string Medication = txtMedication.Text;
            string Dosage = txtDosage.Text;

            // Connection object
            SQLiteConnection conn = new SQLiteConnection(@"data source = C:\Users\sebas\Documents\hospital managment\hospitaldb.db");
            conn.Open();

            // Connecto to an object
            string query = "SELECT * FROM Medication WHERE Name ='" + Name + "' AND Medication ='" + Medication + "' AND Dosage = '" + Dosage + "'";

            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("Medication", Medication);
            cmd.Parameters.AddWithValue("Name", Name);
            cmd.Parameters.AddWithValue("Dosage", Dosage);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            



            string dbquery = "Insert into Medication (Name, Medication, Dosage) values ('" + Name + "','" + Medication + "', '" + Dosage+ "')";
            AmendDatabase(dbquery);
            loadData();

            conn.Close();
        }




        private void loadData()
        {
            SQLiteConnection conn = new SQLiteConnection(@"data source = C:\Users\sebas\Documents\hospital managment\hospitaldb.db");
            conn.Open();

            string query = "Select * from Medication ";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Prescribing Prescription has been confirmed");
                Form9 form = new Form9();
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

            txtName.Text = "";
            txtMedication.Text = "";
            txtDosage.Text = "";

        }
    }
    }


