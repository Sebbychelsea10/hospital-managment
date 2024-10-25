using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void btnPerscribesPerscription_Click(object sender, EventArgs e)
        {
            Form10 form = new Form10();
            form.Show();
        }

        private void btnMedicalHistory_Click(object sender, EventArgs e)
        {
            Form11 form = new Form11();
            form.Show();
        }

        private void btnRebookAppointment_Click(object sender, EventArgs e)
        {
            Form13 form = new Form13();
            form.Show();
        }

        private void btnUploadResult_Click(object sender, EventArgs e)
        {
            Form12 form = new Form12();
            form.Show();
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            Form14 form = new Form14();
            form.Show();
        }
    }
}
