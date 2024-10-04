namespace RockPaper_Scissors
{
    public partial class Form1 : Form
    {
        Dictionary<int,Bitmap> choises = new Dictionary<int, Bitmap>()
        {
            {1, Properties.Resources.rock},
            {2,Properties.Resources.paper},
            {3,Properties.Resources.scissors}
        };
        Dictionary<(int, int), string> results = new Dictionary<(int, int), string>()
        {
            {(1, 1), "Draw"},
            {(1, 2), "Computer\n wins"},
            {(1, 3), "Player\n wins"},
            {(2, 1), "Player\n wins"},
            {(2, 2), "Draw"},
            {(2, 3), "Computer\n wins"},
            {(3, 1), "Computer\n wins"},
            {(3, 2), "Player\n wins"},
            {(3, 3), "Draw"}
        };
        int computerChoice;
        int playerChoice;
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            
            computerChoice = random.Next(1,4);
        }

        private void PlayerChoice_Click(object sender, EventArgs e)
        {
           
        }

        private void ComputerChoice_Click(object sender, EventArgs e)
        {
            
        }

        private void RockPicture_Click(object sender, EventArgs e)
        {
            playerChoice = 1;
            Play();
        }

        private void PaperPicture_Click(object sender, EventArgs e)
        {
            playerChoice = 2;
            Play();
        }

        private void ScissorsPictures_Click(object sender, EventArgs e)
        {
            playerChoice = 3;
            Play();
        }

        private void ResultText_Click(object sender, EventArgs e)
        {

        }
        public void Play()
        {
            PlayerChoice.BackgroundImage = choises[playerChoice];
            ComputerChoice.BackgroundImage=choises[computerChoice];
            PlayerChoice.Visible= true;
            ComputerChoice.Visible = true;
            string result = results[(playerChoice, computerChoice)];
            ResultText.Text = result;
            ResultText.Visible= true;
            label1.Visible= true;
            label2.Visible= true;
            computerChoice = random.Next(1, 4);
        }
    }
}
