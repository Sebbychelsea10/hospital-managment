namespace WinFormsApp1
{
    partial class Form2
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
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            lblButton = new Button();
            label2 = new Label();
            txtUsername = new TextBox();
            lblEmail = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            lblConfirm = new Label();
            txtDateOfBirth = new TextBox();
            lblDateOfBirth = new Label();
            txtMobileNumber = new TextBox();
            lblMobileNumber = new Label();
            lblFirstName = new Label();
            lblLastName = new Label();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(316, 9);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 5;
            label1.Text = "Sign Up Form";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(221, 149);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(315, 27);
            txtEmail.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(221, 367);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(315, 27);
            txtPassword.TabIndex = 7;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(221, 426);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(315, 27);
            txtConfirmPassword.TabIndex = 8;
            // 
            // lblButton
            // 
            lblButton.Location = new Point(305, 470);
            lblButton.Name = "lblButton";
            lblButton.Size = new Size(94, 29);
            lblButton.TabIndex = 9;
            lblButton.Text = "Sign Up";
            lblButton.UseVisualStyleBackColor = true;
            lblButton.Click += lblButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 139);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 10;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(221, 201);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(315, 27);
            txtUsername.TabIndex = 11;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(113, 149);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 12;
            lblEmail.Text = "Email";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(97, 204);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(75, 20);
            lblUsername.TabIndex = 13;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(76, 374);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 14;
            lblPassword.Text = "Password";
            // 
            // lblConfirm
            // 
            lblConfirm.AutoSize = true;
            lblConfirm.Location = new Point(55, 426);
            lblConfirm.Name = "lblConfirm";
            lblConfirm.Size = new Size(127, 20);
            lblConfirm.TabIndex = 15;
            lblConfirm.Text = "Confirm Password";
            // 
            // txtDateOfBirth
            // 
            txtDateOfBirth.Location = new Point(221, 259);
            txtDateOfBirth.Name = "txtDateOfBirth";
            txtDateOfBirth.Size = new Size(315, 27);
            txtDateOfBirth.TabIndex = 16;
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Location = new Point(76, 262);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(96, 20);
            lblDateOfBirth.TabIndex = 17;
            lblDateOfBirth.Text = "Date Of Birth";
            // 
            // txtMobileNumber
            // 
            txtMobileNumber.Location = new Point(221, 318);
            txtMobileNumber.Name = "txtMobileNumber";
            txtMobileNumber.Size = new Size(315, 27);
            txtMobileNumber.TabIndex = 18;
            // 
            // lblMobileNumber
            // 
            lblMobileNumber.AutoSize = true;
            lblMobileNumber.Location = new Point(68, 325);
            lblMobileNumber.Name = "lblMobileNumber";
            lblMobileNumber.Size = new Size(114, 20);
            lblMobileNumber.TabIndex = 19;
            lblMobileNumber.Text = "Mobile Number";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(113, 49);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(80, 20);
            lblFirstName.TabIndex = 20;
            lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(113, 103);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(79, 20);
            lblLastName.TabIndex = 21;
            lblLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(221, 96);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(315, 27);
            txtLastName.TabIndex = 22;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(221, 42);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(315, 27);
            txtFirstName.TabIndex = 23;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightPink;
            ClientSize = new Size(757, 511);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(lblMobileNumber);
            Controls.Add(txtMobileNumber);
            Controls.Add(lblDateOfBirth);
            Controls.Add(txtDateOfBirth);
            Controls.Add(lblConfirm);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(lblEmail);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(lblButton);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private Button lblButton;
        private Label label2;
        private TextBox txtUsername;
        private Label lblEmail;
        private Label lblUsername;
        private Label lblPassword;
        private Label lblConfirm;
        private TextBox txtDateOfBirth;
        private Label lblDateOfBirth;
        private TextBox txtMobileNumber;
        private Label lblMobileNumber;
        private Label lblFirstName;
        private Label lblLastName;
        private TextBox txtLastName;
        private TextBox txtFirstName;
    }
}