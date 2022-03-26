/*
*
* Grading ID: R7834
* CIS 199 - 01
* Lab 3
* Due Date: 9 / 20 / 2020
* This program creates a GUI interface using a form where a user can input the radius of a sphere and get the diameter, surface area, and volume in return. 
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


namespace Lab3
{

    public partial class Form1Lab3 : Form
    {
        double pie = Math.PI; //creates a global double that is assigned to the mathematical constant PI given via the Math class

        public Form1Lab3()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            double radius, diameter, sa, volume; //values to hold the radius, diameter, surface area (sa), and volume
            radius = double.Parse(inputBox.Text);
            double r = radius; // radius value that holds orginal value to be used in calculation as exponents and calculation will change the original value

            diameter = 2 * radius; //calculates diameter
            radius = Math.Pow(r, 2); //squares radius to use in sa formula
            sa = 4 * (pie * radius); //calculates sa
            radius = Math.Pow(r, 3); //cubes radius to use in volume formula
            volume = (4 * pie * radius) / 3; //calculates volume

            //calls appropriate text box for output to be displayed, formats to 2 decimal place precision using toString method
            diameterOutput.Text = diameter.ToString("0.00");
            saOutput.Text = sa.ToString("0.00");
            volOutput.Text = volume.ToString("0.00");
            

        }
    }
}
