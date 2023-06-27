using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {

        string operation = "";
        bool isOperationPerformed = false;
        bool isCalculationCompleted = false;
        double result = 0;

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
          

            if (resultBox.Text == "0" || isOperationPerformed)
            {
                resultBox.Clear();
            }

            Button button = (Button)sender;
            
            //print numbers clicked 
            resultBox.Text += button.Text;

            //if only dot is clicked, add 0 before it
            if (resultBox.Text == ".")
            {
                resultBox.Text = "0" + ".";
            }

            if (resultBox.Text.Contains("."))
            {
                return;
            }

            isOperationPerformed = false;
        }

        private void Operation_Click(object sender, EventArgs e)
        {
            //track which operand is click
            Button button = (Button)sender;

            operation = button.Text;

            //this variable will hold the first value that shows up on the display screen 
            double firstValue = 0;
          
            if (displayBox.Text != "" && resultBox.Text != "" && operation != "")
            {
               
                char[] separators = new char[] { '+', '-', 'x', '/' };
                string[] val1 = displayBox.Text.Split(separators);
                foreach (var val in val1)
                {

                  if(double.TryParse(val, out firstValue))
                    {
                       result = firstValue;
                    } 
 
                }
 
                if (result > 0)
                {
                  
                    operation = button.Text;
                   
                   if(displayBox.Text.Contains("+"))
                    {
                        result += double.Parse(resultBox.Text);
                       
                    }else if(displayBox.Text.Contains("-"))
                    {
                        result -= double.Parse(resultBox.Text);

                    } else if(displayBox.Text.Contains("x"))
                    {
                        result *= double.Parse(resultBox.Text);

                    } else if(displayBox.Text.Contains("/"))
                    {
                        result /= double.Parse(resultBox.Text);
                    }

                    //print result after calculation is performed. Set isOperationPerformed to true
                    displayBox.Text = result + " " + operation + " ";
                    resultBox.Text = result.ToString();
                    isOperationPerformed = true;
                   

                }
                else
                {
                    //if result is equal to 0. No operation was previously performed
                    operation = button.Text;
                    result = double.Parse(resultBox.Text);
                    displayBox.Text = result + " " + operation + " ";
                    isOperationPerformed = true;

                }


            } else
            {
                // if no input was made nor any operation previously performed
                result = double.Parse(resultBox.Text);
                displayBox.Text = result + " " + operation + " ";
                isOperationPerformed = true;
            }

            //if (resultBox.Text == "0.")
            //{
                //resultBox.Text = "0";
           // }
        }

        private void negativeOperation_Click(object sender, EventArgs e)
        {
            if (resultBox.Text == "0")
            {
                resultBox.Text = Math.Abs(double.Parse(resultBox.Text)).ToString();
            }
            else
            {
                resultBox.Text = "-" + resultBox.Text;
            }

        }

        private void get_Result_(object sender, EventArgs e)
        {

            if (isCalculationCompleted)
            {
                if (displayBox.Text.Contains("="))
                {
                    result = double.Parse(resultBox.Text);
                    //isCalculationCompleted = false;
                   return;
                }
                

            }

           
            switch (operation)
            {
                case "+":
                    displayBox.Text += resultBox.Text + " = ";
                    resultBox.Text = (result + double.Parse(resultBox.Text)).ToString();break;
       
                case "-":
                    displayBox.Text += resultBox.Text + " =";
                    resultBox.Text = (result - double.Parse(resultBox.Text)).ToString(); break;

                case "x":
                    displayBox.Text += resultBox.Text + " =";
                    resultBox.Text = (result * double.Parse(resultBox.Text)).ToString(); break;

                case "/":
                    displayBox.Text += resultBox.Text + " =";
                    resultBox.Text = (result / double.Parse(resultBox.Text)).ToString(); break;
            }

            //return true if the equal button has been clicked
            isCalculationCompleted = true;

        }

        private void clearAllData(object sender, EventArgs e)
        {
            resultBox.Text = "0";
            displayBox.Text = "";
            result = 0;
        }

        private void ClearEntry(object sender, EventArgs e)
        {
            if(resultBox.Text != "0")
            {
                resultBox.Text = "0";
            }

            if (displayBox.Text.Contains("="))
            {
                resultBox.Text = "0";
                displayBox.Clear();
                result = 0;
            }

        }

        private void getPercentageValue(object sender, EventArgs e)
        {
            if (resultBox.Text == "0" || displayBox.Text == "")
            {
              
                displayBox.Text = "0";
            }
            if(displayBox.Text != "" )
            {
                //this variable will hold the first value that shows up on the display screen 
                double firstValue = 0;
                double num = 0;
                char[] separators = new char[] { '+', '-', 'x', '/' };
                string[] val1 = displayBox.Text.Split(separators);
                foreach (var val in val1)
                {

                    if (double.TryParse(val, out firstValue))
                    {
                       num = firstValue;
                    }

                }
                double percentageValue = (num * double.Parse(resultBox.Text)) / 100;
                
                resultBox.Text = percentageValue.ToString();
                //displayBox.Text += percentageValue.ToString();


            }
        }


    }
}