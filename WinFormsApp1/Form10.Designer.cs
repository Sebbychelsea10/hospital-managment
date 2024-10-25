namespace WinFormsApp1
{
    partial class Form10
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


        private void InitializeComponent()
        {
            lblName = new Label();
            txtName = new TextBox();
            lblMedication = new Label();
            txtMedication = new TextBox();
            txtDosage = new TextBox();
            lblDosage = new Label();
            btnSubmit = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(114, 83);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(289, 83);
            txtName.Name = "txtName";
            txtName.Size = new Size(250, 27);
            txtName.TabIndex = 1;
            // 
            // lblMedication
            // 
            lblMedication.AutoSize = true;
            lblMedication.Location = new Point(114, 201);
            lblMedication.Name = "lblMedication";
            lblMedication.Size = new Size(84, 20);
            lblMedication.TabIndex = 2;
            lblMedication.Text = "Medication";
            // 
            // txtMedication
            // 
            txtMedication.Location = new Point(289, 201);
            txtMedication.Name = "txtMedication";
            txtMedication.Size = new Size(250, 27);
            txtMedication.TabIndex = 3;
            // 
            // txtDosage
            // 
            txtDosage.Location = new Point(289, 343);
            txtDosage.Name = "txtDosage";
            txtDosage.Size = new Size(250, 27);
            txtDosage.TabIndex = 4;
            // 
            // lblDosage
            // 
            lblDosage.AutoSize = true;
            lblDosage.Location = new Point(114, 346);
            lblDosage.Name = "lblDosage";
            lblDosage.Size = new Size(60, 20);
            lblDosage.TabIndex = 5;
            lblDosage.Text = "Dosage";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(356, 409);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 6;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Bright", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(315, 9);
            label4.Name = "label4";
            label4.Size = new Size(188, 17);
            label4.TabIndex = 7;
            label4.Text = "Prescribe prescriptions";
            // 
            // Form10
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(btnSubmit);
            Controls.Add(lblDosage);
            Controls.Add(txtDosage);
            Controls.Add(txtMedication);
            Controls.Add(lblMedication);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Name = "Form10";
            Text = "Form10";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox txtName;
        private Label lblMedication;
        private TextBox txtMedication;
        private TextBox txtDosage;
        private Label lblDosage;
        private Button btnSubmit;
        private Label label4;
    }
}