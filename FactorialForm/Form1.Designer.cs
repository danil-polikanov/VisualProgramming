namespace FactorialForm
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
            label1 = new Label();
            FactorialNum = new TextBox();
            ResultLabel = new Label();
            ResultText = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter a number: ";
            // 
            // FactorialNum
            // 
            FactorialNum.Location = new Point(112, 27);
            FactorialNum.Name = "FactorialNum";
            FactorialNum.Size = new Size(100, 23);
            FactorialNum.TabIndex = 1;
            FactorialNum.TextChanged += FactorialNum_TextChanged;
            // 
            // ResultLabel
            // 
            ResultLabel.AutoSize = true;
            ResultLabel.Location = new Point(12, 74);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.Size = new Size(58, 15);
            ResultLabel.TabIndex = 2;
            ResultLabel.Text = "Factorial: ";
            // 
            // ResultText
            // 
            ResultText.AutoSize = true;
            ResultText.Location = new Point(76, 74);
            ResultText.Name = "ResultText";
            ResultText.Size = new Size(0, 15);
            ResultText.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(76, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(136, 23);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(261, 132);
            Controls.Add(textBox1);
            Controls.Add(ResultText);
            Controls.Add(ResultLabel);
            Controls.Add(FactorialNum);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox FactorialNum;
        private Label ResultLabel;
        private Label ResultText;
        private TextBox textBox1;
    }
}
