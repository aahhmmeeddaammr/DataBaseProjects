namespace AddBookk
{
    partial class BorrowBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowBook));
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            box = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            bookname = new Label();
            btn = new Button();
            search = new Button();
            book = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(617, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(734, 609);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(box);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(bookname);
            panel1.Controls.Add(btn);
            panel1.Controls.Add(search);
            panel1.Controls.Add(book);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(26, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(575, 609);
            panel1.TabIndex = 3;
            // 
            // box
            // 
            box.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            box.Location = new Point(14, 219);
            box.Name = "box";
            box.Size = new Size(531, 32);
            box.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 192);
            label2.Name = "label2";
            label2.Size = new Size(121, 24);
            label2.TabIndex = 7;
            label2.Text = "Enter your ID";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(14, 454);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(282, 32);
            textBox1.TabIndex = 6;
            // 
            // bookname
            // 
            bookname.AutoSize = true;
            bookname.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bookname.Location = new Point(14, 423);
            bookname.Name = "bookname";
            bookname.Size = new Size(133, 28);
            bookname.TabIndex = 5;
            bookname.Text = "Book Name: ";
            // 
            // btn
            // 
            btn.BackColor = SystemColors.Highlight;
            btn.FlatStyle = FlatStyle.Popup;
            btn.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn.Location = new Point(227, 517);
            btn.Name = "btn";
            btn.Size = new Size(118, 49);
            btn.TabIndex = 4;
            btn.Text = "Borrow";
            btn.UseVisualStyleBackColor = false;
            btn.Click += btn_Click;
            // 
            // search
            // 
            search.BackColor = SystemColors.Highlight;
            search.BackgroundImageLayout = ImageLayout.None;
            search.FlatStyle = FlatStyle.Popup;
            search.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            search.Location = new Point(227, 352);
            search.Name = "search";
            search.Size = new Size(118, 48);
            search.TabIndex = 3;
            search.Text = "Search";
            search.UseVisualStyleBackColor = false;
            search.Click += search_Click;
            // 
            // book
            // 
            book.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            book.Location = new Point(14, 314);
            book.Name = "book";
            book.Size = new Size(531, 32);
            book.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 278);
            label1.Name = "label1";
            label1.Size = new Size(243, 24);
            label1.TabIndex = 1;
            label1.Text = "Enter the name of the book";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(211, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 153);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(371, 423);
            label3.Name = "label3";
            label3.Size = new Size(92, 28);
            label3.TabIndex = 9;
            label3.Text = "BookID: ";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(313, 454);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(232, 32);
            textBox2.TabIndex = 10;
            // 
            // BorrowBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(1363, 626);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "BorrowBook";
            Text = "BorrowBook";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private Panel panel1;
        private TextBox box;
        private Label label2;
        private TextBox textBox1;
        private Label bookname;
        private Button btn;
        private Button search;
        private TextBox book;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox textBox2;
        private Label label3;
    }
}