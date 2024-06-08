namespace FinalProject24
{
    partial class PaymentUserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            paymentDetailPanel = new Panel();
            enterEditLabel = new Label();
            cancelLabel = new Label();
            editLabel = new Label();
            applyChangeButton = new Button();
            loadItemCardPanel = new Panel();
            totalPanel = new Panel();
            totalDuePirceLabel = new Label();
            taxPriceLabel = new Label();
            label6 = new Label();
            label5 = new Label();
            subtotalPriceLabel = new Label();
            subTotalLabel = new Label();
            paymentDetailPanel.SuspendLayout();
            totalPanel.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ScrollBar;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 10F);
            textBox1.ForeColor = SystemColors.GrayText;
            textBox1.Location = new Point(47, 190);
            textBox1.Margin = new Padding(6);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(485, 57);
            textBox1.TabIndex = 5;
            textBox1.Text = "Address, City, State";
            textBox1.Enter += textBox1_Enter;
            textBox1.Leave += textBox1_Leave;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ScrollBar;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 10F);
            textBox2.ForeColor = SystemColors.GrayText;
            textBox2.Location = new Point(47, 319);
            textBox2.Margin = new Padding(6);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(352, 57);
            textBox2.TabIndex = 6;
            textBox2.Text = "XXXX-XXXX-XXXX-XXXX";
            textBox2.Enter += textBox2_Enter;
            textBox2.Leave += textBox2_Leave;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ScrollBar;
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Segoe UI", 10F);
            textBox3.ForeColor = SystemColors.GrayText;
            textBox3.Location = new Point(47, 471);
            textBox3.Margin = new Padding(6);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(648, 64);
            textBox3.TabIndex = 7;
            textBox3.Text = "Full Name";
            textBox3.Enter += textBox3_Enter;
            textBox3.Leave += textBox3_Leave;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.ScrollBar;
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Font = new Font("Segoe UI", 10F);
            textBox4.ForeColor = SystemColors.GrayText;
            textBox4.Location = new Point(411, 319);
            textBox4.Margin = new Padding(6);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(121, 57);
            textBox4.TabIndex = 8;
            textBox4.Text = "CV";
            textBox4.Enter += textBox4_Enter;
            textBox4.Leave += textBox4_Leave;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.ScrollBar;
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Font = new Font("Segoe UI", 10F);
            textBox5.ForeColor = SystemColors.GrayText;
            textBox5.Location = new Point(554, 319);
            textBox5.Margin = new Padding(6);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(141, 57);
            textBox5.TabIndex = 9;
            textBox5.Text = "MM/YY";
            textBox5.Enter += textBox5_Enter;
            textBox5.Leave += textBox5_Leave;
            // 
            // textBox6
            // 
            textBox6.BackColor = SystemColors.ScrollBar;
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.Font = new Font("Segoe UI", 10F);
            textBox6.ForeColor = SystemColors.GrayText;
            textBox6.Location = new Point(554, 190);
            textBox6.Margin = new Padding(6);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(141, 57);
            textBox6.TabIndex = 10;
            textBox6.Text = "Zip Code";
            textBox6.Enter += textBox6_Enter;
            textBox6.Leave += textBox6_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.WindowText;
            label1.Location = new Point(36, 37);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(261, 45);
            label1.TabIndex = 11;
            label1.Text = "Payment Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.WindowText;
            label2.Location = new Point(36, 152);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(191, 37);
            label2.TabIndex = 12;
            label2.Text = "Main Address:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold);
            label3.ForeColor = SystemColors.WindowText;
            label3.Location = new Point(36, 276);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(190, 37);
            label3.TabIndex = 13;
            label3.Text = "Card Number:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold);
            label4.ForeColor = SystemColors.WindowText;
            label4.Location = new Point(45, 415);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(251, 37);
            label4.TabIndex = 14;
            label4.Text = "Card Holder Name:";
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(1041, 866);
            button1.Margin = new Padding(6);
            button1.Name = "button1";
            button1.Size = new Size(347, 87);
            button1.TabIndex = 15;
            button1.Text = "Pay: $00.00";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // paymentDetailPanel
            // 
            paymentDetailPanel.BorderStyle = BorderStyle.FixedSingle;
            paymentDetailPanel.Controls.Add(enterEditLabel);
            paymentDetailPanel.Controls.Add(cancelLabel);
            paymentDetailPanel.Controls.Add(editLabel);
            paymentDetailPanel.Controls.Add(applyChangeButton);
            paymentDetailPanel.Controls.Add(textBox3);
            paymentDetailPanel.Controls.Add(textBox1);
            paymentDetailPanel.Controls.Add(label4);
            paymentDetailPanel.Controls.Add(textBox2);
            paymentDetailPanel.Controls.Add(label3);
            paymentDetailPanel.Controls.Add(textBox4);
            paymentDetailPanel.Controls.Add(label2);
            paymentDetailPanel.Controls.Add(textBox5);
            paymentDetailPanel.Controls.Add(label1);
            paymentDetailPanel.Controls.Add(textBox6);
            paymentDetailPanel.Location = new Point(840, 37);
            paymentDetailPanel.Name = "paymentDetailPanel";
            paymentDetailPanel.Size = new Size(761, 694);
            paymentDetailPanel.TabIndex = 16;
            // 
            // enterEditLabel
            // 
            enterEditLabel.AutoSize = true;
            enterEditLabel.ForeColor = Color.Red;
            enterEditLabel.Location = new Point(36, 97);
            enterEditLabel.Name = "enterEditLabel";
            enterEditLabel.Size = new Size(691, 32);
            enterEditLabel.TabIndex = 20;
            enterEditLabel.Text = "You have No Payment Detail. Click Edit to Enter Payment Detail.";
            // 
            // cancelLabel
            // 
            cancelLabel.AutoSize = true;
            cancelLabel.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            cancelLabel.ForeColor = Color.IndianRed;
            cancelLabel.Location = new Point(482, 37);
            cancelLabel.Name = "cancelLabel";
            cancelLabel.Size = new Size(101, 37);
            cancelLabel.TabIndex = 19;
            cancelLabel.Text = "Cancel";
            cancelLabel.Click += cancelLabel_Click;
            // 
            // editLabel
            // 
            editLabel.AutoSize = true;
            editLabel.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            editLabel.ForeColor = SystemColors.ControlText;
            editLabel.Location = new Point(617, 37);
            editLabel.Name = "editLabel";
            editLabel.Size = new Size(67, 37);
            editLabel.TabIndex = 18;
            editLabel.Text = "Edit";
            editLabel.Click += editLabel_Click;
            // 
            // applyChangeButton
            // 
            applyChangeButton.BackColor = SystemColors.ActiveCaptionText;
            applyChangeButton.ForeColor = SystemColors.ControlLightLight;
            applyChangeButton.Location = new Point(251, 579);
            applyChangeButton.Name = "applyChangeButton";
            applyChangeButton.Size = new Size(215, 67);
            applyChangeButton.TabIndex = 17;
            applyChangeButton.Text = "Apply Change";
            applyChangeButton.UseVisualStyleBackColor = false;
            applyChangeButton.Click += applyChangeButton_Click;
            // 
            // loadItemCardPanel
            // 
            loadItemCardPanel.BorderStyle = BorderStyle.FixedSingle;
            loadItemCardPanel.Location = new Point(38, 37);
            loadItemCardPanel.Name = "loadItemCardPanel";
            loadItemCardPanel.Size = new Size(760, 694);
            loadItemCardPanel.TabIndex = 17;
            // 
            // totalPanel
            // 
            totalPanel.BorderStyle = BorderStyle.FixedSingle;
            totalPanel.Controls.Add(totalDuePirceLabel);
            totalPanel.Controls.Add(taxPriceLabel);
            totalPanel.Controls.Add(label6);
            totalPanel.Controls.Add(label5);
            totalPanel.Controls.Add(subtotalPriceLabel);
            totalPanel.Controls.Add(subTotalLabel);
            totalPanel.Location = new Point(38, 754);
            totalPanel.Name = "totalPanel";
            totalPanel.Size = new Size(760, 260);
            totalPanel.TabIndex = 18;
            // 
            // totalDuePirceLabel
            // 
            totalDuePirceLabel.AutoSize = true;
            totalDuePirceLabel.ForeColor = SystemColors.ControlText;
            totalDuePirceLabel.Location = new Point(601, 188);
            totalDuePirceLabel.Name = "totalDuePirceLabel";
            totalDuePirceLabel.Size = new Size(84, 32);
            totalDuePirceLabel.TabIndex = 5;
            totalDuePirceLabel.Text = "$00.00";
            // 
            // taxPriceLabel
            // 
            taxPriceLabel.AutoSize = true;
            taxPriceLabel.ForeColor = SystemColors.ControlText;
            taxPriceLabel.Location = new Point(601, 114);
            taxPriceLabel.Name = "taxPriceLabel";
            taxPriceLabel.Size = new Size(84, 32);
            taxPriceLabel.TabIndex = 4;
            taxPriceLabel.Text = "$00.00";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(29, 188);
            label6.Name = "label6";
            label6.Size = new Size(118, 32);
            label6.TabIndex = 3;
            label6.Text = "Total Due";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(29, 105);
            label5.Name = "label5";
            label5.Size = new Size(56, 32);
            label5.TabIndex = 2;
            label5.Text = "Tax:";
            // 
            // subtotalPriceLabel
            // 
            subtotalPriceLabel.AutoSize = true;
            subtotalPriceLabel.ForeColor = SystemColors.ControlText;
            subtotalPriceLabel.Location = new Point(601, 24);
            subtotalPriceLabel.Name = "subtotalPriceLabel";
            subtotalPriceLabel.Size = new Size(84, 32);
            subtotalPriceLabel.TabIndex = 1;
            subtotalPriceLabel.Text = "$00.00";
            // 
            // subTotalLabel
            // 
            subTotalLabel.AutoSize = true;
            subTotalLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            subTotalLabel.ForeColor = SystemColors.ControlText;
            subTotalLabel.Location = new Point(20, 24);
            subTotalLabel.Name = "subTotalLabel";
            subTotalLabel.Size = new Size(112, 32);
            subTotalLabel.TabIndex = 0;
            subTotalLabel.Text = "Subtotal:";
            // 
            // PaymentUserControl1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(totalPanel);
            Controls.Add(loadItemCardPanel);
            Controls.Add(paymentDetailPanel);
            Controls.Add(button1);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(6);
            Name = "PaymentUserControl1";
            Size = new Size(1638, 1060);
            paymentDetailPanel.ResumeLayout(false);
            paymentDetailPanel.PerformLayout();
            totalPanel.ResumeLayout(false);
            totalPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Panel paymentDetailPanel;
        private Button applyChangeButton;
        private Label editLabel;
        private Panel loadItemCardPanel;
        private Panel totalPanel;
        private Label subtotalPriceLabel;
        private Label subTotalLabel;
        private Label taxPriceLabel;
        private Label label6;
        private Label label5;
        private Label totalDuePirceLabel;
        private Label cancelLabel;
        private Label enterEditLabel;
    }
}
