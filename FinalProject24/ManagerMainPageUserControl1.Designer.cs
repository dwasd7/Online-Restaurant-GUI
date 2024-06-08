namespace FinalProject24
{
    partial class ManagerMainPageUserControl1
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
            pendingPanel = new Panel();
            acceptedPanel = new Panel();
            readyPanel = new Panel();
            label1 = new Label();
            acceptedLabel = new Label();
            readyLabel = new Label();
            RefreshButton = new Button();
            SuspendLayout();
            // 
            // pendingPanel
            // 
            pendingPanel.AutoScroll = true;
            pendingPanel.BorderStyle = BorderStyle.FixedSingle;
            pendingPanel.Location = new Point(17, 31);
            pendingPanel.Margin = new Padding(2, 1, 2, 1);
            pendingPanel.Name = "pendingPanel";
            pendingPanel.Size = new Size(281, 459);
            pendingPanel.TabIndex = 0;
            // 
            // acceptedPanel
            // 
            acceptedPanel.AutoScroll = true;
            acceptedPanel.BorderStyle = BorderStyle.FixedSingle;
            acceptedPanel.Location = new Point(308, 30);
            acceptedPanel.Margin = new Padding(2, 1, 2, 1);
            acceptedPanel.Name = "acceptedPanel";
            acceptedPanel.Size = new Size(279, 460);
            acceptedPanel.TabIndex = 1;
            // 
            // readyPanel
            // 
            readyPanel.AutoScroll = true;
            readyPanel.BorderStyle = BorderStyle.FixedSingle;
            readyPanel.Location = new Point(597, 30);
            readyPanel.Margin = new Padding(2, 1, 2, 1);
            readyPanel.Name = "readyPanel";
            readyPanel.Size = new Size(271, 460);
            readyPanel.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(69, 21);
            label1.TabIndex = 3;
            label1.Text = "Pending";
            // 
            // acceptedLabel
            // 
            acceptedLabel.AutoSize = true;
            acceptedLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            acceptedLabel.Location = new Point(303, 8);
            acceptedLabel.Margin = new Padding(2, 0, 2, 0);
            acceptedLabel.Name = "acceptedLabel";
            acceptedLabel.Size = new Size(81, 21);
            acceptedLabel.TabIndex = 4;
            acceptedLabel.Text = "Accepted";
            // 
            // readyLabel
            // 
            readyLabel.AutoSize = true;
            readyLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            readyLabel.Location = new Point(592, 8);
            readyLabel.Margin = new Padding(2, 0, 2, 0);
            readyLabel.Name = "readyLabel";
            readyLabel.Size = new Size(55, 21);
            readyLabel.TabIndex = 5;
            readyLabel.Text = "Ready";
            // 
            // RefreshButton
            // 
            RefreshButton.BackColor = SystemColors.ControlText;
            RefreshButton.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RefreshButton.ForeColor = SystemColors.ControlLightLight;
            RefreshButton.Location = new Point(372, 512);
            RefreshButton.Margin = new Padding(2, 1, 2, 1);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(133, 34);
            RefreshButton.TabIndex = 6;
            RefreshButton.Text = "Refresh";
            RefreshButton.UseVisualStyleBackColor = false;
            RefreshButton.Click += RefreshButton_Click;
            // 
            // ManagerMainPageUserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(RefreshButton);
            Controls.Add(readyLabel);
            Controls.Add(acceptedLabel);
            Controls.Add(label1);
            Controls.Add(readyPanel);
            Controls.Add(acceptedPanel);
            Controls.Add(pendingPanel);
            Name = "ManagerMainPageUserControl1";
            Size = new Size(886, 562);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pendingPanel;
        private Panel acceptedPanel;
        private Panel readyPanel;
        private Label label1;
        private Label acceptedLabel;
        private Label readyLabel;
        private Button RefreshButton;
    }
}
