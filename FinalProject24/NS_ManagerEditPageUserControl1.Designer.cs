namespace FinalProject24
{
    partial class NS_ManagerEditPageUserControl1
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
            Applybutton = new Button();
            Addbutton = new Button();
            RemoveButton = new Button();
            listView1 = new ListView();
            Item = new ColumnHeader();
            Price = new ColumnHeader();
            Availability = new ColumnHeader();
            Clearbutton = new Button();
            Countbutton = new Button();
            SuspendLayout();
            // 
            // Applybutton
            // 
            Applybutton.Location = new Point(370, 552);
            Applybutton.Name = "Applybutton";
            Applybutton.Size = new Size(112, 34);
            Applybutton.TabIndex = 0;
            Applybutton.Text = "Apply";
            Applybutton.UseVisualStyleBackColor = true;
            // 
            // Addbutton
            // 
            Addbutton.Location = new Point(751, 43);
            Addbutton.Name = "Addbutton";
            Addbutton.Size = new Size(112, 34);
            Addbutton.TabIndex = 2;
            Addbutton.Text = "Add";
            Addbutton.UseVisualStyleBackColor = true;
            Addbutton.Click += Addbutton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Location = new Point(751, 101);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(112, 34);
            RemoveButton.TabIndex = 3;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Item, Price, Availability });
            listView1.FullRowSelect = true;
            listView1.Location = new Point(18, 16);
            listView1.Name = "listView1";
            listView1.Size = new Size(705, 384);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // Item
            // 
            Item.Text = "Item";
            Item.Width = 150;
            // 
            // Price
            // 
            Price.Text = "Price";
            Price.Width = 100;
            // 
            // Availability
            // 
            Availability.Text = "Availability";
            Availability.Width = 200;
            // 
            // Clearbutton
            // 
            Clearbutton.Location = new Point(751, 215);
            Clearbutton.Name = "Clearbutton";
            Clearbutton.Size = new Size(112, 34);
            Clearbutton.TabIndex = 6;
            Clearbutton.Text = "Clear";
            Clearbutton.UseVisualStyleBackColor = true;
            Clearbutton.Click += Clearbutton_Click;
            // 
            // Countbutton
            // 
            Countbutton.Location = new Point(751, 157);
            Countbutton.Name = "Countbutton";
            Countbutton.Size = new Size(112, 34);
            Countbutton.TabIndex = 5;
            Countbutton.Text = "Count";
            Countbutton.UseVisualStyleBackColor = true;
            Countbutton.Click += Countbutton_Click;
            // 
            // NS_ManagerEditPageUserControl1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Clearbutton);
            Controls.Add(Countbutton);
            Controls.Add(listView1);
            Controls.Add(RemoveButton);
            Controls.Add(Addbutton);
            Controls.Add(Applybutton);
            Margin = new Padding(4, 5, 4, 5);
            Name = "NS_ManagerEditPageUserControl1";
            Size = new Size(900, 600);
            ResumeLayout(false);
        }

        #endregion

        private Button Applybutton;
        private Button Addbutton;
        private Button RemoveButton;
        private ListView listView1;
        private Button Clearbutton;
        private Button Countbutton;
        private ColumnHeader Item;
        private ColumnHeader Price;
        private ColumnHeader Availability;
    }
}
