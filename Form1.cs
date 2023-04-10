namespace Calc_UI
{
    public partial class Form1 : Form
    {
        // Create variables to store the first number, second number and the result
        string input = string.Empty;
        string firstNumber = string.Empty;
        string secondNumber = string.Empty;
        char operation;
        double result = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        // This method will be called when the user clicks on any of the number buttons

        private void zero_Click(object sender, EventArgs e)
        {
            input += "0";
        }

        private void one_Click(object sender, EventArgs e)
        {
            input += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            input += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            input += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            input += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            input += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            input += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            input += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            input += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            input += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            input += ".";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }
    }
}