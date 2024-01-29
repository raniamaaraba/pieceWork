/*Project: 4.6
 * Programmer: Rania Maaraba
 * Date: November 2022
 * Description: Create a project that allows workers to input how many pieces they've made during their shift and result a dollar amount per range of pieces.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;



 namespace pieceWork
{
    public partial class Form1 : Form
    {
        //Declare Class variables.
        private decimal piecePriceDecimal;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Calculate the values.

            if (radioButton1_CheckedChanged)
            {
                piecePriceDecimal= Decimal.Round((piecesTextBox_TextChanged * 0.5),2);
            }
            else
            {
                if (radioButton2_CheckedChanged)
                {
                    piecePriceDecimal = Decimal.Round((piecesTextBox_TextChanged * 0.55),2);
                }
            };
            else
            {
                if (radioButton3_CheckedChanged)
                {
                    piecePriceDecimal = Decimal.Round((piecesTextBox_TextChanged * 0.6), 2);
                }
              else
                {
                    if (radioButton4_CheckedChanged)
                    {
                        piecePriceDecimal = Decimal.Round((piecesTextBox_TextChanged * 0.65), 2);
                    }
                }
            }
        } 
           
        private void clearButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Clear();
            piecesTextBox.Clear();
        }

        private void allButton_Click(object sender, EventArgs e)
        {
           string summaryString.Clear();
            nameTextBox.Clear();
            piecesTextBox.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;

        }

        private void summaryButton_Click(object sender, EventArgs e)
        {
            // Display the summary information in a message box.
            string summaryString = "Amount Earned:      "
                + calculateButton;
            MessageBox.Show(summaryString,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

        }

        private void piecesTextBox_TextChanged(object sender, EventArgs e)
        {
            *if (piecesTextBox_TextChanged) = false {
                MessageBox.Show("Please enter a valid number.");

           
             }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void calculatePayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Calculate the values.

            if (radioButton1_CheckedChanged)
            {
                piecePriceDecimal = Decimal.Round((piecesTextBox_TextChanged * 0.5), 2);
            }
            else
            {
                if (radioButton2_CheckedChanged)
                {
                    piecePriceDecimal = Decimal.Round((piecesTextBox_TextChanged * 0.55), 2);
                }
            };
            else
            {
                if (radioButton3_CheckedChanged)
                {
                    piecePriceDecimal = Decimal.Round((piecesTextBox_TextChanged * 0.6), 2);
                }
                else
                {
                    if (radioButton4_CheckedChanged)
                    {
                        piecePriceDecimal = Decimal.Round((piecesTextBox_TextChanged * 0.65), 2);
                    }
                }
            }
        }

        private void summaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Display the summary information in a message box.
            string summaryString = "Amount Earned:      "
                + calculateButton;
            MessageBox.Show(summaryString,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nameTextBox.Clear();
            piecesTextBox.Clear();
        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string summaryString.Clear();
            nameTextBox.Clear();
            piecesTextBox.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Change the label's font.
            //Initialise the dialog box
            fontDialog1.Font = titleLabel.Font;
            //Display the dialog box.
            fontDialog1.ShowDialog();
            //Assign the new font.
            titleLabel.Font = fontDialog1.Font;
        }

        private Color selectColor(Color incomingColor)
        {
            //Display the color dialog box.

            colorDialog1.Color = incomingColor;
            colorDialog1.ShowDialog();
            return colorDialog1.Color;

        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Change the form's ForeColour.
             * Applies to all the controls on the form that haven't had their
             * ForeColour explicitly modified
             * Inititalise the dialog box.
             */

            selectColor();
            messageLabel.ForeColor = selectColor(originalColor);

            colorDialog1.Color = this.ForeColor;
            //Display the dialog box
            colorDialog1.ShowDialog();
            //Assign the new colour.
            this.ForeColor = colorDialog1.Color();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}