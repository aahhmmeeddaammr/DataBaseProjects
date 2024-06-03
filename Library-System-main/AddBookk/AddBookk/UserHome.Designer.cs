namespace AddBookk
{
    partial class UserHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserHome));
            menuStrip1 = new MenuStrip();
            viewToolStripMenuItem = new ToolStripMenuItem();
            viewBooksToolStripMenuItem = new ToolStripMenuItem();
            borrowToolStripMenuItem = new ToolStripMenuItem();
            borrowBookToolStripMenuItem = new ToolStripMenuItem();
            returnToolStripMenuItem = new ToolStripMenuItem();
            returnBookToolStripMenuItem = new ToolStripMenuItem();
            eXITToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Wheat;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { viewToolStripMenuItem, borrowToolStripMenuItem, returnToolStripMenuItem, eXITToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1104, 72);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewBooksToolStripMenuItem });
            viewToolStripMenuItem.Image = (Image)resources.GetObject("viewToolStripMenuItem.Image");
            viewToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(119, 68);
            viewToolStripMenuItem.Text = "View";
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
            borrowBookToolStripMenuItem.Size = new Size(208, 56);
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
            returnToolStripMenuItem.Click += returnToolStripMenuItem_Click;
            // 
            // returnBookToolStripMenuItem
            // 
            returnBookToolStripMenuItem.Image = (Image)resources.GetObject("returnBookToolStripMenuItem.Image");
            returnBookToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            returnBookToolStripMenuItem.Name = "returnBookToolStripMenuItem";
            returnBookToolStripMenuItem.Size = new Size(254, 56);
            returnBookToolStripMenuItem.Text = "Return Book";
            returnBookToolStripMenuItem.Click += returnBookToolStripMenuItem_Click;
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
            // UserHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1104, 679);
            Controls.Add(menuStrip1);
            Name = "UserHome";
            Text = "UserHome";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem viewBooksToolStripMenuItem;
        private ToolStripMenuItem borrowToolStripMenuItem;
        private ToolStripMenuItem borrowBookToolStripMenuItem;
        private ToolStripMenuItem returnToolStripMenuItem;
        private ToolStripMenuItem returnBookToolStripMenuItem;
        private ToolStripMenuItem eXITToolStripMenuItem1;
    }
}