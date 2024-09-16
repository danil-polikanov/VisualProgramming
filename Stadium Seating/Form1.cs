using System.Globalization;

namespace Stadium_Seating
{
    public partial class Form1 : Form
    {
        const double classA = 15;
        const double classB = 12;
        const double classC = 9;
        double soldA = 0;
        double soldB= 0;
        double soldC = 0;
        CultureInfo culture = new CultureInfo("en-US");
        public Form1()
        {
            InitializeComponent();
        }

        private void soldClassA_TextChanged(object sender, EventArgs e)
        {
            try { soldA = double.Parse(soldClassA.Text); }
            catch {
                soldClassA.Text = null;
            }
            
        }

        private void soldClassB_TextChanged(object sender, EventArgs e)
        {
            try { soldB = double.Parse(soldClassB.Text); }
            catch
            {
                soldClassB.Text = null;
            }
        }

        private void soldClassC_TextChanged(object sender, EventArgs e)
        {
            try { soldC = double.Parse(soldClassC.Text); }
            catch
            {
                soldClassC.Text = null;
            }
        }

        private void classResultA_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void classResultB_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void classResultC_TextChanged(object sender, EventArgs e)
        {

        }

        private void Total_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalculatedButton_Click(object sender, EventArgs e)
        {
            classResultA.Text = (classA * soldA).ToString("C",culture);
            classResultB.Text = (classB * soldB).ToString("C",culture);
            classResultC.Text = (classC * soldC).ToString("C", culture);
            Total.Text = (classA * soldA + classB * soldB + classC * soldC).ToString("C", culture);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            soldClassA.Text = null;
            soldClassB.Text = null;
            soldClassC.Text = null;
            classResultA.Text= null;
            classResultB.Text= null;
            classResultC.Text= null;
            Total.Text = null;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
