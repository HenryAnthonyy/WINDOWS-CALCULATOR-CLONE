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
    public partial class Calculator : Form

    {
        string operationPerformed = "";
        Double resultValue = 0;
        Double secondValue = 0;
        bool isoperationPerformed = false;
        Double secondvalue = 0;
        string Full_operation = " ";
     
        

        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void resizeChildrenControls()
        {
            
        }

        private void resizeControl(Rectangle originalControlRect, Control control) //this method will calculate for each control
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
           
        }

        private void button_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (textBox1.Text == "0" || (isoperationPerformed))
            {
                if (button.Text == ".")
                    Console.WriteLine(button.Text);
                else
                    textBox1.Clear();
            }
            
            isoperationPerformed = false;
           // Button button = (Button)sender;

            if(button.Text == ".")
            {
                if(!textBox1.Text.Contains("."))
                    textBox1.Text += button.Text;
            }
            else
                textBox1.Text += button.Text;

        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if(resultValue != 0)
            {
                Equals.PerformClick();
                operationPerformed = button.Text;
                CurrentOperationlabel.Text = resultValue + " " + operationPerformed;
                isoperationPerformed = true;
            }
            else
            {
                operationPerformed = button.Text;
                resultValue = Double.Parse(textBox1.Text);
                CurrentOperationlabel.Text = resultValue + " " + operationPerformed;
                isoperationPerformed = true;
            }

            switch (operationPerformed)
            {
                case "x²":
                    Double square = Math.Pow(resultValue,2);
                    CurrentOperationlabel.Text = "sqr(" + resultValue.ToString() + ")";
                    textBox1.Text = square.ToString();
                    break;

                case "1 ⁄ x":
                    CurrentOperationlabel.Text = "1/(" + resultValue.ToString() + ")";
                    textBox1.Text = (1 / resultValue).ToString();
                    break;

                case "2 √ x":
                    CurrentOperationlabel.Text = "√(" + resultValue + ")";
                    textBox1.Text = (Math.Sqrt(resultValue)).ToString();
                    break;

                default:
                    break;
            }

            textBox1.Text = resultValue.ToString();
            Full_operation = CurrentOperationlabel.Text;


        }

        private void EqualSign_click(object sender, EventArgs e)
        {
            secondvalue = Double.Parse(textBox1.Text);
            switch (operationPerformed)
            {
                case "-":
                    textBox1.Text = (resultValue - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "+":
                    textBox1.Text = (resultValue + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "÷":    
                     textBox1.Text = (resultValue / Double.Parse(textBox1.Text)).ToString();
                    break;
                case "×":
                    textBox1.Text = (resultValue * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "1/x":
                    textBox1.Text = (1 / resultValue).ToString();
                    break;
                
                default:
                    break;
            }
            
           

            resultValue = Double.Parse(textBox1.Text);
            CurrentOperationlabel.Text = $"{Full_operation} {secondvalue} = ";
        }

        private void PartialClear_click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void CompleteClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            resultValue = 0;
            CurrentOperationlabel.Text = "";
        }


        private void Backspace_click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }

            if (textBox1.Text == "")
                textBox1.Text = "0";

        }

        private void percentage_click(object sender, EventArgs e)
        {
            
            resultValue = Double.Parse(textBox1.Text);
            resultValue = (resultValue / 100);
            textBox1.Text = resultValue.ToString();
           

        }

        private void PlusMinus_Click(object sender, EventArgs e)
        {
            resultValue = Double.Parse(textBox1.Text);
            resultValue *= -1;
            textBox1.Text = resultValue.ToString();
        }

        private void Calculator_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                Equals.PerformClick();
                //MessageBox.Show("Enter key pressed");

            }
        }

        private void backspace_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Back)
            {
                button4.PerformClick();
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {

        }

        private void CurrentOperationlabel_Click(object sender, EventArgs e)
        {

        }
    }
}
