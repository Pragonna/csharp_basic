using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Repair
{
    internal class ArithmaticOperations
    {
        #region Fields

        int operatorButtonClickCount;
        double[] num = new double[2];
        char _operator;
        string txtBox;
        char tempOperator;

        #endregion

        #region Properties
        public int OperatorButtonClickCount { get => operatorButtonClickCount; }
        public double[] Num { get => num; }
        public char Operator { get => _operator; }
        public string TextBox { get => txtBox; }

        #endregion

        public ArithmaticOperations(string textBox, int click, char _operator, double[] num,char tempOperator)
        {
            this.operatorButtonClickCount = click;
            this.txtBox = textBox;
            this._operator = _operator;
            this.num = num;
            this.tempOperator = tempOperator;
        }

        #region Calculation Methods

        // This Method processing for result value
        internal void OperationForCalculationMethod()
        {
            operatorButtonClickCount++;
            if (operatorButtonClickCount > 1)
                return;

            // if Button clicked twice
            tempOperator = tempOperator == default ? _operator : tempOperator;
            switch (tempOperator)
            {
                case '+':
                    Total();
                    break;
                case '-':
                    Subtract();
                    break;
                case '*':
                    Multiplication();
                    break;
                case '/':
                    Divide();
                    break;
                default:
                    break;
            }



        }

        // This Method calculate input value and send next method
        protected void Subtract()
        {
            num[0] = double.Parse(txtBox);
            if (num[1] == -1)
            {
                num[1] = num[0];
                num[0] = 1;
                txtBox = num[1].ToString();
            }
            else
            {
                num[1] -= num[0];
                txtBox = num[1].ToString();
            }
        }
        protected void Total()
        {
            num[0] = double.Parse(txtBox);
            if (num[1] == -1)
            {
                num[1] = num[0];
                num[0] = 1;
                txtBox = num[1].ToString();
            }
            else
            {
                num[1] += num[0];
                txtBox = num[1].ToString();
            }
        }

        protected void Multiplication()
        {
            num[0] = double.Parse(txtBox);
            if (num[1] == -1)
            {
                num[1] = num[0];
                num[0] = 1;
                txtBox = num[1].ToString();
            }
            else
            {
                num[1] *= num[0];
                txtBox = num[1].ToString();
            }
        }
        protected void Divide()
        {
            num[0] = double.Parse(txtBox);
            if (num[1] == -1)
            {
                num[1] = num[0];
                num[0] = 1;
                txtBox = num[1].ToString();
            }
            else
            {
                num[1] /= num[0];
                txtBox = num[1].ToString();
            }
        }
        #endregion
    }
}