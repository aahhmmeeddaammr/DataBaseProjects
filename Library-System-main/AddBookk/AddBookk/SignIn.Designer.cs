namespace AddBookk
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            textBox3 = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            panel3 = new Panel();
            panel1 = new Panel();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.AccessibleDescription = "";
            textBox3.BackColor = Color.Lime;
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Cursor = Cursors.Hand;
            textBox3.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.ForeColor = SystemColors.ControlLightLight;
            textBox3.Location = new Point(92, 173);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(244, 28);
            textBox3.TabIndex = 19;
            textBox3.Visible = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(41, 337);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(45, 42);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(41, 235);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 52);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.DodgerBlue;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.AliceBlue;
            button2.Location = new Point(82, 503);
            button2.Name = "button2";
            button2.Size = new Size(244, 53);
            button2.TabIndex = 16;
            button2.Text = "SignUp";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(92, 368);
            panel3.Name = "panel3";
            panel3.Size = new Size(244, 5);
            panel3.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(92, 279);
            panel1.Name = "panel1";
            panel1.Size = new Size(244, 5);
            panel1.TabIndex = 14;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.AliceBlue;
            button1.Location = new Point(82, 419);
            button1.Name = "button1";
            button1.Size = new Size(244, 53);
            button1.TabIndex = 13;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.SteelBlue;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Cursor = Cursors.Hand;
            textBox2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.ForeColor = SystemColors.InactiveBorder;
            textBox2.Location = new Point(92, 337);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(244, 25);
            textBox2.TabIndex = 12;
            textBox2.Text = "Password...";
            textBox2.MouseClick += textBox2_MouseClick;
            // 
            // textBox1
            // 
            textBox1.AccessibleDescription = "";
            textBox1.BackColor = Color.SteelBlue;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Cursor = Cursors.Hand;
            textBox1.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.ControlLightLight;
            textBox1.Location = new Point(92, 245);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(244, 28);
            textBox1.TabIndex = 11;
            textBox1.Text = "USER Email...";
            textBox1.MouseClick += textBox1_MouseClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(136, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 131);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // SignIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(444, 676);
            Controls.Add(textBox3);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(button2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Name = "SignIn";
            Text = "SignIn";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox3;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Button button2;
        private Panel panel3;
        private Panel panel1;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private PictureBox pictureBox1;
    }
}