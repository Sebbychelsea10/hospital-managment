namespace WinFormsApp1
{
    partial class Form13
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
            label1 = new Label();
            lblRebookAppointment = new Label();
            lblReasonForRebookingAppointment = new Label();
            txtRebookAppointment = new TextBox();
            txtReasonForRebookingAppointment = new TextBox();
            lblPatient = new Label();
            txtPatient = new TextBox();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Bright", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(290, 19);
            label1.Name = "label1";
            label1.Size = new Size(171, 17);
            label1.TabIndex = 0;
            label1.Text = "Rebook Appointment";
            // 
            // lblRebookAppointment
            // 
            lblRebookAppointment.AutoSize = true;
            lblRebookAppointment.Location = new Point(28, 191);
            lblRebookAppointment.Name = "lblRebookAppointment";
            lblRebookAppointment.Size = new Size(152, 20);
            lblRebookAppointment.TabIndex = 1;
            lblRebookAppointment.Text = "Rebook Appointment";
            // 
            // lblReasonForRebookingAppointment
            // 
            lblReasonForRebookingAppointment.AutoSize = true;
            lblReasonForRebookingAppointment.Location = new Point(12, 306);
            lblReasonForRebookingAppointment.Name = "lblReasonForRebookingAppointment";
            lblReasonForRebookingAppointment.Size = new Size(250, 20);
            lblReasonForRebookingAppointment.TabIndex = 2;
            lblReasonForRebookingAppointment.Text = "Reason For Rebooking Appointment";
            // 
            // txtRebookAppointment
            // 
            txtRebookAppointment.Location = new Point(324, 184);
            txtRebookAppointment.Name = "txtRebookAppointment";
            txtRebookAppointment.Size = new Size(270, 27);
            txtRebookAppointment.TabIndex = 3;
            // 
            // txtReasonForRebookingAppointment
            // 
            txtReasonForRebookingAppointment.Location = new Point(324, 299);
            txtReasonForRebookingAppointment.Name = "txtReasonForRebookingAppointment";
            txtReasonForRebookingAppointment.Size = new Size(270, 27);
            txtReasonForRebookingAppointment.TabIndex = 4;
            // 
            // lblPatient
            // 
            lblPatient.AutoSize = true;
            lblPatient.Location = new Point(55, 97);
            lblPatient.Name = "lblPatient";
            lblPatient.Size = new Size(54, 20);
            lblPatient.TabIndex = 5;
            lblPatient.Text = "Patient";
            // 
            // txtPatient
            // 
            txtPatient.Location = new Point(324, 90);
            txtPatient.Name = "txtPatient";
            txtPatient.Size = new Size(270, 27);
            txtPatient.TabIndex = 6;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(388, 409);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 7;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // Form13
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSubmit);
            Controls.Add(txtPatient);
            Controls.Add(lblPatient);
            Controls.Add(txtReasonForRebookingAppointment);
            Controls.Add(txtRebookAppointment);
            Controls.Add(lblReasonForRebookingAppointment);
            Controls.Add(lblRebookAppointment);
            Controls.Add(label1);
            Name = "Form13";
            Text = "Form13";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblRebookAppointment;
        private Label lblReasonForRebookingAppointment;
        private TextBox txtRebookAppointment;
        private TextBox txtReasonForRebookingAppointment;
        private Label lblPatient;
        private TextBox txtPatient;
        private Button btnSubmit;
    }
}