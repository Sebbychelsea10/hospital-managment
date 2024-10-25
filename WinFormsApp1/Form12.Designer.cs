namespace WinFormsApp1
{
    partial class Form12
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
            btnUploadTestResult = new Button();
            lblResult = new Label();
            lblAppointment_Required = new Label();
            lblNoActionRequired = new Label();
            txtResult = new TextBox();
            txtAppointmentRequired = new TextBox();
            txtNoActionRequired = new TextBox();
            txtPatientID = new TextBox();
            lblPatientID = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Bright", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(319, 9);
            label1.Name = "label1";
            label1.Size = new Size(96, 17);
            label1.TabIndex = 0;
            label1.Text = "Test Result";
            // 
            // btnUploadTestResult
            // 
            btnUploadTestResult.Location = new Point(285, 409);
            btnUploadTestResult.Name = "btnUploadTestResult";
            btnUploadTestResult.Size = new Size(196, 29);
            btnUploadTestResult.TabIndex = 1;
            btnUploadTestResult.Text = "Upload Test Result";
            btnUploadTestResult.UseVisualStyleBackColor = true;
            btnUploadTestResult.Click += btnUploadTestResult_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(97, 147);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(49, 20);
            lblResult.TabIndex = 2;
            lblResult.Text = "Result";
            // 
            // lblAppointment_Required
            // 
            lblAppointment_Required.AutoSize = true;
            lblAppointment_Required.Location = new Point(59, 217);
            lblAppointment_Required.Name = "lblAppointment_Required";
            lblAppointment_Required.Size = new Size(161, 20);
            lblAppointment_Required.TabIndex = 3;
            lblAppointment_Required.Text = "Appointment Required";
            // 
            // lblNoActionRequired
            // 
            lblNoActionRequired.AutoSize = true;
            lblNoActionRequired.Location = new Point(69, 318);
            lblNoActionRequired.Name = "lblNoActionRequired";
            lblNoActionRequired.Size = new Size(140, 20);
            lblNoActionRequired.TabIndex = 4;
            lblNoActionRequired.Text = "No Action Required";
            // 
            // txtResult
            // 
            txtResult.Location = new Point(268, 140);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(288, 27);
            txtResult.TabIndex = 5;
            // 
            // txtAppointmentRequired
            // 
            txtAppointmentRequired.Location = new Point(268, 214);
            txtAppointmentRequired.Name = "txtAppointmentRequired";
            txtAppointmentRequired.Size = new Size(288, 27);
            txtAppointmentRequired.TabIndex = 6;
            // 
            // txtNoActionRequired
            // 
            txtNoActionRequired.Location = new Point(268, 311);
            txtNoActionRequired.Name = "txtNoActionRequired";
            txtNoActionRequired.Size = new Size(288, 27);
            txtNoActionRequired.TabIndex = 7;
            // 
            // txtPatientID
            // 
            txtPatientID.Location = new Point(268, 57);
            txtPatientID.Name = "txtPatientID";
            txtPatientID.Size = new Size(288, 27);
            txtPatientID.TabIndex = 8;
            // 
            // lblPatientID
            // 
            lblPatientID.AutoSize = true;
            lblPatientID.Location = new Point(100, 60);
            lblPatientID.Name = "lblPatientID";
            lblPatientID.Size = new Size(75, 20);
            lblPatientID.TabIndex = 9;
            lblPatientID.Text = "Patient_ID";
            // 
            // Form12
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPatientID);
            Controls.Add(txtPatientID);
            Controls.Add(txtNoActionRequired);
            Controls.Add(txtAppointmentRequired);
            Controls.Add(txtResult);
            Controls.Add(lblNoActionRequired);
            Controls.Add(lblAppointment_Required);
            Controls.Add(lblResult);
            Controls.Add(btnUploadTestResult);
            Controls.Add(label1);
            Name = "Form12";
            Text = "Form12";
            Load += Form12_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnUploadTestResult;
        private Label lblResult;
        private Label lblAppointment_Required;
        private Label lblNoActionRequired;
        private TextBox txtResult;
        private TextBox txtAppointmentRequired;
        private TextBox txtNoActionRequired;
        private TextBox txtPatientID;
        private Label lblPatientID;
    }
}