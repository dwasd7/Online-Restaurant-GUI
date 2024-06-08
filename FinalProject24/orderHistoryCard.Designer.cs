namespace FinalProject24
{
    partial class orderHistoryCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(orderHistoryCard));
            orderNumberLabel = new Label();
            dateLabel = new Label();
            totalLabel = new Label();
            statusLabel = new Label();
            dateTextLabel = new Label();
            totalTextLabel = new Label();
            statusTextLabel = new Label();
            viewDetailButton = new Button();
            SuspendLayout();
            // 
            // orderNumberLabel
            // 
            orderNumberLabel.AutoSize = true;
            orderNumberLabel.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold);
            orderNumberLabel.Location = new Point(10, 6);
            orderNumberLabel.Margin = new Padding(2, 0, 2, 0);
            orderNumberLabel.Name = "orderNumberLabel";
            orderNumberLabel.Size = new Size(103, 13);
            orderNumberLabel.TabIndex = 0;
            orderNumberLabel.Text = "Order # 600360532";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Segoe UI Semibold", 7.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateLabel.Location = new Point(13, 31);
            dateLabel.Margin = new Padding(2, 0, 2, 0);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(31, 13);
            dateLabel.TabIndex = 1;
            dateLabel.Text = "Date";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Font = new Font("Segoe UI Semibold", 7.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalLabel.Location = new Point(106, 31);
            totalLabel.Margin = new Padding(2, 0, 2, 0);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(32, 13);
            totalLabel.TabIndex = 2;
            totalLabel.Text = "Total";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new Font("Segoe UI Semibold", 7.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            statusLabel.Location = new Point(186, 31);
            statusLabel.Margin = new Padding(2, 0, 2, 0);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(38, 13);
            statusLabel.TabIndex = 3;
            statusLabel.Text = "Status";
            // 
            // dateTextLabel
            // 
            dateTextLabel.AutoSize = true;
            dateTextLabel.Font = new Font("Segoe UI", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTextLabel.Location = new Point(15, 50);
            dateTextLabel.Margin = new Padding(2, 0, 2, 0);
            dateTextLabel.Name = "dateTextLabel";
            dateTextLabel.Size = new Size(71, 13);
            dateTextLabel.TabIndex = 4;
            dateTextLabel.Text = "Feb 21, 2019";
            // 
            // totalTextLabel
            // 
            totalTextLabel.AutoSize = true;
            totalTextLabel.Font = new Font("Segoe UI", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalTextLabel.Location = new Point(106, 50);
            totalTextLabel.Margin = new Padding(2, 0, 2, 0);
            totalTextLabel.Name = "totalTextLabel";
            totalTextLabel.Size = new Size(46, 13);
            totalTextLabel.TabIndex = 5;
            totalTextLabel.Text = "$375.34";
            // 
            // statusTextLabel
            // 
            statusTextLabel.AutoSize = true;
            statusTextLabel.Font = new Font("Segoe UI", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusTextLabel.Location = new Point(186, 50);
            statusTextLabel.Margin = new Padding(2, 0, 2, 0);
            statusTextLabel.Name = "statusTextLabel";
            statusTextLabel.Size = new Size(51, 13);
            statusTextLabel.TabIndex = 6;
            statusTextLabel.Text = "On Hold";
            // 
            // viewDetailButton
            // 
            viewDetailButton.BackColor = Color.FromArgb(211, 210, 210);
            viewDetailButton.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            viewDetailButton.Image = (Image)resources.GetObject("viewDetailButton.Image");
            viewDetailButton.Location = new Point(259, 0);
            viewDetailButton.Margin = new Padding(2, 1, 2, 1);
            viewDetailButton.Name = "viewDetailButton";
            viewDetailButton.Size = new Size(52, 77);
            viewDetailButton.TabIndex = 7;
            viewDetailButton.UseVisualStyleBackColor = false;
            viewDetailButton.Click += viewDetailButton_Click;
            // 
            // orderHistoryCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(217, 217, 217);
            Controls.Add(viewDetailButton);
            Controls.Add(statusTextLabel);
            Controls.Add(totalTextLabel);
            Controls.Add(dateTextLabel);
            Controls.Add(statusLabel);
            Controls.Add(totalLabel);
            Controls.Add(dateLabel);
            Controls.Add(orderNumberLabel);
            Margin = new Padding(2, 1, 2, 1);
            Name = "orderHistoryCard";
            Size = new Size(310, 77);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label orderNumberLabel;
        private Label dateLabel;
        private Label totalLabel;
        private Label statusLabel;
        private Label dateTextLabel;
        private Label totalTextLabel;
        private Label statusTextLabel;
        private Button viewDetailButton;
    }
}
