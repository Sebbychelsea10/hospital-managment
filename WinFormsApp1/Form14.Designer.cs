namespace WinFormsApp1
{
    partial class Form14
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
            dgvAppointments = new DataGridView();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Bright", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(197, 9);
            label1.Name = "label1";
            label1.Size = new Size(317, 32);
            label1.TabIndex = 0;
            label1.Text = "Apointments Schedule";
            // 
            // dgvAppointments
            // 
            dgvAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAppointments.Location = new Point(66, 88);
            dgvAppointments.Name = "dgvAppointments";
            dgvAppointments.RowHeadersWidth = 51;
            dgvAppointments.RowTemplate.Height = 29;
            dgvAppointments.Size = new Size(627, 262);
            dgvAppointments.TabIndex = 1;
            dgvAppointments.CellContentClick += dgvAppointments_CellContentClick;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(358, 409);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // Form14
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(dgvAppointments);
            Controls.Add(label1);
            Name = "Form14";
            Text = "Form14";
            Load += Form14_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvAppointments;
        private Button btnBack;
    }
}