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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
         //   try
         //   {
                  int firstNumber;
                bool  didParsefirstNumber = int.TryParse(txtFirstNumber.Text, out firstNumber);
            if (!didParsefirstNumber)
            {
                lblAnswer.Text="First Number is invalid";
                return;
            }
                int secondNumber; 
                bool didParseSecondNumber=int.TryParse(txtSecondNumber.Text, out secondNumber);
              if (!didParseSecondNumber)
            {
                lblAnswer.Text="Second Number is invalid";
                return;
            }
                string operatorString = (string)cboOperator.SelectedItem;


                int answer = 0;
                switch (operatorString)
                {
                    case "+":
                        answer = firstNumber + secondNumber;
                        break;

                    case "-":
                        answer = firstNumber - secondNumber;
                        break;

                    case "*":
                        answer = firstNumber * secondNumber;
                        break;

                    case "/":
                        answer = firstNumber / secondNumber;
                        break;
                    case "%":
                        answer = firstNumber % secondNumber;
                        break;
                }
                lblAnswer.Text = answer.ToString();

            }
        //    catch (Exception ex)
           // {
               // lblAnswer.Text = "error";
            //}

        }

        
        }
       

     
        

    

