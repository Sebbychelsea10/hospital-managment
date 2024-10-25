namespace WinFormsApp1
{
    partial class Form15
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
            lblTitle = new Label();
            btnUpdate = new Button();
            btnDelete = new Button();
            lblPatientID = new Label();
            lblPatientFirstName = new Label();
            txtFirstName = new TextBox();
            txtID = new TextBox();
            dgvPatients = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPatients).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(236, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(206, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Patient Details";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(630, 240);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 39);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(630, 314);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 38);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblPatientID
            // 
            lblPatientID.AutoSize = true;
            lblPatientID.Location = new Point(62, 286);
            lblPatientID.Name = "lblPatientID";
            lblPatientID.Size = new Size(71, 20);
            lblPatientID.TabIndex = 3;
            lblPatientID.Text = "Patient id";
            // 
            // lblPatientFirstName
            // 
            lblPatientFirstName.AutoSize = true;
            lblPatientFirstName.Location = new Point(62, 353);
            lblPatientFirstName.Name = "lblPatientFirstName";
            lblPatientFirstName.Size = new Size(129, 20);
            lblPatientFirstName.TabIndex = 4;
            lblPatientFirstName.Text = "Patient First Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(245, 350);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(245, 27);
            txtFirstName.TabIndex = 5;
            // 
            // txtID
            // 
            txtID.Location = new Point(245, 268);
            txtID.Name = "txtID";
            txtID.Size = new Size(245, 27);
            txtID.TabIndex = 6;
            // 
            // dgvPatients
            // 
            dgvPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPatients.Location = new Point(62, 69);
            dgvPatients.Name = "dgvPatients";
            dgvPatients.RowHeadersWidth = 51;
            dgvPatients.RowTemplate.Height = 29;
            dgvPatients.Size = new Size(517, 172);
            dgvPatients.TabIndex = 7;
            dgvPatients.CellClick += dgvPatients_CellClick;
            // 
            // button1
            // 
            button1.Location = new Point(678, 10);
            button1.Name = "button1";
            button1.Size = new Size(97, 26);
            button1.TabIndex = 8;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form15
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(dgvPatients);
            Controls.Add(txtID);
            Controls.Add(txtFirstName);
            Controls.Add(lblPatientFirstName);
            Controls.Add(lblPatientID);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(lblTitle);
            Name = "Form15";
            Text = "Patient Details";
            Load += Form15_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPatients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Button btnUpdate;
        private Button btnDelete;
        private Label lblPatientID;
        private Label lblPatientFirstName;
        private TextBox txtFirstName;
        private TextBox txtID;
        private DataGridView dgvPatients;
        private Button button1;
    }
}