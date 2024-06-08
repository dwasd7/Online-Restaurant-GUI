namespace FinalProject24
{
    partial class ManagerMainPageForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerMainPageForm));
            MenuSideBar = new Panel();
            viewCurrentMenu = new Button();
            roundPictureBox1 = new RoundPictureBox();
            ordersButton = new Button();
            exitButton = new Button();
            settingButton = new Button();
            resturantProfileButton = new Button();
            editMenu = new Button();
            nameLabel = new Label();
            signOutButton = new Button();
            mainpanel1 = new Panel();
            MenuSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // MenuSideBar
            // 
            MenuSideBar.BackColor = Color.FromArgb(64, 64, 64);
            MenuSideBar.Controls.Add(viewCurrentMenu);
            MenuSideBar.Controls.Add(roundPictureBox1);
            MenuSideBar.Controls.Add(ordersButton);
            MenuSideBar.Controls.Add(exitButton);
            MenuSideBar.Controls.Add(settingButton);
            MenuSideBar.Controls.Add(resturantProfileButton);
            MenuSideBar.Controls.Add(editMenu);
            MenuSideBar.Controls.Add(nameLabel);
            MenuSideBar.Controls.Add(signOutButton);
            MenuSideBar.Location = new Point(1, 0);
            MenuSideBar.Margin = new Padding(2, 0, 2, 0);
            MenuSideBar.Name = "MenuSideBar";
            MenuSideBar.Size = new Size(100, 565);
            MenuSideBar.TabIndex = 2;
            // 
            // viewCurrentMenu
            // 
            viewCurrentMenu.Location = new Point(2, 176);
            viewCurrentMenu.Margin = new Padding(2, 1, 2, 1);
            viewCurrentMenu.Name = "viewCurrentMenu";
            viewCurrentMenu.Size = new Size(96, 42);
            viewCurrentMenu.TabIndex = 11;
            viewCurrentMenu.Text = "View current Menu";
            viewCurrentMenu.UseVisualStyleBackColor = true;
            viewCurrentMenu.Click += viewCurrentMenu_Click;
            // 
            // roundPictureBox1
            // 
            roundPictureBox1.BorderStyle = BorderStyle.Fixed3D;
            roundPictureBox1.Image = (Image)resources.GetObject("roundPictureBox1.Image");
            roundPictureBox1.Location = new Point(9, 8);
            roundPictureBox1.Margin = new Padding(2, 1, 2, 1);
            roundPictureBox1.Name = "roundPictureBox1";
            roundPictureBox1.Size = new Size(83, 72);
            roundPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            roundPictureBox1.TabIndex = 10;
            roundPictureBox1.TabStop = false;
            // 
            // ordersButton
            // 
            ordersButton.Location = new Point(2, 132);
            ordersButton.Margin = new Padding(2, 1, 2, 1);
            ordersButton.Name = "ordersButton";
            ordersButton.Size = new Size(96, 42);
            ordersButton.TabIndex = 9;
            ordersButton.Text = "Incoming Orders";
            ordersButton.UseVisualStyleBackColor = true;
            ordersButton.Click += ordersButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(2, 511);
            exitButton.Margin = new Padding(2, 1, 2, 1);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(96, 42);
            exitButton.TabIndex = 8;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // settingButton
            // 
            settingButton.Location = new Point(2, 308);
            settingButton.Margin = new Padding(2, 1, 2, 1);
            settingButton.Name = "settingButton";
            settingButton.Size = new Size(96, 42);
            settingButton.TabIndex = 2;
            settingButton.Text = "Setting";
            settingButton.UseVisualStyleBackColor = true;
            settingButton.Click += settingButton_Click;
            // 
            // resturantProfileButton
            // 
            resturantProfileButton.Location = new Point(2, 264);
            resturantProfileButton.Margin = new Padding(2, 1, 2, 1);
            resturantProfileButton.Name = "resturantProfileButton";
            resturantProfileButton.Size = new Size(96, 42);
            resturantProfileButton.TabIndex = 1;
            resturantProfileButton.Text = "Resturant Profile";
            resturantProfileButton.UseVisualStyleBackColor = true;
            resturantProfileButton.Click += resturantProfileButton_Click;
            // 
            // editMenu
            // 
            editMenu.Location = new Point(2, 221);
            editMenu.Margin = new Padding(2, 1, 2, 1);
            editMenu.Name = "editMenu";
            editMenu.Size = new Size(96, 42);
            editMenu.TabIndex = 0;
            editMenu.Text = "Edit Menu";
            editMenu.UseVisualStyleBackColor = true;
            editMenu.Click += editMenu_Click;
            // 
            // nameLabel
            // 
            nameLabel.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameLabel.ForeColor = SystemColors.ControlLight;
            nameLabel.Location = new Point(12, 80);
            nameLabel.Margin = new Padding(2, 0, 2, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(75, 30);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Manager";
            nameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // signOutButton
            // 
            signOutButton.Location = new Point(2, 467);
            signOutButton.Margin = new Padding(2, 1, 2, 1);
            signOutButton.Name = "signOutButton";
            signOutButton.Size = new Size(96, 42);
            signOutButton.TabIndex = 3;
            signOutButton.Text = "Sign Out";
            signOutButton.UseVisualStyleBackColor = true;
            signOutButton.Click += signOutButton_Click;
            // 
            // mainpanel1
            // 
            mainpanel1.AutoSize = true;
            mainpanel1.BackColor = Color.FromArgb(0, 4, 120, 65);
            mainpanel1.Location = new Point(104, 0);
            mainpanel1.Name = "mainpanel1";
            mainpanel1.Size = new Size(879, 562);
            mainpanel1.TabIndex = 3;
            // 
            // ManagerMainPageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(mainpanel1);
            Controls.Add(MenuSideBar);
            Name = "ManagerMainPageForm";
            Text = "ManagerMainPageForm";
            MenuSideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel MenuSideBar;
        private Button exitButton;
        private RoundPictureBox roundPictureBox1;
        private Button settingButton;
        private Button resturantProfileButton;
        private Button editMenu;
        private Label nameLabel;
        private Button signOutButton;
        private Panel mainpanel1;
        private Button ordersButton;
        private Button viewCurrentMenu;
    }
}