﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz2021Ex
{
    public partial class Form1 : Form
    {
        //Random Generator
        Random randomizer = new Random();

        //Store variable for addition
        int addend1;
        int addend2;

        /// <summary>
        /// Stat the quiz by filling the numbers generated and stating the times
        /// </summary>
        public void startTheQuiz()
        {
            //Create the number that will be used in the the plus quiz
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            //Convert the number into string they can be added to the UI
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();

            //Make sure that the value is zero when the quiz starts
            sum.Value = 0;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_2(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startTheQuiz();
            startButton.Enabled = false;
        }
    }
}
