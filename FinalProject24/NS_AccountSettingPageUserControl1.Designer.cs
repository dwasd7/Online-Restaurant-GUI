namespace FinalProject24
{
    partial class NS_AccountSettingPageUserControl1
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

        //#region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            settingsPanel = new Panel();
            NametextBox = new TextBox();
            EmailtextBox = new TextBox();
            PhonetextBox = new TextBox();
            editSettingPanel = new Panel();
            textBox2 = new TextBox();
            label5 = new Label();
            button1 = new Button();
            textBox3 = new TextBox();
            label6 = new Label();
            textBox4 = new TextBox();
            label7 = new Label();
            textBox5 = new TextBox();
            label8 = new Label();
            settingsPanel.SuspendLayout();
            editSettingPanel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(58, 34);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(139, 21);
            label1.TabIndex = 4;
            label1.Text = "Account Settings";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(58, 71);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 5;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(58, 134);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 6;
            label3.Text = "Email Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(58, 191);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(103, 19);
            label4.TabIndex = 7;
            label4.Text = "Phone Number";
            // 
            // settingsPanel
            // 
            settingsPanel.Controls.Add(NametextBox);
            settingsPanel.Controls.Add(EmailtextBox);
            settingsPanel.Controls.Add(label1);
            settingsPanel.Controls.Add(PhonetextBox);
            settingsPanel.Controls.Add(label4);
            settingsPanel.Controls.Add(label3);
            settingsPanel.Controls.Add(label2);
            settingsPanel.Location = new Point(56, 35);
            settingsPanel.Margin = new Padding(1);
            settingsPanel.Name = "settingsPanel";
            settingsPanel.Size = new Size(323, 439);
            settingsPanel.TabIndex = 10;
            // 
            // NametextBox
            // 
            NametextBox.ForeColor = SystemColors.WindowText;
            NametextBox.Location = new Point(58, 88);
            NametextBox.Margin = new Padding(2);
            NametextBox.Multiline = true;
            NametextBox.Name = "NametextBox";
            NametextBox.ReadOnly = true;
            NametextBox.Size = new Size(201, 30);
            NametextBox.TabIndex = 10;
            NametextBox.Text = "FirstName LastName";
            // 
            // EmailtextBox
            // 
            EmailtextBox.Location = new Point(58, 151);
            EmailtextBox.Margin = new Padding(2);
            EmailtextBox.Multiline = true;
            EmailtextBox.Name = "EmailtextBox";
            EmailtextBox.ReadOnly = true;
            EmailtextBox.Size = new Size(201, 28);
            EmailtextBox.TabIndex = 11;
            EmailtextBox.Text = "Email@email.com";
            // 
            // PhonetextBox
            // 
            PhonetextBox.Location = new Point(58, 211);
            PhonetextBox.Margin = new Padding(2);
            PhonetextBox.Multiline = true;
            PhonetextBox.Name = "PhonetextBox";
            PhonetextBox.ReadOnly = true;
            PhonetextBox.Size = new Size(201, 30);
            PhonetextBox.TabIndex = 12;
            PhonetextBox.Text = "1234567890";
            // 
            // editSettingPanel
            // 
            editSettingPanel.Controls.Add(textBox2);
            editSettingPanel.Controls.Add(label5);
            editSettingPanel.Controls.Add(button1);
            editSettingPanel.Controls.Add(textBox3);
            editSettingPanel.Controls.Add(label6);
            editSettingPanel.Controls.Add(textBox4);
            editSettingPanel.Controls.Add(label7);
            editSettingPanel.Controls.Add(textBox5);
            editSettingPanel.Controls.Add(label8);
            editSettingPanel.Location = new Point(456, 35);
            editSettingPanel.Margin = new Padding(1);
            editSettingPanel.Name = "editSettingPanel";
            editSettingPanel.Size = new Size(323, 439);
            editSettingPanel.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Control;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(39, 297);
            textBox2.Margin = new Padding(2);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(237, 56);
            textBox2.TabIndex = 9;
            textBox2.Text = "To modify your personal information: click on any of the corresponding textboxes, edit, and click apply changes.";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(58, 34);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(173, 21);
            label5.TabIndex = 4;
            label5.Text = "Edit Account Settings";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(85, 259);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(130, 31);
            button1.TabIndex = 8;
            button1.Text = "Apply Changes";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Applybutton_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(58, 88);
            textBox3.Margin = new Padding(2);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(201, 30);
            textBox3.TabIndex = 1;
            textBox3.Text = "FirstName LastName";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(58, 191);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(103, 19);
            label6.TabIndex = 7;
            label6.Text = "Phone Number";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(58, 151);
            textBox4.Margin = new Padding(2);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(201, 28);
            textBox4.TabIndex = 2;
            textBox4.Text = "Email@email.com";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(58, 134);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(81, 15);
            label7.TabIndex = 6;
            label7.Text = "Email Address";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(58, 211);
            textBox5.Margin = new Padding(2);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(201, 30);
            textBox5.TabIndex = 3;
            textBox5.Text = "1234567890";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(58, 71);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 5;
            label8.Text = "Name";
            // 
            // NS_AccountSettingPageUserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(editSettingPanel);
            Controls.Add(settingsPanel);
            Name = "NS_AccountSettingPageUserControl1";
            Size = new Size(882, 494);
            settingsPanel.ResumeLayout(false);
            settingsPanel.PerformLayout();
            editSettingPanel.ResumeLayout(false);
            editSettingPanel.PerformLayout();
            ResumeLayout(false);
        }

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel settingsPanel;
        private Panel editSettingPanel;
        private TextBox textBox2;
        private Label label5;
        private Button button1;
        private TextBox textBox3;
        private Label label6;
        private TextBox textBox4;
        private Label label7;
        private TextBox textBox5;
        private Label label8;
        private TextBox NametextBox;
        private TextBox EmailtextBox;
        private TextBox PhonetextBox;
    }
}
