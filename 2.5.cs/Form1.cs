using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Project: Mailing Label Project
 * Programmer: Brendan Hawk
 * Date: 09/09/2020
 * Description: User inputs their info and then displays it in a mailing label format.
 */

namespace _2._5.cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            // Display user input into richtextbox when clicked

            mailingLabelRichTextBox.Text = firstNameTextBox.Text + " " + lastNameTextBox.Text + 
                Environment.NewLine + addressTextBox.Text + Environment.NewLine + cityTextBox.Text + "," + " " + stateTextBox.Text + " " + zipCodeTextBox.Text;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the richtextbox when clicked

            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            addressTextBox.Text = "";
            cityTextBox.Text = "";
            stateTextBox.Text = "";
            zipCodeTextBox.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Exit the running program when clicked

            this.Close();
        }
    }
}
