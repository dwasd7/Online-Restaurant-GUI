namespace FinalProject24
{
    partial class CartUC
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
            myCartLabel = new Label();
            summaryOrderLabel = new Label();
            summaryOrderPanel = new Panel();
            totalLabelText = new Label();
            totalLabel = new Label();
            subtotalPriceLabel = new Label();
            taxPriceLabel = new Label();
            totalItemNumberLabel = new Label();
            buyNowButton = new Button();
            subtotalLabel = new Label();
            taxLabel = new Label();
            totalItemLabel = new Label();
            loadCardPanel = new Panel();
            summaryOrderPanel.SuspendLayout();
            SuspendLayout();
            // 
            // myCartLabel
            // 
            myCartLabel.AutoSize = true;
            myCartLabel.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            myCartLabel.Location = new Point(69, 81);
            myCartLabel.Margin = new Padding(6, 0, 6, 0);
            myCartLabel.Name = "myCartLabel";
            myCartLabel.Size = new Size(186, 59);
            myCartLabel.TabIndex = 6;
            myCartLabel.Text = "My Cart";
            myCartLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // summaryOrderLabel
            // 
            summaryOrderLabel.AutoSize = true;
            summaryOrderLabel.BackColor = Color.Transparent;
            summaryOrderLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            summaryOrderLabel.Location = new Point(35, 45);
            summaryOrderLabel.Margin = new Padding(6, 0, 6, 0);
            summaryOrderLabel.Name = "summaryOrderLabel";
            summaryOrderLabel.Size = new Size(259, 45);
            summaryOrderLabel.TabIndex = 0;
            summaryOrderLabel.Text = "Summary Order";
            // 
            // summaryOrderPanel
            // 
            summaryOrderPanel.BackColor = SystemColors.ScrollBar;
            summaryOrderPanel.Controls.Add(totalLabelText);
            summaryOrderPanel.Controls.Add(totalLabel);
            summaryOrderPanel.Controls.Add(subtotalPriceLabel);
            summaryOrderPanel.Controls.Add(taxPriceLabel);
            summaryOrderPanel.Controls.Add(totalItemNumberLabel);
            summaryOrderPanel.Controls.Add(buyNowButton);
            summaryOrderPanel.Controls.Add(subtotalLabel);
            summaryOrderPanel.Controls.Add(taxLabel);
            summaryOrderPanel.Controls.Add(totalItemLabel);
            summaryOrderPanel.Controls.Add(summaryOrderLabel);
            summaryOrderPanel.Location = new Point(1111, 162);
            summaryOrderPanel.Margin = new Padding(6);
            summaryOrderPanel.Name = "summaryOrderPanel";
            summaryOrderPanel.Size = new Size(462, 439);
            summaryOrderPanel.TabIndex = 7;
            // 
            // totalLabelText
            // 
            totalLabelText.AutoSize = true;
            totalLabelText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            totalLabelText.Location = new Point(303, 254);
            totalLabelText.Margin = new Padding(6, 0, 6, 0);
            totalLabelText.Name = "totalLabelText";
            totalLabelText.Size = new Size(77, 32);
            totalLabelText.TabIndex = 9;
            totalLabelText.Text = "$2.50";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Font = new Font("Segoe UI", 9.75F);
            totalLabel.Location = new Point(35, 250);
            totalLabel.Margin = new Padding(6, 0, 6, 0);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(75, 36);
            totalLabel.TabIndex = 8;
            totalLabel.Text = "Total:";
            // 
            // subtotalPriceLabel
            // 
            subtotalPriceLabel.AutoSize = true;
            subtotalPriceLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            subtotalPriceLabel.Location = new Point(303, 160);
            subtotalPriceLabel.Margin = new Padding(6, 0, 6, 0);
            subtotalPriceLabel.Name = "subtotalPriceLabel";
            subtotalPriceLabel.Size = new Size(91, 32);
            subtotalPriceLabel.TabIndex = 7;
            subtotalPriceLabel.Text = "$10.90";
            // 
            // taxPriceLabel
            // 
            taxPriceLabel.AutoSize = true;
            taxPriceLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            taxPriceLabel.Location = new Point(303, 209);
            taxPriceLabel.Margin = new Padding(6, 0, 6, 0);
            taxPriceLabel.Name = "taxPriceLabel";
            taxPriceLabel.Size = new Size(77, 32);
            taxPriceLabel.TabIndex = 6;
            taxPriceLabel.Text = "$2.50";
            // 
            // totalItemNumberLabel
            // 
            totalItemNumberLabel.AutoSize = true;
            totalItemNumberLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            totalItemNumberLabel.Location = new Point(303, 119);
            totalItemNumberLabel.Margin = new Padding(6, 0, 6, 0);
            totalItemNumberLabel.Name = "totalItemNumberLabel";
            totalItemNumberLabel.Size = new Size(28, 32);
            totalItemNumberLabel.TabIndex = 5;
            totalItemNumberLabel.Text = "3";
            // 
            // buyNowButton
            // 
            buyNowButton.BackColor = SystemColors.ControlText;
            buyNowButton.FlatAppearance.BorderSize = 0;
            buyNowButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buyNowButton.ForeColor = SystemColors.ControlLightLight;
            buyNowButton.Location = new Point(35, 305);
            buyNowButton.Margin = new Padding(6);
            buyNowButton.Name = "buyNowButton";
            buyNowButton.Size = new Size(399, 105);
            buyNowButton.TabIndex = 4;
            buyNowButton.Text = "CHECK OUT";
            buyNowButton.UseVisualStyleBackColor = false;
            buyNowButton.Click += buyNowButton_Click;
            // 
            // subtotalLabel
            // 
            subtotalLabel.AutoSize = true;
            subtotalLabel.Font = new Font("Segoe UI", 9.75F);
            subtotalLabel.Location = new Point(35, 158);
            subtotalLabel.Margin = new Padding(6, 0, 6, 0);
            subtotalLabel.Name = "subtotalLabel";
            subtotalLabel.Size = new Size(117, 36);
            subtotalLabel.TabIndex = 3;
            subtotalLabel.Text = "Subtotal:";
            // 
            // taxLabel
            // 
            taxLabel.AutoSize = true;
            taxLabel.Font = new Font("Segoe UI", 9.75F);
            taxLabel.Location = new Point(35, 205);
            taxLabel.Margin = new Padding(6, 0, 6, 0);
            taxLabel.Name = "taxLabel";
            taxLabel.Size = new Size(57, 36);
            taxLabel.TabIndex = 2;
            taxLabel.Text = "Tax:";
            // 
            // totalItemLabel
            // 
            totalItemLabel.AutoSize = true;
            totalItemLabel.Font = new Font("Segoe UI", 9.75F);
            totalItemLabel.Location = new Point(35, 115);
            totalItemLabel.Margin = new Padding(6, 0, 6, 0);
            totalItemLabel.Name = "totalItemLabel";
            totalItemLabel.Size = new Size(134, 36);
            totalItemLabel.TabIndex = 1;
            totalItemLabel.Text = "Total Item:";
            // 
            // loadCardPanel
            // 
            loadCardPanel.AutoScroll = true;
            loadCardPanel.Location = new Point(84, 162);
            loadCardPanel.Margin = new Padding(4, 2, 4, 2);
            loadCardPanel.Name = "loadCardPanel";
            loadCardPanel.Size = new Size(956, 811);
            loadCardPanel.TabIndex = 8;
            // 
            // CartUC
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(loadCardPanel);
            Controls.Add(myCartLabel);
            Controls.Add(summaryOrderPanel);
            Margin = new Padding(6);
            Name = "CartUC";
            Size = new Size(1638, 1054);
            summaryOrderPanel.ResumeLayout(false);
            summaryOrderPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label myCartLabel;
        private Label summaryOrderLabel;
        private Panel summaryOrderPanel;
        private Label subtotalPriceLabel;
        private Label taxPriceLabel;
        private Label totalItemNumberLabel;
        private Button buyNowButton;
        private Label subtotalLabel;
        private Label taxLabel;
        private Label totalItemLabel;
        private CartItemUC cartItemuc1;
        private CartItemUC cartItemuc2;
        private CartItemUC cartItemuc3;
        private Panel loadCardPanel;
        private Label totalLabel;
        private Label totalLabelText;
    }
}
