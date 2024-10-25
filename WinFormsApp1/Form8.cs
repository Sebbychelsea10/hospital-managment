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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void lblConfirm_Click(object sender, EventArgs e)
        {

            string DateChange = txtDateChange.Text;
            string ReasonForDateChange = txtReasonForDateChange.Text;

            // Connection object
            SQLiteConnection conn = new SQLiteConnection(@"data source = C:\Users\sebas\Documents\hospital managment\hospitaldb.db");
            conn.Open();

            // Connecto to an object
            string query = "SELECT * FROM Appointment WHERE Date_Change ='" + DateChange + "' AND Reason_For_Date_Change = '" + ReasonForDateChange + "'";

            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("Date_Change", DateChange);
            cmd.Parameters.AddWithValue("Reason_For Date_Change", ReasonForDateChange);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            



            

        string dbquery = "Insert into Appointment (Date_Change, Reason_For_Date_Change) values ('" + DateChange + "','" + ReasonForDateChange + "')";
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
            MessageBox.Show("Your Appointment Change has been successful!");
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

        txtDateChange.Text = "";
        txtReasonForDateChange.Text = "";

    }
}
}
