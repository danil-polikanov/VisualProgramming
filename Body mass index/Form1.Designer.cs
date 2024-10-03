namespace Body_mass_index
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
            ResultBox = new TextBox();
            Calculate = new Button();
            label1 = new Label();
            label2 = new Label();
            WeightText = new TextBox();
            HeightText = new TextBox();
            SuspendLayout();
            // 
            // ResultBox
            // 
            ResultBox.BackColor = SystemColors.Control;
            ResultBox.BorderStyle = BorderStyle.FixedSingle;
            ResultBox.Enabled = false;
            ResultBox.Location = new Point(12, 128);
            ResultBox.Multiline = true;
            ResultBox.Name = "ResultBox";
            ResultBox.Size = new Size(327, 70);
            ResultBox.TabIndex = 0;
            ResultBox.TextChanged += ResultBox_TextChanged;
            // 
            // Calculate
            // 
            Calculate.Location = new Point(255, 62);
            Calculate.Name = "Calculate";
            Calculate.Size = new Size(75, 23);
            Calculate.TabIndex = 1;
            Calculate.Text = "button1";
            Calculate.UseVisualStyleBackColor = true;
            Calculate.Click += Calculate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 3;
            label1.Text = "Weight (pounds):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 4;
            label2.Text = "Height (inches):";
            // 
            // WeightText
            // 
            WeightText.Location = new Point(117, 18);
            WeightText.Name = "WeightText";
            WeightText.Size = new Size(112, 23);
            WeightText.TabIndex = 5;
            WeightText.TextChanged += WeightText_TextChanged;
            // 
            // HeightText
            // 
            HeightText.Location = new Point(117, 59);
            HeightText.Name = "HeightText";
            HeightText.Size = new Size(112, 23);
            HeightText.TabIndex = 6;
            HeightText.TextChanged += HeightText_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 210);
            Controls.Add(HeightText);
            Controls.Add(WeightText);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Calculate);
            Controls.Add(ResultBox);
            Name = "Form1";
            Text = "IMB";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ResultBox;
        private Button Calculate;
        private Label label1;
        private Label label2;
        private TextBox WeightText;
        private TextBox HeightText;
    }
}
