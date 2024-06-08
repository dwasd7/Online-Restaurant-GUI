namespace FinalProject24
{
    partial class JG_loginForm
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
            panel1 = new Panel();
            successOrNotLabel = new Label();
            signupLabel = new LinkLabel();
            label4 = new Label();
            signinButton = new Button();
            passwordTextBox = new TextBox();
            label3 = new Label();
            emailTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(successOrNotLabel);
            panel1.Controls.Add(signupLabel);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(signinButton);
            panel1.Controls.Add(passwordTextBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(emailTextBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(257, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(450, 430);
            panel1.TabIndex = 0;
            // 
            // successOrNotLabel
            // 
            successOrNotLabel.Location = new Point(102, 298);
            successOrNotLabel.Margin = new Padding(2, 0, 2, 0);
            successOrNotLabel.Name = "successOrNotLabel";
            successOrNotLabel.Size = new Size(261, 25);
            successOrNotLabel.TabIndex = 11;
            successOrNotLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // signupLabel
            // 
            signupLabel.AutoSize = true;
            signupLabel.Font = new Font("Segoe UI", 12F);
            signupLabel.Location = new Point(295, 372);
            signupLabel.Name = "signupLabel";
            signupLabel.Size = new Size(65, 21);
            signupLabel.TabIndex = 3;
            signupLabel.TabStop = true;
            signupLabel.Text = "Sign Up";
            signupLabel.LinkClicked += signupLabel_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(104, 372);
            label4.Name = "label4";
            label4.Size = new Size(171, 21);
            label4.TabIndex = 9;
            label4.Text = "Don't have an account?";
            // 
            // signinButton
            // 
            signinButton.BackColor = Color.Black;
            signinButton.FlatStyle = FlatStyle.Flat;
            signinButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signinButton.ForeColor = SystemColors.ButtonHighlight;
            signinButton.Location = new Point(101, 245);
            signinButton.Name = "signinButton";
            signinButton.Size = new Size(262, 33);
            signinButton.TabIndex = 2;
            signinButton.Text = "Sign In";
            signinButton.UseVisualStyleBackColor = false;
            signinButton.Click += signinButton_Click;
            signinButton.KeyPress += signinButton_KeyPress;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = SystemColors.ScrollBar;
            passwordTextBox.BorderStyle = BorderStyle.FixedSingle;
            passwordTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTextBox.ForeColor = Color.Gray;
            passwordTextBox.Location = new Point(102, 184);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(262, 29);
            passwordTextBox.TabIndex = 1;
            passwordTextBox.Text = "Enter your password";
            passwordTextBox.Enter += passwordTextBox_Enter;
            passwordTextBox.KeyPress += passwordTextBox_KeyPress;
            passwordTextBox.Leave += passwordTextBox_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(96, 160);
            label3.Name = "label3";
            label3.Size = new Size(83, 21);
            label3.TabIndex = 5;
            label3.Text = "Password:";
            // 
            // emailTextBox
            // 
            emailTextBox.BackColor = SystemColors.ScrollBar;
            emailTextBox.BorderStyle = BorderStyle.FixedSingle;
            emailTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailTextBox.ForeColor = Color.Gray;
            emailTextBox.Location = new Point(102, 111);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(262, 29);
            emailTextBox.TabIndex = 0;
            emailTextBox.Text = "Enter your email";
            emailTextBox.Enter += emailTextBox_Enter;
            emailTextBox.KeyPress += emailTextBox_KeyPress;
            emailTextBox.Leave += emailTextBox_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(96, 87);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 3;
            label2.Text = "Email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(119, 34);
            label1.Name = "label1";
            label1.Size = new Size(196, 37);
            label1.TabIndex = 1;
            label1.Text = "Welcome Back!";
            // 
            // JG_loginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(124, 172, 175);
            ClientSize = new Size(984, 561);
            Controls.Add(panel1);
            Name = "JG_loginForm";
            Text = "loginForm2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private LinkLabel signupLabel;
        private Label label4;
        private Button signinButton;
        private TextBox passwordTextBox;
        private Label label3;
        private TextBox emailTextBox;
        private Label label2;
        private Label label1;
        private Label successOrNotLabel;
    }
}