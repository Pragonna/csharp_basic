using System.ComponentModel.DataAnnotations;

namespace Calculator_04
{
    public partial class Form1 : Form
    {
        decimal result = 0;
        List<decimal> num = new List<decimal>();
        int click = 0;
        char symbol = default;
        char tempSymbol = default;
        public Form1()
        {
            InitializeComponent();
            textBox_main.Text = "0";
        }


        private void textBox_main_TextChanged(object sender, EventArgs e)
        {

        }
        #region Functions method
        private void Divide()
        {
            click++;
            num.Add(decimal.Parse(textBox_main.Text));
            if (result != 0)
            {
                result/= num[num.Count - 1];
                num.Add(result);
                textBox_main.Text = result.ToString();
            }
            else
            {
                result = num[0];
                textBox_main.Text = result.ToString();
            }
        }
        private void Multiplication()
        {
            click++;
            num.Add(decimal.Parse(textBox_main.Text));
            if (result != 0)
            {
                result *= num[num.Count - 1];
                num.Add(result);
                textBox_main.Text = result.ToString();
            }
            else
            {
                result = num[0];
                textBox_main.Text = result.ToString();
            }
        }
        private void Total()
        {
            click++;
            num.Add(decimal.Parse(textBox_main.Text));
            if (result != 0)
            {
                result += num[num.Count - 1];
                num.Add(result);
                textBox_main.Text = result.ToString();
            }
            else
            {
                result = num[0];
                textBox_main.Text = result.ToString();
            }
        }
        private void Minus()
        {
            click++;
            num.Add(decimal.Parse(textBox_main.Text));
            if (result != 0)
            {
                result -= num[num.Count - 1];
                num.Add(result);
                textBox_main.Text = result.ToString();
            }
            else
            {
                result = num[0];
                textBox_main.Text = result.ToString();
            }
        }


        #endregion
        #region If is or different Zero for number moving
        private void IfTextBoxIsZeroValue()
        {
            switch (textBox_main.Text)
            {
                case "0":
                    textBox_main.Clear();
                    break;
            }
            IfResultDifferentZero();
        }
        private void IfResultDifferentZero()
        {
            if (result != 0 && click > 0)
            {
                textBox_main.Clear();
                click = 0;
            }
        }
        #endregion
        #region Button Number
        private void button1_Click(object sender, EventArgs e)
        {
            IfTextBoxIsZeroValue();
            textBox_main.Text += "1";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            IfTextBoxIsZeroValue();
            textBox_main.Text += "2";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            IfTextBoxIsZeroValue();
            textBox_main.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            IfTextBoxIsZeroValue();
            textBox_main.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            IfTextBoxIsZeroValue();
            textBox_main.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            IfTextBoxIsZeroValue();
            textBox_main.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            IfTextBoxIsZeroValue();
            textBox_main.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            IfTextBoxIsZeroValue();
            textBox_main.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            IfTextBoxIsZeroValue();
            textBox_main.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            IfTextBoxIsZeroValue();
            textBox_main.Text += "0";
        }

        private void button_Dot_Click(object sender, EventArgs e)
        {
            if (result != 0 && click > 0)
            {
                textBox_main.Clear();
                textBox_main.Text += "0,";
                click = 0;
            }
            else
                textBox_main.Text += ",";
        }
        #endregion

        private void button_AllClear_Click(object sender, EventArgs e)
        {
            textBox_main.Clear();
            result = 0;
            num.Clear();
        }

        private void button_PostitiveAndNegative_Click(object sender, EventArgs e)
        {
            SymbolFiltered();
            var txtMain = decimal.Parse(textBox_main.Text);
            if (txtMain > 0)
            {
                textBox_main.Text = "-" + textBox_main.Text;
            }
            else if (txtMain < 0)
            {
                textBox_main.Text = textBox_main.Text.Remove(0, 1);
            }
            result = decimal.Parse(textBox_main.Text);

        }


        private void button_Equal_Click(object sender, EventArgs e)
        {
            SymbolFiltered();
        }

        private void SymbolFiltered()
        {
            switch (symbol)
            {
                case '+':
                    Total();
                    break;
                case '-':
                    Minus();
                    break;
                case 'x':
                    Multiplication();
                    break;
                case '/':
                    Divide();
                    break;
            }
            symbol = default;
        }

        private void ProcessResult()
        {
            if (result != 0)
            {
                switch (tempSymbol)
                {
                    case '+':
                        Total();
                        break;
                    case '-':
                        Minus();
                        break;
                    case 'x':
                        Multiplication();
                        break;
                    case '/':
                        Divide();
                        break;
                }
            }
            else
            {
                switch (symbol)
                {
                    case '+':
                        Total();
                        break;
                    case '-':
                        Minus();
                        break;
                    case 'x':
                        Multiplication();
                        break;
                    case '/':
                        Divide();
                        break;
                }
            }
        }
        
        private void button_plus_Click(object sender, EventArgs e)
        {
            tempSymbol = symbol;
            symbol = '+';
            ProcessResult();
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            tempSymbol = symbol;
            symbol = '-';
            ProcessResult();

        }

        private void button_Multiplication_Click(object sender, EventArgs e)
        {
            tempSymbol = symbol;
            symbol = 'x';
            ProcessResult();
        }

        private void button_Divide_Click(object sender, EventArgs e)
        {
            tempSymbol = symbol;
            symbol = '/';
            ProcessResult();
        }

        private void button_percent_Click(object sender, EventArgs e)
        {
            //tempSymbol = symbol;
            //symbol = '%';
            //ProcessResult();
        }
    }
}
