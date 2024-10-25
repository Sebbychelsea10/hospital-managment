namespace WinFormsApp1
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblReasonForAppointment = new Label();
            lblDateOfAppointment = new Label();
            txtReasonForAppointment = new TextBox();
            txtDateOfAppointment = new TextBox();
            btnBook = new Button();
            label1 = new Label();
            txtPatientID = new TextBox();
            txtDoctorID = new TextBox();
            lBLDoctorID = new Label();
            lblPatientID = new Label();
            SuspendLayout();
            // 
            // lblReasonForAppointment
            // 
            lblReasonForAppointment.AutoSize = true;
            lblReasonForAppointment.Location = new Point(311, 324);
            lblReasonForAppointment.Name = "lblReasonForAppointment";
            lblReasonForAppointment.Size = new Size(174, 20);
            lblReasonForAppointment.TabIndex = 2;
            lblReasonForAppointment.Text = "Reason For Appointment";
            // 
            // lblDateOfAppointment
            // 
            lblDateOfAppointment.AutoSize = true;
            lblDateOfAppointment.Location = new Point(311, 243);
            lblDateOfAppointment.Name = "lblDateOfAppointment";
            lblDateOfAppointment.Size = new Size(153, 20);
            lblDateOfAppointment.TabIndex = 3;
            lblDateOfAppointment.Text = "Date Of Appointment";
            // 
            // txtReasonForAppointment
            // 
            txtReasonForAppointment.Location = new Point(274, 358);
            txtReasonForAppointment.Name = "txtReasonForAppointment";
            txtReasonForAppointment.Size = new Size(243, 27);
            txtReasonForAppointment.TabIndex = 6;
            // 
            // txtDateOfAppointment
            // 
            txtDateOfAppointment.Location = new Point(274, 279);
            txtDateOfAppointment.Name = "txtDateOfAppointment";
            txtDateOfAppointment.Size = new Size(243, 27);
            txtDateOfAppointment.TabIndex = 7;
            // 
            // btnBook
            // 
            btnBook.Location = new Point(353, 417);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(72, 30);
            btnBook.TabIndex = 8;
            btnBook.Text = "Book";
            btnBook.UseVisualStyleBackColor = true;
            btnBook.Click += btnConfirm_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Bright", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(317, 9);
            label1.Name = "label1";
            label1.Size = new Size(151, 17);
            label1.TabIndex = 9;
            label1.Text = "Book Appointment";
            // 
            // txtPatientID
            // 
            txtPatientID.Location = new Point(274, 186);
            txtPatientID.Name = "txtPatientID";
            txtPatientID.Size = new Size(243, 27);
            txtPatientID.TabIndex = 10;
            // 
            // txtDoctorID
            // 
            txtDoctorID.Location = new Point(274, 81);
            txtDoctorID.Name = "txtDoctorID";
            txtDoctorID.Size = new Size(243, 27);
            txtDoctorID.TabIndex = 11;
            // 
            // lBLDoctorID
            // 
            lBLDoctorID.AutoSize = true;
            lBLDoctorID.Location = new Point(348, 47);
            lBLDoctorID.Name = "lBLDoctorID";
            lBLDoctorID.Size = new Size(74, 20);
            lBLDoctorID.TabIndex = 12;
            lBLDoctorID.Text = "Doctor ID";
            // 
            // lblPatientID
            // 
            lblPatientID.AutoSize = true;
            lblPatientID.Location = new Point(348, 149);
            lblPatientID.Name = "lblPatientID";
            lblPatientID.Size = new Size(73, 20);
            lblPatientID.TabIndex = 13;
            lblPatientID.Text = "Patient ID";
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPatientID);
            Controls.Add(lBLDoctorID);
            Controls.Add(txtDoctorID);
            Controls.Add(txtPatientID);
            Controls.Add(label1);
            Controls.Add(btnBook);
            Controls.Add(txtDateOfAppointment);
            Controls.Add(txtReasonForAppointment);
            Controls.Add(lblDateOfAppointment);
            Controls.Add(lblReasonForAppointment);
            Name = "Form6";
            Text = "#";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblDateOfBirth;
        private Label lblReasonForAppointment;
        private Label lblDateOfAppointment;
        private TextBox txtName;
        private TextBox txtDateOfBirth;
        private TextBox txtReasonForAppointment;
        private TextBox txtDateOfAppointment;
        private Button btnBook;
        private Label label1;
        private TextBox txtPatientID;
        private TextBox txtDoctorID;
        private Label lBLDoctorID;
        private Label lblPatientID;
    }
}