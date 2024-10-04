namespace GuessingGameNumber
{
    public partial class Form1 : Form
    {
        int tryCount = 0;
        int guessNumber = 0;
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            guessNumber = random.Next(0, 100);
        }
       
        private void PlayerNumber_ValueChanged(object sender, EventArgs e)
        {
       
        }

        private void ChoiceButton_Click(object sender, EventArgs e)
        {
            tryCount+=1;
            if (PlayerNumber.Value > guessNumber) 
            {
                Result.Text = "Too high,try again";
            }
            else if (PlayerNumber.Value < guessNumber)
            {
                Result.Text = "Too low,try again";
            }
            else
            {              
                this.Controls.Clear();
                this.InitializeComponent();
                Result.Text = $"You are winner \n You guessed on the {tryCount} try";
                tryCount = 0;
                guessNumber = random.Next(0, 100);
            }

        }

    }
}
