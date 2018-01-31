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
    public partial class MainBord : Form
    {
        float number01;
        float number02;
        float plusButtonCounter = 0;
        float minusButtonCounter = 0;
        float multiplyButtonCounter = 0;
        float divideButtonCounter = 0;
        int clickCounter = 0;
       
        
        public MainBord()
        {
            InitializeComponent();
            transparent();


        }

        public void transparent()
        {
            plusButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            plusButton.FlatAppearance.BorderSize = 0;
            equalButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            equalButton.FlatAppearance.BorderSize = 0;
            multiplyButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            multiplyButton.FlatAppearance.BorderSize = 0;
            minusButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            minusButton.FlatAppearance.BorderSize = 0;
            divideButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            divideButton.FlatAppearance.BorderSize = 0;
            zeroButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            zeroButton.FlatAppearance.BorderSize = 0;
            oneButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            oneButton.FlatAppearance.BorderSize = 0;
            twoButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            twoButton.FlatAppearance.BorderSize = 0;
            threeButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            threeButton.FlatAppearance.BorderSize = 0;
            fourButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            fourButton.FlatAppearance.BorderSize = 0;
            fiveButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            fiveButton.FlatAppearance.BorderSize = 0;
            sixButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            sixButton.FlatAppearance.BorderSize = 0;
            sevenButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            sevenButton.FlatAppearance.BorderSize = 0;
            eightButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            eightButton.FlatAppearance.BorderSize = 0;
            nineButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            nineButton.FlatAppearance.BorderSize = 0;
            pointButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            pointButton.FlatAppearance.BorderSize = 0;
            plusMinusButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            plusMinusButton.FlatAppearance.BorderSize = 0;
            clearButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            clearButton.FlatAppearance.BorderSize = 0;
            clearenterButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            clearenterButton.FlatAppearance.BorderSize = 0;
            radButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            radButton.FlatAppearance.BorderSize = 0;

            putButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            putButton.FlatAppearance.BorderSize = 0;
        }
        private void plusButton_Click(object sender, EventArgs e)
        {
            number01 = float.Parse(numbersTextBox.Text);
            numbersTextBox.Text = "";
            plusButtonCounter++;
        }


        private void minusButton_Click(object sender, EventArgs e)
        {
            number01 = float.Parse(numbersTextBox.Text);
            numbersTextBox.Text = "";
            minusButtonCounter++;
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            number01 = float.Parse(numbersTextBox.Text);
            numbersTextBox.Text = "";
            multiplyButtonCounter++;
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            number01 = float.Parse(numbersTextBox.Text);
            numbersTextBox.Text = "";
            divideButtonCounter++;
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            clickCounter++;
            if (clickCounter == 1)
            {
                numbersTextBox.Text = "9";
            }
            else
                numbersTextBox.Text += "9";

        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            clickCounter++;
            if (clickCounter == 1)
            {
                numbersTextBox.Text = "8";
            }
            else
                numbersTextBox.Text += "8";

        }
        private void sevenButton_Click(object sender, EventArgs e)
        {
            clickCounter++;
            if (clickCounter == 1)
            {
                numbersTextBox.Text = "7";
            }
            else
                numbersTextBox.Text += "7";

        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            clickCounter++;
            if (clickCounter == 1)
            {
                numbersTextBox.Text = "6";
            }
            else
                numbersTextBox.Text += "6";
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            clickCounter++;
            if (clickCounter == 1)
            {
                numbersTextBox.Text = "5";
            }
            else
                numbersTextBox.Text += "5";
        }

        private void fourButton_Click(object sender, EventArgs e)
        {

            clickCounter++;
            if (clickCounter == 1)
            {
                numbersTextBox.Text = "4";
            }
            else
                numbersTextBox.Text += "4";
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            clickCounter++;
            if (clickCounter == 1)
            {
                numbersTextBox.Text = "3";
            }
            else
                numbersTextBox.Text += "3";

        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            clickCounter++;
            if (clickCounter == 1)
            {
                numbersTextBox.Text = "2";
            }
            else
                numbersTextBox.Text += "2";

        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            clickCounter++;
            if (clickCounter == 1)
            {
                numbersTextBox.Text = "1";
            }
            else
                numbersTextBox.Text += "1";

        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            clickCounter++;
            if (clickCounter == 1)
            {
                numbersTextBox.Text = "0";
            }
            else
                numbersTextBox.Text += "0";

        }

        private void pointButton_Click(object sender, EventArgs e)
        {

            if (numbersTextBox.Text.Contains(","))
            {
                numbersTextBox.Text = ",";
            }
            else
                numbersTextBox.Text += ",";

        }

        private void plusMinusButon_Click(object sender, EventArgs e)
        {
            if (numbersTextBox.Text.StartsWith("-"))
            {
                numbersTextBox.Text = numbersTextBox.Text.Substring(1);
            }
            else if (!string.IsNullOrEmpty(numbersTextBox.Text) && float.Parse(numbersTextBox.Text) != 0)
            {
                numbersTextBox.Text = "-" + numbersTextBox.Text;
            }
        }


        private void clearButton_Click(object sender, EventArgs e)
        {
            numbersTextBox.Text = numbersTextBox.Text.Substring(0, numbersTextBox.Text.Length - 1);
        }

        private void clearenterButton_Click(object sender, EventArgs e)
        {
            numbersTextBox.Text = "";
            
        }

        private void radButton_Click(object sender, EventArgs e)
        {
            number01 = float.Parse(numbersTextBox.Text);
            numbersTextBox.Text = "" + Math.Sqrt(number01);
        }

        private void putButton_Click(object sender, EventArgs e)
        {
            number01 = float.Parse(numbersTextBox.Text);
            numbersTextBox.Text = "" + (number01 * number01);
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            number02 = float.Parse(numbersTextBox.Text);
            if (plusButtonCounter == 1)
            { 
                numbersTextBox.Text = "" + (number01 + number02);
                plusButtonCounter = 0;
            }
            else if (minusButtonCounter == 1)
            {
                numbersTextBox.Text = "" + (number01 - number02);
                minusButtonCounter = 0;
            }
            else if (multiplyButtonCounter == 1)
            {
                numbersTextBox.Text = "" + (number01 * number02);
                multiplyButtonCounter = 0;
            }
            else if (divideButtonCounter == 1)
            {
                if (number02 == 0)
                {
                    MessageBox.Show("Denominator can't be 0");
                }
                else
                {
                    
                    numbersTextBox.Text = "" + (number01 / number02);
                    divideButtonCounter = 0;
                }
            }
        }

       

        private void numberTextBox2_TextChanged(object sender, EventArgs e) { }

        private void numbersTextBox_TextChanged(object sender, EventArgs e) { }


        private void numbersTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
            base.OnKeyPress(e);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Calculator v1.0 \n Fondator Cobîlaș Vasile", "About");
        }

        
    }
    }



            