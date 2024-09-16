namespace Stadium_Seating
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
            CalculatedButton = new Button();
            Clear = new Button();
            Exit = new Button();
            groupBox1 = new GroupBox();
            soldClassC = new TextBox();
            soldClassB = new TextBox();
            soldClassA = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            Total = new TextBox();
            classResultC = new TextBox();
            classResultB = new TextBox();
            classResultA = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // CalculatedButton
            // 
            CalculatedButton.Location = new Point(121, 295);
            CalculatedButton.Name = "CalculatedButton";
            CalculatedButton.Size = new Size(102, 39);
            CalculatedButton.TabIndex = 0;
            CalculatedButton.Text = "Calculate Revenue";
            CalculatedButton.UseVisualStyleBackColor = true;
            CalculatedButton.Click += CalculatedButton_Click;
            // 
            // Clear
            // 
            Clear.Location = new Point(266, 295);
            Clear.Name = "Clear";
            Clear.Size = new Size(97, 39);
            Clear.TabIndex = 1;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // Exit
            // 
            Exit.Location = new Point(415, 295);
            Exit.Name = "Exit";
            Exit.Size = new Size(85, 39);
            Exit.TabIndex = 2;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonFace;
            groupBox1.Controls.Add(soldClassC);
            groupBox1.Controls.Add(soldClassB);
            groupBox1.Controls.Add(soldClassA);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(33, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(257, 229);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tickets Sold";
            groupBox1.UseCompatibleTextRendering = true;
            // 
            // soldClassC
            // 
            soldClassC.Location = new Point(108, 162);
            soldClassC.Name = "soldClassC";
            soldClassC.Size = new Size(124, 22);
            soldClassC.TabIndex = 11;
            soldClassC.TextChanged += soldClassC_TextChanged;
            // 
            // soldClassB
            // 
            soldClassB.Location = new Point(108, 124);
            soldClassB.Name = "soldClassB";
            soldClassB.Size = new Size(124, 22);
            soldClassB.TabIndex = 10;
            soldClassB.TextChanged += soldClassB_TextChanged;
            // 
            // soldClassA
            // 
            soldClassA.Location = new Point(108, 84);
            soldClassA.Name = "soldClassA";
            soldClassA.Size = new Size(124, 22);
            soldClassA.TabIndex = 9;
            soldClassA.TextChanged += soldClassA_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 162);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 8;
            label4.Text = "Class C: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 124);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 7;
            label3.Text = "Class B: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 87);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 6;
            label2.Text = "Class A:";
            // 
            // label1
            // 
            label1.Location = new Point(31, 32);
            label1.Name = "label1";
            label1.Size = new Size(192, 35);
            label1.TabIndex = 5;
            label1.Text = "Enter the number of tickets sold for each class of seats";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ButtonFace;
            groupBox2.Controls.Add(Total);
            groupBox2.Controls.Add(classResultC);
            groupBox2.Controls.Add(classResultB);
            groupBox2.Controls.Add(classResultA);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Enabled = false;
            groupBox2.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox2.ForeColor = SystemColors.ActiveCaptionText;
            groupBox2.Location = new Point(325, 49);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(210, 229);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Revenue Generated";
            groupBox2.UseCompatibleTextRendering = true;
            // 
            // Total
            // 
            Total.BorderStyle = BorderStyle.FixedSingle;
            Total.Enabled = false;
            Total.Location = new Point(97, 165);
            Total.Name = "Total";
            Total.Size = new Size(96, 22);
            Total.TabIndex = 16;
            Total.TextChanged += Total_TextChanged;
            // 
            // classResultC
            // 
            classResultC.BorderStyle = BorderStyle.FixedSingle;
            classResultC.Enabled = false;
            classResultC.Location = new Point(97, 117);
            classResultC.Name = "classResultC";
            classResultC.Size = new Size(98, 22);
            classResultC.TabIndex = 15;
            classResultC.TextChanged += classResultC_TextChanged;
            // 
            // classResultB
            // 
            classResultB.BorderStyle = BorderStyle.FixedSingle;
            classResultB.Location = new Point(97, 84);
            classResultB.Name = "classResultB";
            classResultB.Size = new Size(96, 22);
            classResultB.TabIndex = 14;
            classResultB.TextChanged += classResultB_TextChanged;
            // 
            // classResultA
            // 
            classResultA.BorderStyle = BorderStyle.FixedSingle;
            classResultA.Enabled = false;
            classResultA.Location = new Point(97, 49);
            classResultA.Name = "classResultA";
            classResultA.Size = new Size(96, 22);
            classResultA.TabIndex = 13;
            classResultA.TextChanged += classResultA_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(50, 172);
            label8.Name = "label8";
            label8.Size = new Size(40, 15);
            label8.TabIndex = 12;
            label8.Text = "Total: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(40, 124);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 11;
            label7.Text = "Class C: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 87);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 10;
            label6.Text = "Class B: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 52);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 9;
            label5.Text = "Class A:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 361);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(Exit);
            Controls.Add(Clear);
            Controls.Add(CalculatedButton);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button CalculatedButton;
        private Button Clear;
        private Button Exit;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox soldClassC;
        private TextBox soldClassB;
        private TextBox soldClassA;
        private TextBox Total;
        private TextBox classResultC;
        private TextBox classResultB;
        private TextBox classResultA;
    }
}
