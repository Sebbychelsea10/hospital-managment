namespace WinFormsApp1
{
    partial class Form7
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
            lblCancelationDate = new Label();
            txtCancelationDate = new TextBox();
            lblReasonForCancelation = new Label();
            txtReasonForCancelation = new TextBox();
            btnConfirm = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblCancelationDate
            // 
            lblCancelationDate.AutoSize = true;
            lblCancelationDate.Location = new Point(315, 106);
            lblCancelationDate.Name = "lblCancelationDate";
            lblCancelationDate.Size = new Size(123, 20);
            lblCancelationDate.TabIndex = 8;
            lblCancelationDate.Text = "Cancelation Date";
            // 
            // txtCancelationDate
            // 
            txtCancelationDate.Location = new Point(255, 168);
            txtCancelationDate.Name = "txtCancelationDate";
            txtCancelationDate.Size = new Size(243, 27);
            txtCancelationDate.TabIndex = 9;
            // 
            // lblReasonForCancelation
            // 
            lblReasonForCancelation.AutoSize = true;
            lblReasonForCancelation.Location = new Point(295, 258);
            lblReasonForCancelation.Name = "lblReasonForCancelation";
            lblReasonForCancelation.Size = new Size(164, 20);
            lblReasonForCancelation.TabIndex = 10;
            lblReasonForCancelation.Text = "Reason For Cancelation";
            // 
            // txtReasonForCancelation
            // 
            txtReasonForCancelation.Location = new Point(255, 332);
            txtReasonForCancelation.Name = "txtReasonForCancelation";
            txtReasonForCancelation.Size = new Size(243, 27);
            txtReasonForCancelation.TabIndex = 11;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(315, 421);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(94, 29);
            btnConfirm.TabIndex = 12;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Bright", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(314, 9);
            label1.Name = "label1";
            label1.Size = new Size(138, 18);
            label1.TabIndex = 13;
            label1.Text = "Cancelation Page";
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnConfirm);
            Controls.Add(txtReasonForCancelation);
            Controls.Add(lblReasonForCancelation);
            Controls.Add(txtCancelationDate);
            Controls.Add(lblCancelationDate);
            Name = "Form7";
            Text = "Form7";
           
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblCancelationDate;
        private TextBox txtCancelationDate;
        private Label lblReasonForCancelation;
        private TextBox txtReasonForCancelation;
        private Button btnConfirm;
        private Label label1;
    }
}