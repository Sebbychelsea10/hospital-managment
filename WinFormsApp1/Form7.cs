using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }



        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string CancelationDate = txtCancelationDate.Text;
            string ReasonForCancelation = txtReasonForCancelation.Text;

            // Connection object
            SQLiteConnection conn = new SQLiteConnection(@"data source = C:\Users\sebas\Documents\hospital managment\hospitaldb.db");
            conn.Open();

            // Connecto to an object
            string query = "SELECT * FROM Appointment WHERE Reason_For_Cancelation = '" + ReasonForCancelation + "' AND Cancelation_Date ='" + CancelationDate + "'";

            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("Cancelation_Date", CancelationDate);
            cmd.Parameters.AddWithValue("Reason_For_Cancelation", ReasonForCancelation);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);




          

        string dbquery = "Insert into Appointment (Cancelation_Date, Reason_For_Cancelation) values ('" + CancelationDate + "','" + ReasonForCancelation + "')";
        AmendDatabase(dbquery);
        loadData();

        conn.Close();
        }




    private void loadData()
    {
        SQLiteConnection conn = new SQLiteConnection(@"data source = C:\Users\sebas\Documents\hospital managment\hospitaldb.db");
        conn.Open();

        string query = "Select * from Appointment ";
        SQLiteCommand cmd = new SQLiteCommand(query, conn);
        DataTable dt = new DataTable();
        SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
        adapter.Fill(dt);

        if (dt.Rows.Count > 0)
        {
            MessageBox.Show("Your Cancelation has been confirmed!");
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

        txtCancelationDate.Text = "";
        txtReasonForCancelation.Text = "";

    }
}
}
