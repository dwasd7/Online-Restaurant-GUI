namespace FinalProject24
{
    partial class NS_MViewPageUserControl1
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
            loadMenuPanel = new Panel();
            menuLabel = new Label();
            SuspendLayout();
            // 
            // loadMenuPanel
            // 
            loadMenuPanel.BorderStyle = BorderStyle.FixedSingle;
            loadMenuPanel.Location = new Point(174, 110);
            loadMenuPanel.Margin = new Padding(4);
            loadMenuPanel.Name = "loadMenuPanel";
            loadMenuPanel.Size = new Size(1268, 1005);
            loadMenuPanel.TabIndex = 0;
            // 
            // menuLabel
            // 
            menuLabel.AutoSize = true;
            menuLabel.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuLabel.Location = new Point(162, 69);
            menuLabel.Name = "menuLabel";
            menuLabel.Size = new Size(195, 37);
            menuLabel.TabIndex = 1;
            menuLabel.Text = "Current Menu:";
            // 
            // NS_MViewPageUserControl1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(menuLabel);
            Controls.Add(loadMenuPanel);
            Margin = new Padding(4);
            Name = "NS_MViewPageUserControl1";
            Size = new Size(1633, 1198);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel loadMenuPanel;
        private Label menuLabel;
    }
}
