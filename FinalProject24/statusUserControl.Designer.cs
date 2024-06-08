namespace FinalProject24
{
    partial class statusUserControl
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
            nameLabel = new Label();
            statusButton = new Button();
            itemsListBox = new ListBox();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameLabel.ForeColor = SystemColors.ControlLight;
            nameLabel.Location = new Point(17, 18);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(140, 37);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Lee James";
            // 
            // statusButton
            // 
            statusButton.BackColor = SystemColors.ControlLightLight;
            statusButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            statusButton.ForeColor = SystemColors.ControlText;
            statusButton.Location = new Point(28, 438);
            statusButton.Name = "statusButton";
            statusButton.Size = new Size(189, 56);
            statusButton.TabIndex = 2;
            statusButton.Text = "Accept";
            statusButton.UseVisualStyleBackColor = false;
            // 
            // itemsListBox
            // 
            itemsListBox.FormattingEnabled = true;
            itemsListBox.Location = new Point(28, 58);
            itemsListBox.Name = "itemsListBox";
            itemsListBox.Size = new Size(418, 356);
            itemsListBox.TabIndex = 0;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.FromArgb(192, 0, 0);
            cancelButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelButton.ForeColor = SystemColors.ControlLightLight;
            cancelButton.Location = new Point(257, 438);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(189, 56);
            cancelButton.TabIndex = 3;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // stausUserControl
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(cancelButton);
            Controls.Add(itemsListBox);
            Controls.Add(statusButton);
            Controls.Add(nameLabel);
            Name = "stausUserControl";
            Size = new Size(480, 530);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private Button statusButton;
        private ListBox itemsListBox;
        private Button cancelButton;
    }
}
