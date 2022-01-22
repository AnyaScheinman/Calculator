using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InClass1_Calculator
{
    public partial class Form2 : Form
    {
        //declaring the private form variables 
        private decimal numX = 0.0m;
        private decimal numY = 0.0m;
        private decimal isNewNumber = 0;
        private int pendingOperation = (int)Calculations.zeroCalculation;


        public enum Calculations
        {
            zeroCalculation = 0,
            Addition = 1,
            Subtraction = 2,
            Multiplication = 3,
            Division = 4,
        }
        public Form2()
        {
            InitializeComponent();
        }


   
       
        //buttons and values
            private void btnClear_Click(object sender, EventArgs e)
            {
                txtOperand.Text = String.Empty; //clear the textbox results as well as lable results
                result.Text = "";
        }

            private void btnClearEntry_Click(object sender, EventArgs e)
            {
                txtOperand.Text = "0";  //clear textbox
           
            }

            private void txtOperand_TextChanged(object sender, EventArgs e)
            {

            }

        private void btnOperationAdd_Click(object sender, EventArgs e)
        {
            pendingOperation = 1;
            numX = Convert.ToDecimal(txtOperand.Text);
            txtOperand.Text = "0";
            

        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            {

                pendingOperation = 2;
                numX = Convert.ToDecimal(txtOperand.Text);
                txtOperand.Text = "0";

            }
        }
        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            {

                pendingOperation = 3;
                numX = Convert.ToDecimal(txtOperand.Text);
                txtOperand.Text = "0";

            }
        }
        private void btnDivision_Click(object sender, EventArgs e)
        {
            {

                pendingOperation = 4;
                numX = Convert.ToDecimal(txtOperand.Text);
                txtOperand.Text = "0";

            }
        }
        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (!txtOperand.Text.Contains('.'))
            {
                txtOperand.Text += ".";
            }
        }
        //using a switch statement to calculate the first and second number than converting it to a string to display results
        private void btnEqual_Click(object sender, EventArgs e)
        {

            
            numY = Convert.ToDecimal(txtOperand.Text);
            switch (pendingOperation)
            {
                case 1:

                    isNewNumber = numX + numY;
                    break;

                case 2:
                    isNewNumber = numX - numY;
                    break;

                case 3:
                    isNewNumber = numX * numY;
                    break;

                case 4:
                    isNewNumber = numX / numY;
                    break;

            }
            txtOperand.Text = isNewNumber.ToString();
        }


        
        private void digitClickHandler(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (txtOperand.Text == "0")
            {
                txtOperand.Clear();
            }

            txtOperand.Text += btn.Text;
        }

        //tried to get the lable to display numX {calculation} numY = result but could not figure out how to get it to display on the lable. 
        private void result_Click(object sender, EventArgs e)
        {
            result.Text = txtOperand.Text;
        }
    }
}

