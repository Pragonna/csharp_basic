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

        public ArithmaticOperations(string textBox, int click, char _operator, double[] num, char tempOperator)
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
            // if Button clicked twice
            operatorButtonClickCount++;
            if (operatorButtonClickCount > 1)
                return;

            // tempOperator to need for handle result before current operation 
            tempOperator = tempOperator == default ? _operator : tempOperator;
            num[0] = double.Parse(txtBox);
            if (num[1] == -1)
            {
                num[1] = num[0];
            }
            else
            {
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
            txtBox = num[1].ToString();
        }

        // This Method calculate result value
        protected void Subtract()
        {
            num[1] -= num[0];
        }
        protected void Total()
        {
            num[1] += num[0];
        }
        protected void Multiplication()
        {
            num[1] *= num[0];
        }
        protected void Divide()
        {
            num[1] /= num[0];
        }
        #endregion
    }
}
