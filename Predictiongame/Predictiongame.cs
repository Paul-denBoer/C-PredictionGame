using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_1
{
    public partial class Form1 : Form
    {
        private int correctPredictions;

        public Form1()
        {
            InitializeComponent();
            progressBar1.Value = 100;
            var correctPredictions = 0;
            label2.Text = $"Health : {progressBar1.Value}";
            label1.Text = "Click on the buttons to generate a random number! Make sure you dont die!";
            label3.Text = $"Correct Predictions : {correctPredictions}";



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            var dice = rnd.Next(1, 12);
            label1.Text = $"Number you just rolled : {dice}";
            if (dice > 4)
            {
                progressBar1.Value -= 20;
                label2.Text = $"Health : {progressBar1.Value}";

                if (progressBar1.Value == 0)
                {
                    if (MessageBox.Show("Do you want to try again?", "You died :( ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        correctPredictions = 0;
                        label3.Text = $"Correct Predictions : {correctPredictions}";
                        progressBar1.Value = 100;
                        label2.Text = $"Health : {progressBar1.Value}";
                        label1.Text = "Click on the buttons to generate a random number! Make sure you dont die!";
                    }
                    else
                    {
                        System.Windows.Forms.Application.Exit();
                    }
                }
            }
            else
            {
                correctPredictions += 1;
                label3.Text = $"Correct Predictions : {correctPredictions}";
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            var dice = rnd.Next(1, 12);
            label1.Text = $"Number you just rolled : {dice}";
            if (dice < 5 || dice > 8)
            {
                progressBar1.Value -= 20;
                label2.Text = $"Health : {progressBar1.Value}";

                if (progressBar1.Value == 0)
                {
                    if (MessageBox.Show("Do you want to try again?", "You died :( ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        correctPredictions = 0;
                        label3.Text = $"Correct Predictions : {correctPredictions}";
                        progressBar1.Value = 100;
                        label2.Text = $"Health : {progressBar1.Value}";
                        label1.Text = "Click on the buttons to generate a random number! Make sure you dont die!";
                    }
                    else
                    {
                        System.Windows.Forms.Application.Exit();
                    }
                }
            }
            else
            {
                correctPredictions += 1;
                label3.Text = $"Correct Predictions : {correctPredictions}";
            }
        }

        private void button3_Click(object sender, EventArgs e)
            {
                Random rnd = new Random();
                var dice = rnd.Next(1, 12);
                label1.Text = $"Number you just rolled : {dice}";
                if (dice < 9)
                {
                    progressBar1.Value -= 20;
                    label2.Text = $"Health : {progressBar1.Value}";

                    if (progressBar1.Value == 0)
                    {
                        if (MessageBox.Show("Do you want to try again?", "You died :( ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            correctPredictions = 0;
                            label3.Text = $"Correct Predictions : {correctPredictions}";
                            progressBar1.Value = 100;
                            label2.Text = $"Health : {progressBar1.Value}";
                            label1.Text = "Click on the buttons to generate a random number! Make sure you dont die!";
                        }
                        else
                        {
                            System.Windows.Forms.Application.Exit();
                        }
                    }
            }
                else
                {
                    correctPredictions += 1;
                    label3.Text = $"Correct Predictions : {correctPredictions}";
                }
            }

        private void button4_Click(object sender, EventArgs e)
        {
            correctPredictions = 0;
            label3.Text = $"Correct Predictions : {correctPredictions}";
            progressBar1.Value = 100;
            label2.Text = $"Health : {progressBar1.Value}";
            label1.Text = "Click on the buttons to generate a random number! Make sure you dont die!";
        }
      }
    }