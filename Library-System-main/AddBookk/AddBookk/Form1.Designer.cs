namespace AddBookk
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            isbn = new TextBox();
            price = new TextBox();
            title = new TextBox();
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
            pictureBox1.Location = new Point(127, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 103);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // isbn
            // 
            isbn.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            isbn.Location = new Point(43, 154);
            isbn.Name = "isbn";
            isbn.Size = new Size(286, 28);
            isbn.TabIndex = 2;
            isbn.Text = "ISBN...";
            isbn.MouseClick += isbn_MouseClick;
            // 
            // price
            // 
            price.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            price.Location = new Point(43, 261);
            price.Name = "price";
            price.Size = new Size(286, 28);
            price.TabIndex = 3;
            price.Text = "price...";
            price.MouseClick += price_MouseClick;
            // 
            // title
            // 
            title.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.Location = new Point(43, 210);
            title.Name = "title";
            title.Size = new Size(286, 28);
            title.TabIndex = 4;
            title.Text = "Title...";
            title.MouseClick += title_MouseClick;
            // 
            // sum
            // 
            sum.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sum.Location = new Point(43, 309);
            sum.Name = "sum";
            sum.Size = new Size(286, 28);
            sum.TabIndex = 5;
            sum.Text = "summary";
            sum.MouseClick += sum_MouseClick;
            // 
            // pyear
            // 
            pyear.Font = new Font("Calibri", 10.2F, FontStyle.Bold);
            pyear.Location = new Point(43, 361);
            pyear.Name = "pyear";
            pyear.Size = new Size(286, 28);
            pyear.TabIndex = 6;
            pyear.Text = "publication year...";
            pyear.MouseClick += pyear_MouseClick;
            pyear.TextChanged += pyear_TextChanged;
            // 
            // ed
            // 
            ed.Font = new Font("Calibri", 10.2F, FontStyle.Bold);
            ed.Location = new Point(43, 406);
            ed.Name = "ed";
            ed.Size = new Size(286, 28);
            ed.TabIndex = 7;
            ed.Text = "edition...";
            ed.MouseClick += ed_MouseClick;
            // 
            // aid
            // 
            aid.Font = new Font("Calibri", 10.2F, FontStyle.Bold);
            aid.Location = new Point(43, 455);
            aid.Name = "aid";
            aid.Size = new Size(286, 28);
            aid.TabIndex = 9;
            aid.Text = "auther id...";
            aid.MouseClick += aid_MouseClick;
            // 
            // cid
            // 
            cid.Font = new Font("Calibri", 10.2F, FontStyle.Bold);
            cid.Location = new Point(43, 505);
            cid.Name = "cid";
            cid.Size = new Size(286, 28);
            cid.TabIndex = 10;
            cid.Text = "category id...";
            cid.MouseClick += cid_MouseClick;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGreen;
            button1.CausesValidation = false;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(105, 571);
            button1.Name = "button1";
            button1.Size = new Size(142, 59);
            button1.TabIndex = 11;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
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
            Controls.Add(title);
            Controls.Add(price);
            Controls.Add(isbn);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "ADD BOOK";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox isbn;
        private TextBox price;
        private TextBox title;
        private TextBox sum;
        private TextBox pyear;
        private TextBox ed;
        private TextBox cp;
        private TextBox aid;
        private TextBox cid;
        private Button button1;
    }
}
