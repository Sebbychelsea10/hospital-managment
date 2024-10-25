namespace WinFormsApp1
{
    partial class Form5
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
            lblLogIn = new Label();
            lblUsernameId = new Label();
            lblPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lblLoginIn = new Button();
            SuspendLayout();
            // 
            // lblLogIn
            // 
            lblLogIn.AutoSize = true;
            lblLogIn.Location = new Point(309, 18);
            lblLogIn.Name = "lblLogIn";
            lblLogIn.Size = new Size(140, 20);
            lblLogIn.TabIndex = 6;
            lblLogIn.Text = "Doctor Log-In Form";
            // 
            // lblUsernameId
            // 
            lblUsernameId.AutoSize = true;
            lblUsernameId.Location = new Point(98, 129);
            lblUsernameId.Name = "lblUsernameId";
            lblUsernameId.Size = new Size(95, 20);
            lblUsernameId.TabIndex = 11;
            lblUsernameId.Text = "UserName Id";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(107, 267);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 12;
            lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(275, 126);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(315, 27);
            txtUsername.TabIndex = 13;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(275, 264);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(315, 27);
            txtPassword.TabIndex = 14;
            // 
            // lblLoginIn
            // 
            lblLoginIn.Location = new Point(355, 368);
            lblLoginIn.Name = "lblLoginIn";
            lblLoginIn.Size = new Size(94, 29);
            lblLoginIn.TabIndex = 15;
            lblLoginIn.Text = "Log In";
            lblLoginIn.UseVisualStyleBackColor = true;
            lblLoginIn.Click += lblLoginIn_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(800, 450);
            Controls.Add(lblLoginIn);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblUsernameId);
            Controls.Add(lblLogIn);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogIn;
        private Label lblUsernameId;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button lblLoginIn;
    }
}