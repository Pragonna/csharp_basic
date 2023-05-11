using System;
using System.ComponentModel.Design;
using System.Linq.Expressions;

namespace Calculator_Repair
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtDisplay.Text = "0";
            num[1] = -1;
            AddingEventHandlerToNumbersButtonClick();
            AddingEventHandlerToOperatorsButtonClick();

        }
        #region Fields

        char _operator = default;
        char tempOperator = default;
        int operatorButtonClickCount = 0;
        double[] num = new double[2];


        #endregion

        #region Numbers Button

        private void AddingEventHandlerToNumbersButtonClick()
        {
            // Button click value for Numbers

            button1.Click += new EventHandler(WhileTheNumbersButtonIsPressed);
            button2.Click += new EventHandler(WhileTheNumbersButtonIsPressed);
            button3.Click += new EventHandler(WhileTheNumbersButtonIsPressed);
            button4.Click += new EventHandler(WhileTheNumbersButtonIsPressed);
            button5.Click += new EventHandler(WhileTheNumbersButtonIsPressed);
            button6.Click += new EventHandler(WhileTheNumbersButtonIsPressed);
            button7.Click += new EventHandler(WhileTheNumbersButtonIsPressed);
            button8.Click += new EventHandler(WhileTheNumbersButtonIsPressed);
            button9.Click += new EventHandler(WhileTheNumbersButtonIsPressed);
            button0.Click += new EventHandler(WhileTheNumbersButtonIsPressed);
            buttonDot.Click += new EventHandler(WhileTheNumbersButtonIsPressed);

        }

        void WhileTheNumbersButtonIsPressed(object sender, EventArgs e)
        {
            // We need to Control the TextBox value and the  ButtonsClick count before to assign number value for TextBox
            TextBoxAndButtonClickController();

            // Add value to display when you click button..
            switch ((sender as Button).Name)
            {
                case "button0":
                    txtDisplay.Text += "0";
                    break;
                case "button1":
                    txtDisplay.Text += "1";
                    break;
                case "button2":
                    txtDisplay.Text += "2";
                    break;
                case "button3":
                    txtDisplay.Text += "3";
                    break;
                case "button4":
                    txtDisplay.Text += "4";
                    break;
                case "button5":
                    txtDisplay.Text += "5";
                    break;
                case "button6":
                    txtDisplay.Text += "6";
                    break;
                case "button7":
                    txtDisplay.Text += "7";
                    break;
                case "button8":
                    txtDisplay.Text += "8";
                    break;
                case "button9":
                    txtDisplay.Text += "9";
                    break;

                case "buttonDot":
                    txtDisplay.Text += txtDisplay.Text == "" ? "0," : ",";
                    break;
                default:
                    break;
            }
        }

        private void TextBoxAndButtonClickController()
        {
            // Conditions for click button
            txtDisplay.Text = txtDisplay.Text == "0" ? "" : txtDisplay.Text;

            // And when operation button pressing, your selected number will write in new line like a new number
            if (operatorButtonClickCount > 0)
            {
                txtDisplay.Clear();
                operatorButtonClickCount = 0;
            }
        }

        // ALL CLEAR (AC) Button
        private void buttonClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            txtDisplay.Text = "0";
            num[1] = -1;
            num[0] = 0;
            operatorButtonClickCount = 0;
        }

        #endregion

        #region Operators Button
        void AddingEventHandlerToOperatorsButtonClick()
        {
            buttonTotal.Click += new EventHandler(OperatorButtons);
            buttonMinus.Click += new EventHandler(OperatorButtons);
            buttonMultiplication.Click += new EventHandler(OperatorButtons);
            buttonDivide.Click += new EventHandler(OperatorButtons);
            buttonEqual.Click += new EventHandler(OperatorButtons);
        }
        void OperatorButtons(object sender, EventArgs e)
        {
            tempOperator = _operator;
            switch ((sender as Button).Name)
            {
                case "buttonTotal":
                    _operator = '+';
                    break;
                case "buttonMinus":
                    _operator = '-';
                    break;
                case "buttonMultiplication":
                    _operator = '*';
                    break;
                case "buttonDivide":
                    _operator = '/';
                    break;
                default:
                    break;
            }
            Process();
        }

        #endregion

        #region Process Method

        public void Process()
        {

            ArithmaticOperations mathicOperations = new(txtDisplay.Text, operatorButtonClickCount, _operator, num, tempOperator);
            mathicOperations.OperationForCalculationMethod();
            // After Operation the value will be back main variable
            txtDisplay.Text = mathicOperations.TextBox;
            _operator = mathicOperations.Operator;
            operatorButtonClickCount = mathicOperations.OperatorButtonClickCount;
            num = mathicOperations.Num;
        }
        #endregion


        private void buttonPercent_Click(object sender, EventArgs e)
        {
            num[0] = double.Parse(txtDisplay.Text);
            if (num[1] == -1)
                num[1] = num[0];
            else
                num[1] *= num[0];
            num[1] /= 100;
            txtDisplay.Text = num[1].ToString();
            num[1] = -1;
        }

        private void buttonPositiveAndNegative_Click(object sender, EventArgs e)
        {
            num[0] = double.Parse(txtDisplay.Text);
            if (num[0] > 0)
            {
                var temp = "-" + num[0];
                txtDisplay.Text = temp;
                num[1] = double.Parse(temp);
            }
            else if (num[0] < 0)
            {
                txtDisplay.Text= num[0].ToString().Remove(0, 1);
                num[1] = double.Parse(txtDisplay.Text);
            }
            else
                return;
        }
    }
}