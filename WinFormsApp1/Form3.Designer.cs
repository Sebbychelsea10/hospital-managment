namespace WinFormsApp1
{
    partial class Form3
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
            label2 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lblButton = new Button();
            lblUsername = new Label();
            lblPassword = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(327, 9);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 5;
            label2.Text = "Sign In Form";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(224, 114);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(315, 27);
            txtUsername.TabIndex = 6;
            txtUsername.TextChanged += textBox3_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(224, 232);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(315, 27);
            txtPassword.TabIndex = 7;
            // 
            // lblButton
            // 
            lblButton.Location = new Point(327, 392);
            lblButton.Name = "lblButton";
            lblButton.Size = new Size(94, 29);
            lblButton.TabIndex = 9;
            lblButton.Text = "Sign In";
            lblButton.UseVisualStyleBackColor = true;
            lblButton.Click += lblButton_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(97, 121);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(75, 20);
            lblUsername.TabIndex = 10;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(97, 239);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 11;
            lblPassword.Text = "Password";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightPink;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(lblButton);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Name = "Form3";
            Text = "Patient Sign In";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button lblButton;
        private Label lblUsername;
        private Label lblPassword;
    }
}