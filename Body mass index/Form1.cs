namespace Body_mass_index
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void WeightText_TextChanged(object sender, EventArgs e)
        {
     
        }

        private void HeightText_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            double weight = Convert.ToDouble(WeightText.Text);
            double inches = Convert.ToDouble(HeightText.Text);
            double BMI= Math.Round(weight / Math.Pow(inches,2)*703,2);
            if (BMI < 18.5) {
                ResultBox.Text = $"BMI:{BMI.ToString()}\n Status: underweight";
            }
            else if(BMI > 18.5 && BMI < 25)
            {
                ResultBox.Text = $"BMI:{BMI}\n Status: optimal";
            }
            else
            {
                ResultBox.Text = $"BMI:{BMI}\n Status: overweight";
            }
        }

        private void ResultBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
