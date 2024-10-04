namespace Driver_s_License_exam
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
            UploadExam = new Button();
            Answer = new ListBox();
            ResultExam = new Label();
            SuspendLayout();
            // 
            // UploadExam
            // 
            UploadExam.Location = new Point(351, 338);
            UploadExam.Name = "UploadExam";
            UploadExam.Size = new Size(75, 40);
            UploadExam.TabIndex = 0;
            UploadExam.Text = "Upload a file";
            UploadExam.UseVisualStyleBackColor = true;
            UploadExam.Click += UploadExam_Click;
            // 
            // Answer
            // 
            Answer.FormattingEnabled = true;
            Answer.ItemHeight = 15;
            Answer.Location = new Point(114, 171);
            Answer.Name = "Answer";
            Answer.Size = new Size(574, 124);
            Answer.TabIndex = 1;
            Answer.Visible = false;
            Answer.SelectedIndexChanged += Answer_SelectedIndexChanged;
            // 
            // ResultExam
            // 
            ResultExam.AutoSize = true;
            ResultExam.Location = new Point(364, 115);
            ResultExam.Name = "ResultExam";
            ResultExam.Size = new Size(0, 15);
            ResultExam.TabIndex = 2;
            ResultExam.Visible = false;
            ResultExam.Click += ResultExam_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ResultExam);
            Controls.Add(Answer);
            Controls.Add(UploadExam);
            Name = "Form1";
            Text = "Driver's License Exam";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button UploadExam;
        private ListBox Answer;
        private Label ResultExam;
    }
}
