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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            string ReasonForAppointment = txtReasonForAppointment.Text;
            string DateOfAppointment = txtDateOfAppointment.Text;
            string DoctorID = txtDoctorID.Text;
            string PatientID = txtPatientID.Text;

            // Connection object
            SQLiteConnection conn = new SQLiteConnection(@"data source = C:\Users\sebas\Documents\hospital managment\hospitaldb.db");
            conn.Open();

            // Connecto to an object
            string query = "SELECT * FROM Appointment WHERE Patient_id = '" + PatientID + "' AND Doctor_id = '" + DoctorID + "' AND Date_Of_Appointment = '" + DateOfAppointment + "' AND Reason_For_Appointment = '" + ReasonForAppointment + "'";

            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("Patient_id", PatientID);
            cmd.Parameters.AddWithValue("Doctor_id", DoctorID);
            cmd.Parameters.AddWithValue("Date_Of_Appointment", DateOfAppointment);
            cmd.Parameters.AddWithValue("Reason_For_Appointment", ReasonForAppointment);
           
           
            
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);






            string dbquery = "Insert into Appointment (Patient_id, Doctor_id, Date_Of_Appointment, Reason_For_Appointment) values ('" + PatientID + "', '" + DoctorID + "','" + DateOfAppointment + "','" + ReasonForAppointment + "')";
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

            txtPatientID.Text = "";
            txtDoctorID.Text = "";
            txtDateOfAppointment.Text = "";
            txtReasonForAppointment.Text = "";
          
         

        }
    }
}
