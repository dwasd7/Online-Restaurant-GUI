namespace FinalProject24
{
    partial class NS_MEditPageUserControl1
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
            label1 = new Label();
            MenuIDtextBox = new TextBox();
            pictureBox = new PictureBox();
            SelectImageButton = new Button();
            SubmitButton = new Button();
            NametextBox = new TextBox();
            label2 = new Label();
            PricetextBox = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 101);
            label1.Name = "label1";
            label1.Size = new Size(129, 25);
            label1.TabIndex = 0;
            label1.Text = "Enter Menu ID:";
            // 
            // MenuIDtextBox
            // 
            MenuIDtextBox.Location = new Point(245, 101);
            MenuIDtextBox.Name = "MenuIDtextBox";
            MenuIDtextBox.Size = new Size(150, 31);
            MenuIDtextBox.TabIndex = 1;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(755, 101);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(199, 138);
            pictureBox.TabIndex = 2;
            pictureBox.TabStop = false;
            // 
            // SelectImageButton
            // 
            SelectImageButton.Location = new Point(771, 254);
            SelectImageButton.Name = "SelectImageButton";
            SelectImageButton.Size = new Size(163, 34);
            SelectImageButton.TabIndex = 3;
            SelectImageButton.Text = "Select Image File";
            SelectImageButton.UseVisualStyleBackColor = true;
            SelectImageButton.Click += SelectImageButton_Click;
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(467, 356);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(168, 34);
            SubmitButton.TabIndex = 4;
            SubmitButton.Text = "Apply Changes";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // NametextBox
            // 
            NametextBox.Location = new Point(245, 170);
            NametextBox.Name = "NametextBox";
            NametextBox.Size = new Size(150, 31);
            NametextBox.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(126, 170);
            label2.Name = "label2";
            label2.Size = new Size(113, 25);
            label2.TabIndex = 5;
            label2.Text = "Menu Name:";
            // 
            // PricetextBox
            // 
            PricetextBox.Location = new Point(245, 243);
            PricetextBox.Name = "PricetextBox";
            PricetextBox.Size = new Size(150, 31);
            PricetextBox.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(126, 243);
            label3.Name = "label3";
            label3.Size = new Size(103, 25);
            label3.TabIndex = 7;
            label3.Text = "Menu Price:";
            // 
            // NS_MEditPageUserControl1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PricetextBox);
            Controls.Add(label3);
            Controls.Add(NametextBox);
            Controls.Add(label2);
            Controls.Add(SubmitButton);
            Controls.Add(SelectImageButton);
            Controls.Add(pictureBox);
            Controls.Add(MenuIDtextBox);
            Controls.Add(label1);
            Name = "NS_MEditPageUserControl1";
            Size = new Size(1083, 467);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox MenuIDtextBox;
        private PictureBox pictureBox;
        private Button SelectImageButton;
        private Button SubmitButton;
        private TextBox NametextBox;
        private Label label2;
        private TextBox PricetextBox;
        private Label label3;
    }
}
