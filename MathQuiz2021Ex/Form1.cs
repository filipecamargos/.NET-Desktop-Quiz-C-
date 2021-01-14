using System;
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

        //Store variable for the subtraction
        int minuend;
        int subtrahend;

        //Keeps track of the remaining time.
        int timeLeft;

        public Form1()
        {
            InitializeComponent();
        }

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

            //Create the number that will be used in the the subtraction quiz
            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            //Convert the number into string they can be added to the UI
            minusLeftLabel.Text = minuend.ToString();
            minusRightLabel.Text = subtrahend.ToString();
            //Make sure that the value is zero when the quiz starts
            difference.Value = 0;

            //Start the timer
            timeLeft = 30;
            timeLabel.Text = "30 seconds!";
            QuizTimer.Start();


        }
        /// <summary>
        /// Check the answer to see if the user got everything right.
        /// </summary>
        /// <returns>True if the answer's correct, false otherwise.</returns>
        private bool CheckTheAnswer()
        {
            if ((addend1 + addend2 == sum.Value)
                && (minuend - subtrahend == difference.Value))
                return true;
            else
                return false;
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                // If CheckTheAnswer() is true and stop the quiz with a message of congrats!
                QuizTimer.Stop();
                MessageBox.Show("You got all the answers right!",
                                "Congratulations!");
                startButton.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                // Display the new time left by updating the Time Left label.
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + " seconds!";
            }
            else
            {
                // If the user ran out of time, stop the timer, show a MessageBox, 
                //and fill in the answers.
                QuizTimer.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                sum.Value = addend1 + addend2;
                difference.Value = minuend - subtrahend;
                startButton.Enabled = true;
            }
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            // Select the whole answer in the NumericUpDown control.
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }
    }
}
