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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void btnUploadTestResult_Click(object sender, EventArgs e)
        {
            string Patient_ID = txtPatientID.Text;
            string Result = txtResult.Text;
            string AppointmentRequired = txtAppointmentRequired.Text;
            string NoActionRequired = txtNoActionRequired.Text;


            // Connection object
            SQLiteConnection conn = new SQLiteConnection(@"data source = C:\Users\sebas\Documents\hospital managment\hospitaldb.db");
            conn.Open();

            // Connecto to an object
            string query = "SELECT * FROM Test_Result WHERE Patient_ID = '" + Patient_ID + "' AND Result = '" + Result + "' AND Appointment_Required = '" + AppointmentRequired + "' AND No_Action_Required = '" + NoActionRequired + "'";

            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("Patient_ID", Patient_ID);
            cmd.Parameters.AddWithValue("Result", Result);
            cmd.Parameters.AddWithValue("Appointment_Required", AppointmentRequired);
            cmd.Parameters.AddWithValue("No_Action_Required", NoActionRequired);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);




            string dbquery = "Insert into Test_Result (Patient_ID, Result, Appointment_Required, No_Action_Required) values ('" + Patient_ID + "','" + Result + "','" + AppointmentRequired + "', '" + NoActionRequired + "')";
            AmendDatabase(dbquery);
            loadData();

            conn.Close();
        }




        private void loadData()
        {
            SQLiteConnection conn = new SQLiteConnection(@"data source = C:\Users\sebas\Documents\hospital managment\hospitaldb.db");
            conn.Open();

            string query = "Select * from Test_Result ";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Test result have been sent!");
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

            txtPatientID.Text = "";
            txtResult.Text = "";
            txtNoActionRequired.Text = "";
            txtAppointmentRequired.Text = "";

        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }
    }
}

