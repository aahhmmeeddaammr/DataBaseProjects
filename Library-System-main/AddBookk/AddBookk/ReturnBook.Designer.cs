namespace AddBookk
{
    partial class ReturnBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBook));
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
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(box);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(bookname);
            panel1.Controls.Add(btn);
            panel1.Controls.Add(search);
            panel1.Controls.Add(book);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(343, 614);
            panel1.TabIndex = 0;
            // 
            // box
            // 
            box.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            box.Location = new Point(14, 207);
            box.Name = "box";
            box.Size = new Size(284, 32);
            box.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(99, 180);
            label2.Name = "label2";
            label2.Size = new Size(121, 24);
            label2.TabIndex = 7;
            label2.Text = "Enter your ID";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(14, 503);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(284, 32);
            textBox1.TabIndex = 6;
            // 
            // bookname
            // 
            bookname.AutoSize = true;
            bookname.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bookname.Location = new Point(14, 458);
            bookname.Name = "bookname";
            bookname.Size = new Size(133, 28);
            bookname.TabIndex = 5;
            bookname.Text = "Book Name: ";
            bookname.Click += label2_Click;
            // 
            // btn
            // 
            btn.BackColor = SystemColors.Highlight;
            btn.FlatStyle = FlatStyle.Popup;
            btn.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn.Location = new Point(100, 552);
            btn.Name = "btn";
            btn.Size = new Size(118, 49);
            btn.TabIndex = 4;
            btn.Text = "Return";
            btn.UseVisualStyleBackColor = false;
            btn.Click += btn_Click;
            // 
            // search
            // 
            search.BackColor = SystemColors.Highlight;
            search.BackgroundImageLayout = ImageLayout.None;
            search.FlatStyle = FlatStyle.Popup;
            search.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            search.Location = new Point(100, 367);
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
            book.Location = new Point(14, 315);
            book.Name = "book";
            book.Size = new Size(284, 32);
            book.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 277);
            label1.Name = "label1";
            label1.Size = new Size(243, 24);
            label1.TabIndex = 1;
            label1.Text = "Enter the name of the book";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(90, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 132);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(361, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(622, 614);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // ReturnBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(996, 653);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "ReturnBook";
            Text = "ReturnBook";
            Load += ReturnBook_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private TextBox book;
        private Label label1;
        private PictureBox pictureBox1;
        private Button search;
        private Button btn;
        private Label bookname;
        private TextBox textBox1;
        private TextBox box;
        private Label label2;
    }
}