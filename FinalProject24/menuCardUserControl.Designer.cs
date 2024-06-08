namespace FinalProject24
{
    partial class menuCardUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuCardUserControl));
            menuPictureBox = new PictureBox();
            itemNameLabel = new Label();
            priceLabel = new Label();
            addButton = new Button();
            removeButton = new Button();
            idLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)menuPictureBox).BeginInit();
            SuspendLayout();
            // 
            // menuPictureBox
            // 
            menuPictureBox.BackColor = SystemColors.ButtonShadow;
            menuPictureBox.InitialImage = (Image)resources.GetObject("menuPictureBox.InitialImage");
            menuPictureBox.Location = new Point(0, 0);
            menuPictureBox.Name = "menuPictureBox";
            menuPictureBox.Size = new Size(400, 267);
            menuPictureBox.TabIndex = 0;
            menuPictureBox.TabStop = false;
            // 
            // itemNameLabel
            // 
            itemNameLabel.AutoSize = true;
            itemNameLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itemNameLabel.Location = new Point(0, 270);
            itemNameLabel.Name = "itemNameLabel";
            itemNameLabel.Size = new Size(182, 45);
            itemNameLabel.TabIndex = 1;
            itemNameLabel.Text = "Item Name";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            priceLabel.Location = new Point(3, 315);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(83, 37);
            priceLabel.TabIndex = 2;
            priceLabel.Text = "$6.09";
            // 
            // addButton
            // 
            addButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addButton.Location = new Point(314, 191);
            addButton.Name = "addButton";
            addButton.Size = new Size(68, 54);
            addButton.TabIndex = 3;
            addButton.Text = "+";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // removeButton
            // 
            removeButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            removeButton.Location = new Point(224, 191);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(68, 54);
            removeButton.TabIndex = 4;
            removeButton.Text = "-";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(217, 322);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(19, 32);
            idLabel.TabIndex = 5;
            idLabel.Text = ":";
            // 
            // menuCardUserControl
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(idLabel);
            Controls.Add(removeButton);
            Controls.Add(addButton);
            Controls.Add(priceLabel);
            Controls.Add(itemNameLabel);
            Controls.Add(menuPictureBox);
            Name = "menuCardUserControl";
            Size = new Size(398, 380);
            ((System.ComponentModel.ISupportInitialize)menuPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox menuPictureBox;
        private Label itemNameLabel;
        private Label priceLabel;
        private Button addButton;
        private Button removeButton;
        private Label idLabel;
    }
}
