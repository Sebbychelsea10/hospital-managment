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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string Patient = txtPatient.Text;
            string RebookAppointment = txtRebookAppointment.Text;
            string ReasonForRebookingAppointment = txtReasonForRebookingAppointment.Text;


            // Connection object
            SQLiteConnection conn = new SQLiteConnection(@"data source = C:\Users\sebas\Documents\hospital managment\hospitaldb.db");
            conn.Open();

            // Connecto to an object
            string query = "SELECT * FROM Appointment WHERE Rebook_Appointment = '" + RebookAppointment + "' AND Patient = '" + Patient + "' AND  Reason_For_Rebooking_Appointment = '" + ReasonForRebookingAppointment + "'";

            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("Rebook_Appointment", RebookAppointment);
            cmd.Parameters.AddWithValue("Reason_For_Rebooking_Appointment", ReasonForRebookingAppointment);
            cmd.Parameters.AddWithValue("Patient", Patient);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            


            string dbquery = "Insert into Appointment (Rebook_Appointment, Patient, Reason_For_Rebooking_Appointment) values ('" + RebookAppointment+ "','" + Patient + "', '" + ReasonForRebookingAppointment+ "')";
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
                MessageBox.Show("Your booking Appointment has been confirmed!");
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

            txtRebookAppointment.Text = "";
            txtReasonForRebookingAppointment.Text = "";
            txtPatient.Text = "";

        }
    }
}
