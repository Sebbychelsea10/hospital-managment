﻿namespace WinFormsApp1
{
    partial class Form16
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
            dgvPatientTestResult = new DataGridView();
            label1 = new Label();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPatientTestResult).BeginInit();
            SuspendLayout();
            // 
            // dgvPatientTestResult
            // 
            dgvPatientTestResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPatientTestResult.Location = new Point(149, 135);
            dgvPatientTestResult.Name = "dgvPatientTestResult";
            dgvPatientTestResult.RowHeadersWidth = 51;
            dgvPatientTestResult.RowTemplate.Height = 29;
            dgvPatientTestResult.Size = new Size(520, 96);
            dgvPatientTestResult.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Bright", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(262, 18);
            label1.Name = "label1";
            label1.Size = new Size(229, 26);
            label1.TabIndex = 1;
            label1.Text = "Patient Test Result";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(362, 409);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 2;
            btnBack.Text = "back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // Form16
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(label1);
            Controls.Add(dgvPatientTestResult);
            Name = "Form16";
            Text = "Form16";
            Load += Form16_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPatientTestResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPatientTestResult;
        private Label label1;
        private Button btnBack;
    }
}