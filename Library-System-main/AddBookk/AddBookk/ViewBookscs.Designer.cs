namespace AddBookk
{
    partial class ViewBookscs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBookscs));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            text = new Label();
            name = new TextBox();
            view = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1227, 178);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(649, 72);
            label1.Name = "label1";
            label1.Size = new Size(123, 28);
            label1.TabIndex = 1;
            label1.Text = "View Books";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(467, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(237, 174);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // text
            // 
            text.AutoSize = true;
            text.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            text.ForeColor = Color.White;
            text.Location = new Point(274, 224);
            text.Name = "text";
            text.Size = new Size(163, 35);
            text.TabIndex = 1;
            text.Text = "Book Name: ";
            // 
            // name
            // 
            name.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            name.Location = new Point(453, 227);
            name.Name = "name";
            name.Size = new Size(299, 32);
            name.TabIndex = 2;
            // 
            // view
            // 
            view.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            view.Location = new Point(793, 224);
            view.Name = "view";
            view.Size = new Size(111, 40);
            view.TabIndex = 3;
            view.Text = "View";
            view.UseVisualStyleBackColor = true;
            view.Click += view_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 285);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1238, 344);
            dataGridView1.TabIndex = 4;
            // 
            // ViewBookscs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(1262, 641);
            Controls.Add(dataGridView1);
            Controls.Add(view);
            Controls.Add(name);
            Controls.Add(text);
            Controls.Add(panel1);
            Name = "ViewBookscs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewBookscs";
            Load += ViewBookscs_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label text;
        private TextBox name;
        private Button view;
        private DataGridView dataGridView1;
    }
}