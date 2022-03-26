/*
 * 
 * Grading ID: R7834
 * CIS 199-01
 * CIS 199 E1 F20
 * Due Date: 9/28/2020
 * This program creates a GUI interface using a form where a user can input the AQI and have the air pollution determined.
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS199E1F20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //button event that when click takes user input from the in textbox and determines which level of air pollution and displays it in the out box
        private void findPolLvl_Click(object sender, EventArgs e)
        {
            if(int.Parse(inBox.Text) > 100) //these if/else statements take input from the inBox, convert value to an integer, and compare to numeric value to determine Pollution Level
                outBox.Text = "Air Pollution is Very High";
            else if (int.Parse(inBox.Text) <= 100 && double.Parse(inBox.Text) >= 76)
                outBox.Text = "Air Pollution is High";
            else if (int.Parse(inBox.Text) <= 75 && double.Parse(inBox.Text) >= 51)
                outBox.Text = "Air Pollution is Medium";
            else if (int.Parse(inBox.Text) <= 50 && double.Parse(inBox.Text) >= 26)
                outBox.Text = "Air Pollution is Low";
            else
                outBox.Text = "Air Pollution is Very Low";
            
        }
    }
}
