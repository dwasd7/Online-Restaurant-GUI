namespace FinalProject24
{
    partial class orderHistoryUserControl
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
            orderHistoryPanel = new Panel();
            orderSummaryPanel = new Panel();
            SuspendLayout();
            // 
            // orderHistoryPanel
            // 
            orderHistoryPanel.Location = new Point(30, 41);
            orderHistoryPanel.Name = "orderHistoryPanel";
            orderHistoryPanel.Size = new Size(924, 980);
            orderHistoryPanel.TabIndex = 0;
            // 
            // orderSummaryPanel
            // 
            orderSummaryPanel.Location = new Point(978, 41);
            orderSummaryPanel.Name = "orderSummaryPanel";
            orderSummaryPanel.Size = new Size(632, 980);
            orderSummaryPanel.TabIndex = 1;
            // 
            // orderHistoryUserControl
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(orderSummaryPanel);
            Controls.Add(orderHistoryPanel);
            Name = "orderHistoryUserControl";
            Size = new Size(1638, 1054);
            ResumeLayout(false);
        }

        #endregion

        private Panel orderHistoryPanel;
        private Panel orderSummaryPanel;
    }
}
