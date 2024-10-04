namespace GuessingGameNumber
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
            PlayerNumber = new NumericUpDown();
            ChoiceButton = new Button();
            Result = new Label();
            ((System.ComponentModel.ISupportInitialize)PlayerNumber).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(244, 45);
            label1.Name = "label1";
            label1.Size = new Size(182, 17);
            label1.TabIndex = 0;
            label1.Text = "Guess number 1 throught 100";
            // 
            // PlayerNumber
            // 
            PlayerNumber.Location = new Point(244, 84);
            PlayerNumber.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            PlayerNumber.Name = "PlayerNumber";
            PlayerNumber.Size = new Size(120, 23);
            PlayerNumber.TabIndex = 2;
            PlayerNumber.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // ChoiceButton
            // 
            ChoiceButton.Location = new Point(385, 84);
            ChoiceButton.Name = "ChoiceButton";
            ChoiceButton.Size = new Size(75, 23);
            ChoiceButton.TabIndex = 3;
            ChoiceButton.Text = "Try out";
            ChoiceButton.UseVisualStyleBackColor = true;
            ChoiceButton.Click += ChoiceButton_Click;
            // 
            // Result
            // 
            Result.AutoSize = true;
            Result.BackColor = SystemColors.ButtonHighlight;
            Result.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Result.Location = new Point(244, 132);
            Result.Name = "Result";
            Result.Size = new Size(53, 21);
            Result.TabIndex = 4;
            Result.Text = "Result";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 362);
            Controls.Add(Result);
            Controls.Add(ChoiceButton);
            Controls.Add(PlayerNumber);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Guess Number";
            ((System.ComponentModel.ISupportInitialize)PlayerNumber).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown PlayerNumber;
        private Button ChoiceButton;
        private Label Result;
    }
}
