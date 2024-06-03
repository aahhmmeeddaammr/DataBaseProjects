namespace AddBookk
{
    partial class EditBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditBook));
            pictureBox1 = new PictureBox();
            isbn = new TextBox();
            title = new TextBox();
            price = new TextBox();
            sum = new TextBox();
            pyear = new TextBox();
            ed = new TextBox();
            aid = new TextBox();
            cid = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(114, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(146, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // isbn
            // 
            isbn.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            isbn.Location = new Point(39, 144);
            isbn.Name = "isbn";
            isbn.ReadOnly = true;
            isbn.Size = new Size(286, 28);
            isbn.TabIndex = 3;
            isbn.Text = "ISBN...";
            isbn.MouseClick += isbn_MouseClick;
            isbn.TextChanged += isbn_TextChanged;
            // 
            // title
            // 
            title.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.Location = new Point(39, 191);
            title.Name = "title";
            title.Size = new Size(286, 28);
            title.TabIndex = 5;
            title.Text = "Title...";
            // 
            // price
            // 
            price.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            price.Location = new Point(39, 242);
            price.Name = "price";
            price.Size = new Size(286, 28);
            price.TabIndex = 6;
            price.Text = "price...";
            // 
            // sum
            // 
            sum.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sum.Location = new Point(39, 293);
            sum.Name = "sum";
            sum.Size = new Size(286, 28);
            sum.TabIndex = 7;
            sum.Text = "summary";
            // 
            // pyear
            // 
            pyear.Font = new Font("Calibri", 10.2F, FontStyle.Bold);
            pyear.Location = new Point(39, 337);
            pyear.Name = "pyear";
            pyear.Size = new Size(286, 28);
            pyear.TabIndex = 8;
            pyear.Text = "publication year...";
            // 
            // ed
            // 
            ed.Font = new Font("Calibri", 10.2F, FontStyle.Bold);
            ed.Location = new Point(39, 392);
            ed.Name = "ed";
            ed.Size = new Size(286, 28);
            ed.TabIndex = 9;
            ed.Text = "edition...";
            // 
            // aid
            // 
            aid.Font = new Font("Calibri", 10.2F, FontStyle.Bold);
            aid.Location = new Point(39, 437);
            aid.Name = "aid";
            aid.Size = new Size(286, 28);
            aid.TabIndex = 11;
            aid.Text = "auther id...";
            // 
            // cid
            // 
            cid.Font = new Font("Calibri", 10.2F, FontStyle.Bold);
            cid.Location = new Point(39, 488);
            cid.Name = "cid";
            cid.Size = new Size(286, 28);
            cid.TabIndex = 12;
            cid.Text = "category id...";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGreen;
            button1.CausesValidation = false;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(103, 570);
            button1.Name = "button1";
            button1.Size = new Size(142, 59);
            button1.TabIndex = 13;
            button1.Text = "EDIT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // EditBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(382, 653);
            Controls.Add(button1);
            Controls.Add(cid);
            Controls.Add(aid);
            Controls.Add(ed);
            Controls.Add(pyear);
            Controls.Add(sum);
            Controls.Add(price);
            Controls.Add(title);
            Controls.Add(isbn);
            Controls.Add(pictureBox1);
            Name = "EditBook";
            Text = "EditBook";
            Load += EditBook_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox isbn;
        private TextBox title;
        private TextBox price;
        private TextBox sum;
        private TextBox pyear;
        private TextBox ed;
        private TextBox aid;
        private TextBox cid;
        private Button button1;
    }
}