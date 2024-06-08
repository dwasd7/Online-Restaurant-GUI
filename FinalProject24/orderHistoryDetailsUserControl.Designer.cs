namespace FinalProject24
{
    partial class orderHistoryDetailsUserControl
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
            orderNumber = new Label();
            dateLabel = new Label();
            statusLabel = new Label();
            statusTextLabel = new Label();
            dateTextLabel = new Label();
            displayDetailText = new Label();
            orderNumberTextLabel = new Label();
            SuspendLayout();
            // 
            // orderNumber
            // 
            orderNumber.AutoSize = true;
            orderNumber.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderNumber.Location = new Point(14, 30);
            orderNumber.Margin = new Padding(2, 0, 2, 0);
            orderNumber.Name = "orderNumber";
            orderNumber.Size = new Size(62, 20);
            orderNumber.TabIndex = 0;
            orderNumber.Text = "Order #";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateLabel.Location = new Point(275, 30);
            dateLabel.Margin = new Padding(2, 0, 2, 0);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(45, 20);
            dateLabel.TabIndex = 1;
            dateLabel.Text = "Date:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            statusLabel.Location = new Point(18, 74);
            statusLabel.Margin = new Padding(2, 0, 2, 0);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(43, 15);
            statusLabel.TabIndex = 2;
            statusLabel.Text = "Status:";
            // 
            // statusTextLabel
            // 
            statusTextLabel.AutoSize = true;
            statusTextLabel.Location = new Point(68, 74);
            statusTextLabel.Margin = new Padding(2, 0, 2, 0);
            statusTextLabel.Name = "statusTextLabel";
            statusTextLabel.Size = new Size(43, 15);
            statusTextLabel.TabIndex = 3;
            statusTextLabel.Text = "Cancel";
            // 
            // dateTextLabel
            // 
            dateTextLabel.AutoSize = true;
            dateTextLabel.Location = new Point(316, 34);
            dateTextLabel.Margin = new Padding(2, 0, 2, 0);
            dateTextLabel.Name = "dateTextLabel";
            dateTextLabel.Size = new Size(71, 15);
            dateTextLabel.TabIndex = 4;
            dateTextLabel.Text = "Feb 21, 2019";
            // 
            // displayDetailText
            // 
            displayDetailText.BackColor = SystemColors.ControlLightLight;
            displayDetailText.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            displayDetailText.Location = new Point(25, 120);
            displayDetailText.Margin = new Padding(2, 0, 2, 0);
            displayDetailText.Name = "displayDetailText";
            displayDetailText.Size = new Size(372, 304);
            displayDetailText.TabIndex = 5;
            // 
            // orderNumberTextLabel
            // 
            orderNumberTextLabel.AutoSize = true;
            orderNumberTextLabel.Location = new Point(81, 33);
            orderNumberTextLabel.Margin = new Padding(2, 0, 2, 0);
            orderNumberTextLabel.Name = "orderNumberTextLabel";
            orderNumberTextLabel.Size = new Size(43, 15);
            orderNumberTextLabel.TabIndex = 6;
            orderNumberTextLabel.Text = "101010";
            // 
            // orderHistoryDetailsUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(orderNumberTextLabel);
            Controls.Add(displayDetailText);
            Controls.Add(dateTextLabel);
            Controls.Add(statusTextLabel);
            Controls.Add(statusLabel);
            Controls.Add(dateLabel);
            Controls.Add(orderNumber);
            Margin = new Padding(2, 1, 2, 1);
            Name = "orderHistoryDetailsUserControl";
            Size = new Size(433, 458);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label orderNumber;
        private Label dateLabel;
        private Label statusLabel;
        public Label displayDetailText;
        public Label statusTextLabel;
        public Label dateTextLabel;
        public Label orderNumberTextLabel;
    }
}
