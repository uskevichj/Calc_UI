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
            textBox1.Text = input;
        }

        private void one_Click(object sender, EventArgs e)
        {
            input += "1";
            textBox1.Text = input;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            input += "2";
            textBox1.Text = input;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            input += "3";
            textBox1.Text = input;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            input += "4";
            textBox1.Text = input;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            input += "5";
            textBox1.Text = input;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            input += "6";
            textBox1.Text = input;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            input += "7";
            textBox1.Text = input;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            input += "8";
            textBox1.Text = input;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            input += "9";
            textBox1.Text = input;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //a button that will add a decimal point to the input
            input += ".";
            textBox1.Text = input;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            // a button to divide firstnumber from secondnumber
            firstNumber = input;
            operation = '/';
            input = string.Empty;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            // a button to multiply firstnumber from secondnumber
            firstNumber = input;
            operation = '*';
            input = string.Empty;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // a button to add firstnumber from secondnumber
            firstNumber = input;
            operation = '+';
            input = string.Empty;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // a button to subtract firstnumber from secondnumber
            firstNumber = input;
            operation = '-';
            input = string.Empty;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            // a button to remove a character from input
            input = input.Remove(input.Length - 1);
            textBox1.Text = input;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            // a button to clear the input
            input = string.Empty;
            textBox1.Text = input;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            // a button to calculate the result using parse operation
            double firstNum;
            double secondNum;

            if (double.TryParse(firstNumber, out firstNum) && double.TryParse(input, out secondNum))
            {
                switch (operation)
                {
                    case '+':
                        result = firstNum + secondNum;
                        break;
                    case '-':
                        result = firstNum - secondNum;
                        break;
                    case '*':
                        result = firstNum * secondNum;
                        break;
                    case '/':
                        result = firstNum / secondNum;
                        break;
                }
                textBox1.Text = result.ToString();
                input = result.ToString();

                // take the result and store it in the first number
                firstNumber = result.ToString();

                // clear the second number
                secondNumber = string.Empty;

                // use the button to create a different result
                operation = ' ';
            }
            else
            {
                // handle the case where the input strings cannot be converted to doubles
                MessageBox.Show("Invalid input");
            }
        }

    }
}