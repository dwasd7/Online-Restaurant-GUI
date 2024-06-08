namespace FinalProject24
{
    partial class CartItemUC
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
            myCartPictureBox = new PictureBox();
            myCartFoodNameLabel = new Label();
            myCartRestaurantLabel = new Label();
            myCartDeleteButton = new Button();
            addAndDeletePanel = new Panel();
            myCartRemoveButton = new Button();
            myCartTotalItemLabel = new Label();
            myCartAddButton = new Button();
            myCartPriceLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)myCartPictureBox).BeginInit();
            addAndDeletePanel.SuspendLayout();
            SuspendLayout();
            // 
            // myCartPictureBox
            // 
            myCartPictureBox.BackColor = SystemColors.ControlLight;
            myCartPictureBox.Location = new Point(6, 6);
            myCartPictureBox.Margin = new Padding(6);
            myCartPictureBox.Name = "myCartPictureBox";
            myCartPictureBox.Size = new Size(226, 222);
            myCartPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            myCartPictureBox.TabIndex = 0;
            myCartPictureBox.TabStop = false;
            // 
            // myCartFoodNameLabel
            // 
            myCartFoodNameLabel.AutoSize = true;
            myCartFoodNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            myCartFoodNameLabel.Location = new Point(293, 38);
            myCartFoodNameLabel.Margin = new Padding(6, 0, 6, 0);
            myCartFoodNameLabel.Name = "myCartFoodNameLabel";
            myCartFoodNameLabel.Size = new Size(194, 45);
            myCartFoodNameLabel.TabIndex = 2;
            myCartFoodNameLabel.Text = "Food Name";
            // 
            // myCartRestaurantLabel
            // 
            myCartRestaurantLabel.AutoSize = true;
            myCartRestaurantLabel.Location = new Point(293, 147);
            myCartRestaurantLabel.Margin = new Padding(6, 0, 6, 0);
            myCartRestaurantLabel.Name = "myCartRestaurantLabel";
            myCartRestaurantLabel.Size = new Size(197, 32);
            myCartRestaurantLabel.TabIndex = 3;
            myCartRestaurantLabel.Text = "Restaurant Name";
            // 
            // myCartDeleteButton
            // 
            myCartDeleteButton.BackColor = Color.Transparent;
            myCartDeleteButton.FlatAppearance.BorderSize = 0;
            myCartDeleteButton.FlatStyle = FlatStyle.Flat;
            myCartDeleteButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            myCartDeleteButton.Location = new Point(591, 124);
            myCartDeleteButton.Margin = new Padding(6);
            myCartDeleteButton.Name = "myCartDeleteButton";
            myCartDeleteButton.Size = new Size(65, 53);
            myCartDeleteButton.TabIndex = 8;
            myCartDeleteButton.Text = "🗑️";
            myCartDeleteButton.UseVisualStyleBackColor = false;
            myCartDeleteButton.Click += myCartDeleteButton_Click;
            // 
            // addAndDeletePanel
            // 
            addAndDeletePanel.BackColor = SystemColors.ActiveBorder;
            addAndDeletePanel.Controls.Add(myCartRemoveButton);
            addAndDeletePanel.Controls.Add(myCartTotalItemLabel);
            addAndDeletePanel.Controls.Add(myCartAddButton);
            addAndDeletePanel.Location = new Point(682, 126);
            addAndDeletePanel.Margin = new Padding(6);
            addAndDeletePanel.Name = "addAndDeletePanel";
            addAndDeletePanel.Size = new Size(152, 53);
            addAndDeletePanel.TabIndex = 7;
            // 
            // myCartRemoveButton
            // 
            myCartRemoveButton.FlatAppearance.BorderSize = 0;
            myCartRemoveButton.FlatStyle = FlatStyle.Flat;
            myCartRemoveButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            myCartRemoveButton.Location = new Point(100, -30);
            myCartRemoveButton.Margin = new Padding(6);
            myCartRemoveButton.Name = "myCartRemoveButton";
            myCartRemoveButton.Size = new Size(65, 100);
            myCartRemoveButton.TabIndex = 1;
            myCartRemoveButton.Text = "-";
            myCartRemoveButton.UseVisualStyleBackColor = true;
            myCartRemoveButton.Click += myCartRemoveButton_Click;
            // 
            // myCartTotalItemLabel
            // 
            myCartTotalItemLabel.AutoSize = true;
            myCartTotalItemLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            myCartTotalItemLabel.Location = new Point(65, 11);
            myCartTotalItemLabel.Margin = new Padding(6, 0, 6, 0);
            myCartTotalItemLabel.Name = "myCartTotalItemLabel";
            myCartTotalItemLabel.Size = new Size(27, 32);
            myCartTotalItemLabel.TabIndex = 0;
            myCartTotalItemLabel.Text = "1";
            // 
            // myCartAddButton
            // 
            myCartAddButton.FlatAppearance.BorderSize = 0;
            myCartAddButton.FlatStyle = FlatStyle.Flat;
            myCartAddButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            myCartAddButton.Location = new Point(0, -21);
            myCartAddButton.Margin = new Padding(6);
            myCartAddButton.Name = "myCartAddButton";
            myCartAddButton.Size = new Size(54, 87);
            myCartAddButton.TabIndex = 2;
            myCartAddButton.Text = "+";
            myCartAddButton.UseVisualStyleBackColor = true;
            myCartAddButton.Click += myCartAddButton_Click;
            // 
            // myCartPriceLabel
            // 
            myCartPriceLabel.AutoSize = true;
            myCartPriceLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            myCartPriceLabel.Location = new Point(737, 46);
            myCartPriceLabel.Margin = new Padding(6, 0, 6, 0);
            myCartPriceLabel.Name = "myCartPriceLabel";
            myCartPriceLabel.Size = new Size(97, 36);
            myCartPriceLabel.TabIndex = 6;
            myCartPriceLabel.Text = "$12.99";
            // 
            // CartItemUC
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(myCartDeleteButton);
            Controls.Add(addAndDeletePanel);
            Controls.Add(myCartPriceLabel);
            Controls.Add(myCartRestaurantLabel);
            Controls.Add(myCartFoodNameLabel);
            Controls.Add(myCartPictureBox);
            Margin = new Padding(6);
            Name = "CartItemUC";
            Size = new Size(876, 233);
            ((System.ComponentModel.ISupportInitialize)myCartPictureBox).EndInit();
            addAndDeletePanel.ResumeLayout(false);
            addAndDeletePanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox myCartPictureBox;
        private Label myCartFoodNameLabel;
        private Label myCartRestaurantLabel;
        private Button myCartDeleteButton;
        private Panel addAndDeletePanel;
        private Button myCartRemoveButton;
        private Label myCartTotalItemLabel;
        private Button myCartAddButton;
        private Label myCartPriceLabel;
    }
}
