namespace AddBookk
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            menuStrip1 = new MenuStrip();
            addBookToolStripMenuItem = new ToolStripMenuItem();
            addBookToolStripMenuItem1 = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            editBookToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            viewBooksToolStripMenuItem = new ToolStripMenuItem();
            borrowToolStripMenuItem = new ToolStripMenuItem();
            borrowBookToolStripMenuItem = new ToolStripMenuItem();
            returnToolStripMenuItem = new ToolStripMenuItem();
            returnBookToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            deleteBookToolStripMenuItem = new ToolStripMenuItem();
            eXITToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Wheat;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { addBookToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem, borrowToolStripMenuItem, returnToolStripMenuItem, exitToolStripMenuItem, eXITToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1289, 72);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // addBookToolStripMenuItem
            // 
            addBookToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addBookToolStripMenuItem1 });
            addBookToolStripMenuItem.Image = (Image)resources.GetObject("addBookToolStripMenuItem.Image");
            addBookToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            addBookToolStripMenuItem.Name = "addBookToolStripMenuItem";
            addBookToolStripMenuItem.Size = new Size(99, 68);
            addBookToolStripMenuItem.Text = "Add";
            // 
            // addBookToolStripMenuItem1
            // 
            addBookToolStripMenuItem1.Image = (Image)resources.GetObject("addBookToolStripMenuItem1.Image");
            addBookToolStripMenuItem1.ImageScaling = ToolStripItemImageScaling.None;
            addBookToolStripMenuItem1.Name = "addBookToolStripMenuItem1";
            addBookToolStripMenuItem1.Size = new Size(186, 54);
            addBookToolStripMenuItem1.Text = "Add Book";
            addBookToolStripMenuItem1.Click += addBookToolStripMenuItem1_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.BackColor = Color.OldLace;
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { editBookToolStripMenuItem });
            editToolStripMenuItem.Image = (Image)resources.GetObject("editToolStripMenuItem.Image");
            editToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(99, 68);
            editToolStripMenuItem.Text = "Edit";
            // 
            // editBookToolStripMenuItem
            // 
            editBookToolStripMenuItem.Image = (Image)resources.GetObject("editBookToolStripMenuItem.Image");
            editBookToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            editBookToolStripMenuItem.Name = "editBookToolStripMenuItem";
            editBookToolStripMenuItem.Size = new Size(186, 56);
            editBookToolStripMenuItem.Text = "Edit Book";
            editBookToolStripMenuItem.Click += editBookToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewBooksToolStripMenuItem });
            viewToolStripMenuItem.Image = (Image)resources.GetObject("viewToolStripMenuItem.Image");
            viewToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(119, 68);
            viewToolStripMenuItem.Text = "View";
            viewToolStripMenuItem.Click += viewToolStripMenuItem_Click;
            // 
            // viewBooksToolStripMenuItem
            // 
            viewBooksToolStripMenuItem.Image = (Image)resources.GetObject("viewBooksToolStripMenuItem.Image");
            viewBooksToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            viewBooksToolStripMenuItem.Name = "viewBooksToolStripMenuItem";
            viewBooksToolStripMenuItem.Size = new Size(212, 70);
            viewBooksToolStripMenuItem.Text = "View Books";
            viewBooksToolStripMenuItem.Click += viewBooksToolStripMenuItem_Click;
            // 
            // borrowToolStripMenuItem
            // 
            borrowToolStripMenuItem.BackColor = Color.OldLace;
            borrowToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { borrowBookToolStripMenuItem });
            borrowToolStripMenuItem.Image = (Image)resources.GetObject("borrowToolStripMenuItem.Image");
            borrowToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            borrowToolStripMenuItem.Name = "borrowToolStripMenuItem";
            borrowToolStripMenuItem.Size = new Size(121, 68);
            borrowToolStripMenuItem.Text = "Borrow";
            // 
            // borrowBookToolStripMenuItem
            // 
            borrowBookToolStripMenuItem.Image = (Image)resources.GetObject("borrowBookToolStripMenuItem.Image");
            borrowBookToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            borrowBookToolStripMenuItem.Name = "borrowBookToolStripMenuItem";
            borrowBookToolStripMenuItem.Size = new Size(254, 56);
            borrowBookToolStripMenuItem.Text = "Borrow Book";
            borrowBookToolStripMenuItem.Click += borrowBookToolStripMenuItem_Click;
            // 
            // returnToolStripMenuItem
            // 
            returnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { returnBookToolStripMenuItem });
            returnToolStripMenuItem.Image = (Image)resources.GetObject("returnToolStripMenuItem.Image");
            returnToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            returnToolStripMenuItem.Size = new Size(116, 68);
            returnToolStripMenuItem.Text = "Return";
            // 
            // returnBookToolStripMenuItem
            // 
            returnBookToolStripMenuItem.Image = (Image)resources.GetObject("returnBookToolStripMenuItem.Image");
            returnBookToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            returnBookToolStripMenuItem.Name = "returnBookToolStripMenuItem";
            returnBookToolStripMenuItem.Size = new Size(203, 56);
            returnBookToolStripMenuItem.Text = "Return Book";
            returnBookToolStripMenuItem.Click += returnBookToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.BackColor = Color.OldLace;
            exitToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { deleteBookToolStripMenuItem });
            exitToolStripMenuItem.Image = (Image)resources.GetObject("exitToolStripMenuItem.Image");
            exitToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(117, 68);
            exitToolStripMenuItem.Text = "Delete";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click_1;
            // 
            // deleteBookToolStripMenuItem
            // 
            deleteBookToolStripMenuItem.Image = (Image)resources.GetObject("deleteBookToolStripMenuItem.Image");
            deleteBookToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            deleteBookToolStripMenuItem.Name = "deleteBookToolStripMenuItem";
            deleteBookToolStripMenuItem.Size = new Size(254, 56);
            deleteBookToolStripMenuItem.Text = "Delete Book";
            deleteBookToolStripMenuItem.Click += deleteBookToolStripMenuItem_Click;
            // 
            // eXITToolStripMenuItem1
            // 
            eXITToolStripMenuItem1.Image = (Image)resources.GetObject("eXITToolStripMenuItem1.Image");
            eXITToolStripMenuItem1.ImageScaling = ToolStripItemImageScaling.None;
            eXITToolStripMenuItem1.Name = "eXITToolStripMenuItem1";
            eXITToolStripMenuItem1.Size = new Size(102, 68);
            eXITToolStripMenuItem1.Text = "EXIT";
            eXITToolStripMenuItem1.Click += eXITToolStripMenuItem1_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1289, 641);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Home";
            Text = "Home";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem addBookToolStripMenuItem;
        private ToolStripMenuItem addBookToolStripMenuItem1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem editBookToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem viewBooksToolStripMenuItem;
        private ToolStripMenuItem borrowToolStripMenuItem;
        private ToolStripMenuItem borrowBookToolStripMenuItem;
        private ToolStripMenuItem returnToolStripMenuItem;
        private ToolStripMenuItem returnBookToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem deleteBookToolStripMenuItem;
        private ToolStripMenuItem eXITToolStripMenuItem1;
    }
}