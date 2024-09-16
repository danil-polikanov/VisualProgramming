namespace StarsWPF
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
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Снимок_экрана_2024_09_06_231852;
            pictureBox1.Location = new Point(1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(380, 440);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(37, 454);
            button1.Name = "button1";
            button1.Size = new Size(75, 43);
            button1.TabIndex = 1;
            button1.Text = "Show family names";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.Location = new Point(146, 454);
            button2.Name = "button2";
            button2.Size = new Size(75, 43);
            button2.TabIndex = 2;
            button2.Text = "Hide family names";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button3.Location = new Point(252, 454);
            button3.Name = "button3";
            button3.Size = new Size(75, 43);
            button3.TabIndex = 3;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 20);
            label1.Name = "label1";
            label1.Size = new Size(173, 15);
            label1.TabIndex = 4;
            label1.Text = "Anatoliy Hrytsenko grandfather";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 235);
            label2.Name = "label2";
            label2.Size = new Size(121, 15);
            label2.TabIndex = 5;
            label2.Text = "Danylo Polikanov son";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(239, 191);
            label3.Name = "label3";
            label3.Size = new Size(131, 15);
            label3.TabIndex = 6;
            label3.Text = "Andriy Polikanov father";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 181);
            label4.Name = "label4";
            label4.Size = new Size(150, 15);
            label4.TabIndex = 7;
            label4.Text = "Nataliia Polikanova mother";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(203, 56);
            label5.Name = "label5";
            label5.Size = new Size(167, 15);
            label5.TabIndex = 8;
            label5.Text = "Nikolay Polikanov grandfather";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 388);
            label6.Name = "label6";
            label6.Size = new Size(162, 15);
            label6.TabIndex = 9;
            label6.Text = "Nina Hrytsenko grandmother";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(185, 352);
            label7.Name = "label7";
            label7.Size = new Size(185, 15);
            label7.TabIndex = 10;
            label7.Text = "Svetlana Polikanova grandmother";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 509);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
