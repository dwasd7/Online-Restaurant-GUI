namespace FinalProject24
{
    partial class checkOurCardUserControl
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
            cardPictureBox = new PictureBox();
            foodNameLabel = new Label();
            cardPriceLabel = new Label();
            quantityLabel = new Label();
            eachPriceLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)cardPictureBox).BeginInit();
            SuspendLayout();
            // 
            // cardPictureBox
            // 
            cardPictureBox.BorderStyle = BorderStyle.FixedSingle;
            cardPictureBox.Location = new Point(3, 3);
            cardPictureBox.Name = "cardPictureBox";
            cardPictureBox.Size = new Size(177, 135);
            cardPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            cardPictureBox.TabIndex = 0;
            cardPictureBox.TabStop = false;
            // 
            // foodNameLabel
            // 
            foodNameLabel.AutoSize = true;
            foodNameLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            foodNameLabel.Location = new Point(195, 22);
            foodNameLabel.Name = "foodNameLabel";
            foodNameLabel.Size = new Size(140, 32);
            foodNameLabel.TabIndex = 1;
            foodNameLabel.Text = "Food Name";
            // 
            // cardPriceLabel
            // 
            cardPriceLabel.AutoSize = true;
            cardPriceLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cardPriceLabel.Location = new Point(637, 22);
            cardPriceLabel.Name = "cardPriceLabel";
            cardPriceLabel.Size = new Size(84, 32);
            cardPriceLabel.TabIndex = 2;
            cardPriceLabel.Text = "$65.00";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            quantityLabel.Location = new Point(195, 75);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(77, 32);
            quantityLabel.TabIndex = 3;
            quantityLabel.Text = "Qty: 1";
            // 
            // eachPriceLabel
            // 
            eachPriceLabel.AutoSize = true;
            eachPriceLabel.Location = new Point(606, 75);
            eachPriceLabel.Name = "eachPriceLabel";
            eachPriceLabel.Size = new Size(0, 32);
            eachPriceLabel.TabIndex = 4;
            // 
            // checkOurCardUserControl
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(eachPriceLabel);
            Controls.Add(quantityLabel);
            Controls.Add(cardPriceLabel);
            Controls.Add(foodNameLabel);
            Controls.Add(cardPictureBox);
            Name = "checkOurCardUserControl";
            Size = new Size(755, 141);
            ((System.ComponentModel.ISupportInitialize)cardPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox cardPictureBox;
        private Label foodNameLabel;
        private Label cardPriceLabel;
        private Label quantityLabel;
        private Label eachPriceLabel;
    }
}
