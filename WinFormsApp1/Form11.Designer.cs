﻿namespace WinFormsApp1
{
    partial class Form11
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
            dgvPatientMedicalHistory = new DataGridView();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPatientMedicalHistory).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(242, 9);
            label1.Name = "label1";
            label1.Size = new Size(243, 23);
            label1.TabIndex = 5;
            label1.Text = "Patient Medical History";
            // 
            // dgvPatientMedicalHistory
            // 
            dgvPatientMedicalHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPatientMedicalHistory.Location = new Point(127, 122);
            dgvPatientMedicalHistory.Name = "dgvPatientMedicalHistory";
            dgvPatientMedicalHistory.RowHeadersWidth = 51;
            dgvPatientMedicalHistory.RowTemplate.Height = 29;
            dgvPatientMedicalHistory.Size = new Size(533, 213);
            dgvPatientMedicalHistory.TabIndex = 6;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(340, 397);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 7;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // Form11
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(dgvPatientMedicalHistory);
            Controls.Add(label1);
            Name = "Form11";
            Text = "Form11";
            Load += Form11_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPatientMedicalHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DataGridView dgvPatientMedicalHistory;
        private Button btnBack;
    }
}