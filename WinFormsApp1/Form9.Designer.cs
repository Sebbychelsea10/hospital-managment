namespace WinFormsApp1
{
    partial class Form9
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
            btnPerscribesPerscription = new Button();
            btnUploadResult = new Button();
            btnMedicalHistory = new Button();
            btnRebookAppointment = new Button();
            btnAppointments = new Button();
            SuspendLayout();
            // 
            // btnPerscribesPerscription
            // 
            btnPerscribesPerscription.Location = new Point(278, 43);
            btnPerscribesPerscription.Name = "btnPerscribesPerscription";
            btnPerscribesPerscription.Size = new Size(239, 30);
            btnPerscribesPerscription.TabIndex = 0;
            btnPerscribesPerscription.Text = "Prescribes Prescription";
            btnPerscribesPerscription.UseVisualStyleBackColor = true;
            btnPerscribesPerscription.Click += btnPerscribesPerscription_Click;
            // 
            // btnUploadResult
            // 
            btnUploadResult.Location = new Point(278, 138);
            btnUploadResult.Name = "btnUploadResult";
            btnUploadResult.Size = new Size(239, 30);
            btnUploadResult.TabIndex = 1;
            btnUploadResult.Text = "Upload Test Result";
            btnUploadResult.UseVisualStyleBackColor = true;
            btnUploadResult.Click += btnUploadResult_Click;
            // 
            // btnMedicalHistory
            // 
            btnMedicalHistory.Location = new Point(278, 228);
            btnMedicalHistory.Name = "btnMedicalHistory";
            btnMedicalHistory.Size = new Size(239, 30);
            btnMedicalHistory.TabIndex = 2;
            btnMedicalHistory.Text = "Patient Medical History";
            btnMedicalHistory.UseVisualStyleBackColor = true;
            btnMedicalHistory.Click += btnMedicalHistory_Click;
            // 
            // btnRebookAppointment
            // 
            btnRebookAppointment.Location = new Point(278, 315);
            btnRebookAppointment.Name = "btnRebookAppointment";
            btnRebookAppointment.Size = new Size(239, 30);
            btnRebookAppointment.TabIndex = 3;
            btnRebookAppointment.Text = "Rebook Appoinment";
            btnRebookAppointment.UseVisualStyleBackColor = true;
            btnRebookAppointment.Click += btnRebookAppointment_Click;
            // 
            // btnAppointments
            // 
            btnAppointments.Location = new Point(278, 398);
            btnAppointments.Name = "btnAppointments";
            btnAppointments.Size = new Size(239, 30);
            btnAppointments.TabIndex = 4;
            btnAppointments.Text = "Appointments Schedule";
            btnAppointments.UseVisualStyleBackColor = true;
            btnAppointments.Click += btnAppointments_Click;
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAppointments);
            Controls.Add(btnRebookAppointment);
            Controls.Add(btnMedicalHistory);
            Controls.Add(btnUploadResult);
            Controls.Add(btnPerscribesPerscription);
            Name = "Form9";
            Text = "Form9";
            ResumeLayout(false);
        }

        #endregion

        private Button btnPerscribesPerscription;
        private Button btnUploadResult;
        private Button btnMedicalHistory;
        private Button btnRebookAppointment;
        private Button btnAppointments;
    }
}