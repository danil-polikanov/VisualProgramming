namespace Driver_s_License_exam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] rightAnswers = new string[] {
        "1.B","2.D","3.A","4.A","5.C",
        "6.A","7.B","8.A","9.C","10.D",
        "11.B","12.C","13.D","14.A","15.D",
        "16.C","17.C","18.B","19.D","20.A"
        };
        string[] userAnswers = new string[] { };
        string[] wrongAnswers = new string[] { };
        private void Answer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UploadExam_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Выберите файл";
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                try
                {
                    string fileContent = File.ReadAllText(filePath);
                    MessageBox.Show($"File: \n{fileContent}");

                    userAnswers = fileContent.Replace("\r\n", " ").Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    wrongAnswers = rightAnswers.Where((rightAnswers, index) => rightAnswers != userAnswers[index]).ToArray();
                    if (wrongAnswers.Length > 6) {
                        ResultExam.Text = $"You have failed the exam\nYour answers {20-wrongAnswers.Length}/20";
                        foreach (var questionNumber in wrongAnswers)
                        {
                            Answer.Items.Add($"Wrong answers № {questionNumber}");
                        }
                        ResultExam.Visible=true;
                        Answer.Visible = true;
                    }
                    else
                    {
                        ResultExam.Text = $"You have passed the exam\nYour answers {20 - wrongAnswers.Length}/20";
                        foreach (var questionNumber in wrongAnswers)
                        {
                            Answer.Items.Add($"Wrong question № {questionNumber}");
                        }
                        ResultExam.Visible = true;
                        Answer.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при чтении файла: {ex.Message}");
                    this.Controls.Clear();
                    this.InitializeComponent();
                }
            }
        }

        private void ResultExam_Click(object sender, EventArgs e)
        {

        }
    }
}
