namespace RockPaper_Scissors
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
            menuStrip1 = new MenuStrip();
            RockPicture = new PictureBox();
            PaperPicture = new PictureBox();
            ScissorsPictures = new PictureBox();
            PlayerChoice = new PictureBox();
            ComputerChoice = new PictureBox();
            ResultText = new Label();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)RockPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PaperPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ScissorsPictures).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PlayerChoice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ComputerChoice).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // RockPicture
            // 
            RockPicture.BackColor = SystemColors.Control;
            RockPicture.BackgroundImage = Properties.Resources.rock;
            RockPicture.InitialImage = null;
            RockPicture.Location = new Point(161, 48);
            RockPicture.Name = "RockPicture";
            RockPicture.Size = new Size(98, 101);
            RockPicture.SizeMode = PictureBoxSizeMode.Zoom;
            RockPicture.TabIndex = 1;
            RockPicture.TabStop = false;
            RockPicture.Click += RockPicture_Click;
            // 
            // PaperPicture
            // 
            PaperPicture.BackgroundImage = Properties.Resources.paper;
            PaperPicture.InitialImage = null;
            PaperPicture.Location = new Point(341, 48);
            PaperPicture.Name = "PaperPicture";
            PaperPicture.Size = new Size(94, 101);
            PaperPicture.TabIndex = 2;
            PaperPicture.TabStop = false;
            PaperPicture.Click += PaperPicture_Click;
            // 
            // ScissorsPictures
            // 
            ScissorsPictures.BackgroundImage = Properties.Resources.scissors;
            ScissorsPictures.InitialImage = null;
            ScissorsPictures.Location = new Point(511, 48);
            ScissorsPictures.Name = "ScissorsPictures";
            ScissorsPictures.Size = new Size(100, 101);
            ScissorsPictures.TabIndex = 3;
            ScissorsPictures.TabStop = false;
            ScissorsPictures.Click += ScissorsPictures_Click;
            // 
            // PlayerChoice
            // 
            PlayerChoice.Location = new Point(195, 257);
            PlayerChoice.Name = "PlayerChoice";
            PlayerChoice.Size = new Size(98, 98);
            PlayerChoice.TabIndex = 4;
            PlayerChoice.TabStop = false;
            PlayerChoice.Visible = false;
            PlayerChoice.Click += PlayerChoice_Click;
            // 
            // ComputerChoice
            // 
            ComputerChoice.Location = new Point(439, 257);
            ComputerChoice.Name = "ComputerChoice";
            ComputerChoice.Size = new Size(98, 98);
            ComputerChoice.TabIndex = 5;
            ComputerChoice.TabStop = false;
            ComputerChoice.Visible = false;
            ComputerChoice.Click += ComputerChoice_Click;
            // 
            // ResultText
            // 
            ResultText.AutoSize = true;
            ResultText.Font = new Font("Snap ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ResultText.Location = new Point(332, 298);
            ResultText.Name = "ResultText";
            ResultText.Size = new Size(60, 22);
            ResultText.TabIndex = 6;
            ResultText.Text = "label1";
            ResultText.Visible = false;
            ResultText.Click += ResultText_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(205, 222);
            label1.Name = "label1";
            label1.Size = new Size(69, 22);
            label1.TabIndex = 7;
            label1.Text = "Player";
            label1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Snap ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(441, 222);
            label2.Name = "label2";
            label2.Size = new Size(96, 22);
            label2.TabIndex = 8;
            label2.Text = "Computer";
            label2.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ResultText);
            Controls.Add(ComputerChoice);
            Controls.Add(PlayerChoice);
            Controls.Add(ScissorsPictures);
            Controls.Add(PaperPicture);
            Controls.Add(RockPicture);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)RockPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)PaperPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)ScissorsPictures).EndInit();
            ((System.ComponentModel.ISupportInitialize)PlayerChoice).EndInit();
            ((System.ComponentModel.ISupportInitialize)ComputerChoice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private PictureBox RockPicture;
        private PictureBox PaperPicture;
        private PictureBox ScissorsPictures;
        private PictureBox PlayerChoice;
        private PictureBox ComputerChoice;
        private Label ResultText;
        private Label label1;
        private Label label2;
    }
}
