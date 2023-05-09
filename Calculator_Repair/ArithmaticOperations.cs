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
        decimal[] num = new decimal[2];
        char _operator;
        string txtBox;

        #endregion

        #region Properties
        public int OperatorButtonClickCount { get => operatorButtonClickCount; }
        public decimal[] Num { get => num; }
        public char Operator { get => _operator; }
        public string TextBox { get => txtBox; }

        #endregion

        public ArithmaticOperations(string textBox, int click, char _operator, decimal[] num)
        {
            this.operatorButtonClickCount = click;
            this.txtBox = textBox;
            this._operator = _operator;
            this.num = num;
        }

        #region Calculation Methods

        // This Method processing for result value
        internal void OperationForCalculationMethod()
        {
            operatorButtonClickCount++;

            // if Button clicked twice

            if (operatorButtonClickCount > 1)
                return;

            try
            {
                num[0] = decimal.Parse(txtBox);

                if (num[1] != 0)
                    CalculateMethod(_operator, num, 1);
                else
                    CalculateMethod(_operator, num, 0);
            }
            catch 
            {

                throw new Exception("Incorrect character usage detected");
            }

        }

        // This Method calculate input value and send next method
        internal void CalculateMethod(char _operator, decimal[] num, int index)
        {
            switch (_operator)
            {
                case '+':
                    num[1] += num[0];
                    txtBox = num[index].ToString();
                    break;
                case '-':
                    num[1] -= num[0];
                    txtBox = num[index].ToString();
                    break;
                case '*':
                    num[1] *= num[0];
                    txtBox = num[index].ToString();
                    break;
                case '/':
                    num[1] /= num[0];
                    txtBox = num[index].ToString();
                    break;
                default:
                    num[1] = 0;
                    txtBox = num[index].ToString();
                    break;
            }
        }

        #endregion
    }
}
