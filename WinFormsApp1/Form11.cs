﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsApp1
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }




        private void Form11_Load(object sender, EventArgs e)
        {
            loadData();

        }

        private void loadData()
        {
            SQLiteConnection conn = new SQLiteConnection(@"data source = C:\Users\sebas\Documents\hospital managment\hospitaldb.db");
            conn.Open();

            string query = "Select * from Patient_Medical_History";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);



            dgvPatientMedicalHistory.DataSource = dt;
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




        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form9 form = new Form9();
            form.Show();
        }
    }
}
