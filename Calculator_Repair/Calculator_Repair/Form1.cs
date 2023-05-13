using System;
using System.ComponentModel.Design;
using System.Configuration;
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

            button1.Click += new EventHandler(WhileTheNumbersButtonIsClicked);
            button2.Click += new EventHandler(WhileTheNumbersButtonIsClicked);
            button3.Click += new EventHandler(WhileTheNumbersButtonIsClicked);
            button4.Click += new EventHandler(WhileTheNumbersButtonIsClicked);
            button5.Click += new EventHandler(WhileTheNumbersButtonIsClicked);
            button6.Click += new EventHandler(WhileTheNumbersButtonIsClicked);
            button7.Click += new EventHandler(WhileTheNumbersButtonIsClicked);
            button8.Click += new EventHandler(WhileTheNumbersButtonIsClicked);
            button9.Click += new EventHandler(WhileTheNumbersButtonIsClicked);
            button0.Click += new EventHandler(WhileTheNumbersButtonIsClicked);
            buttonDot.Click += new EventHandler(WhileTheNumbersButtonIsClicked);

        }

        void WhileTheNumbersButtonIsClicked(object sender, EventArgs e)
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


        #endregion

        #region Operators Button
        void AddingEventHandlerToOperatorsButtonClick()
        {
            buttonTotal.Click += new EventHandler(WhileOperatorButtonsIsClicked);
            buttonMinus.Click += new EventHandler(WhileOperatorButtonsIsClicked);
            buttonMultiplication.Click += new EventHandler(WhileOperatorButtonsIsClicked);
            buttonDivide.Click += new EventHandler(WhileOperatorButtonsIsClicked);
            buttonEqual.Click += new EventHandler(WhileOperatorButtonsIsClicked);
        }
        void WhileOperatorButtonsIsClicked(object sender, EventArgs e)
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
            ProcessWhenOperatorsButtonIsClicked();
        }

        #endregion

        #region Clear, Percent and Positive-Negative Button
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
            var tempNum = double.Parse(txtDisplay.Text);
            if (tempNum > 0)
            {
                var temp = "-" + tempNum;
                txtDisplay.Text = temp;
            }
            else if (tempNum < 0)
            {
                txtDisplay.Text = tempNum.ToString().Remove(0, 1);
            }
            else
                return;
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            txtDisplay.Text = "0";
            num[1] = -1;
            num[0] = 0;
            operatorButtonClickCount = 0;
        }
        #endregion

        #region Process Method

        public void ProcessWhenOperatorsButtonIsClicked()
        {
            // if Button clicked twice
            operatorButtonClickCount++;
            if (operatorButtonClickCount > 1)
                return;

            ArithmaticOperations mathicOperations = new(txtDisplay.Text, _operator, num, tempOperator);
            mathicOperations.OperationForCalculationMethod();
            // After Operation the value will be back main variable
            txtDisplay.Text = mathicOperations.TextBox;
            _operator = mathicOperations.Operator;
            num = mathicOperations.Num;
        }
        #endregion

        #region KeyDown

        private void ApplyKey(string key)
        {
            TextBoxAndButtonClickController();
            if (txtDisplay.Text.StartsWith('0'))
            {
                txtDisplay.Clear();
                txtDisplay.Text += key;
            }
            else
                txtDisplay.Text += key;

        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D0:
                    ApplyKey("0");
                    break;
                case Keys.D1:
                    ApplyKey("1");
                    break;
                case Keys.D2:
                    ApplyKey("2");
                    break;
                case Keys.D3:
                    ApplyKey("3");
                    break;
                case Keys.D4:
                    ApplyKey("4");
                    break;
                case Keys.D5:
                    ApplyKey("5");
                    break;
                case Keys.D6:
                    ApplyKey("6");
                    break;
                case Keys.D7:
                    ApplyKey("7");
                    break;
                case Keys.D8:
                    ApplyKey("8");
                    break;
                case Keys.D9:
                    ApplyKey("9");
                    break;
                case Keys.NumPad0:
                    ApplyKey("0");
                    break;
                case Keys.NumPad1:
                    ApplyKey("1");
                    break;
                case Keys.NumPad2:
                    ApplyKey("2");
                    break;
                case Keys.NumPad3:
                    ApplyKey("3");
                    break;
                case Keys.NumPad4:
                    ApplyKey("4");
                    break;
                case Keys.NumPad5:
                    ApplyKey("5");
                    break;
                case Keys.NumPad6:
                    ApplyKey("6");
                    break;
                case Keys.NumPad7:
                    ApplyKey("7");
                    break;
                case Keys.NumPad8:
                    ApplyKey("8");
                    break;
                case Keys.NumPad9:
                    ApplyKey("9");
                    break;
                case Keys.Back:
                    txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
                    txtDisplay.Text = txtDisplay.Text == "" ? "0" : txtDisplay.Text;
                    break;
                case Keys.S:
                    WhileOperatorButtonsIsClicked(buttonMinus, default);
                    break;
                case Keys.W:
                    WhileOperatorButtonsIsClicked(buttonTotal, default);
                    break;
                case Keys.E:
                    WhileOperatorButtonsIsClicked(buttonMultiplication, default);
                    break;
                case Keys.D:
                    WhileOperatorButtonsIsClicked(buttonDivide, default);
                    break;
                case Keys.Q:
                    WhileOperatorButtonsIsClicked(buttonEqual, default);
                    break;
                case Keys.Delete:
                    buttonClear_Click(sender, new EventArgs());
                    break;
                default:
                    break;
            }
        }


        #endregion

    }
}
