namespace WinFormsApp1
{
    partial class Form8
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
            lblDateChange = new Label();
            lblReasonForDateChange = new Label();
            txtDateChange = new TextBox();
            txtReasonForDateChange = new TextBox();
            lblConfirm = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblDateChange
            // 
            lblDateChange.AutoSize = true;
            lblDateChange.Location = new Point(322, 91);
            lblDateChange.Name = "lblDateChange";
            lblDateChange.Size = new Size(95, 20);
            lblDateChange.TabIndex = 5;
            lblDateChange.Text = "Date Change";
            // 
            // lblReasonForDateChange
            // 
            lblReasonForDateChange.AutoSize = true;
            lblReasonForDateChange.Location = new Point(287, 255);
            lblReasonForDateChange.Name = "lblReasonForDateChange";
            lblReasonForDateChange.Size = new Size(172, 20);
            lblReasonForDateChange.TabIndex = 6;
            lblReasonForDateChange.Text = "Reason For Date Change";
            // 
            // txtDateChange
            // 
            txtDateChange.Location = new Point(255, 165);
            txtDateChange.Name = "txtDateChange";
            txtDateChange.Size = new Size(243, 27);
            txtDateChange.TabIndex = 10;
            // 
            // txtReasonForDateChange
            // 
            txtReasonForDateChange.Location = new Point(255, 335);
            txtReasonForDateChange.Name = "txtReasonForDateChange";
            txtReasonForDateChange.Size = new Size(243, 27);
            txtReasonForDateChange.TabIndex = 11;
            // 
            // lblConfirm
            // 
            lblConfirm.Location = new Point(322, 421);
            lblConfirm.Name = "lblConfirm";
            lblConfirm.Size = new Size(103, 29);
            lblConfirm.TabIndex = 12;
            lblConfirm.Text = "Confirm";
            lblConfirm.UseVisualStyleBackColor = true;
            lblConfirm.Click += lblConfirm_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans Unicode", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(287, 9);
            label1.Name = "label1";
            label1.Size = new Size(179, 18);
            label1.TabIndex = 13;
            label1.Text = "Modify Appointment";
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(800, 455);
            Controls.Add(label1);
            Controls.Add(lblConfirm);
            Controls.Add(txtReasonForDateChange);
            Controls.Add(txtDateChange);
            Controls.Add(lblReasonForDateChange);
            Controls.Add(lblDateChange);
            Name = "Form8";
            Text = "Form8";
           
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblDateChange;
        private Label lblReasonForDateChange;
        private TextBox txtDateChange;
        private TextBox txtReasonForDateChange;
        private Button lblConfirm;
        private Label label1;
    }
}