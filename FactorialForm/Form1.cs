using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FactorialForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int number;

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void FactorialNum_TextChanged(object sender, EventArgs e)
        {
            number = Convert.ToInt32(FactorialNum.Text);
            int fact = 1;
            for (int x = 1; x <= number; x++)
            {
                fact *= x;
            }
            textBox1.Text = fact.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
