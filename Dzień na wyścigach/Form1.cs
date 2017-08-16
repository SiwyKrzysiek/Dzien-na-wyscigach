using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dzień_na_wyścigach
{
    public partial class Form1 : Form
    {
        private static int minimalBet = 5;
        private Hound[] dogs;
        private Guy[] players;
        private int activeGuy = 0;
        private int winner;

        public Form1()
        {
            InitializeComponent();

            players = new Guy[] 
            {
                new Guy("Janek", 50, joeRadioButton, joeBetLabel),
                new Guy("Bartek", 75, bobRadioButton, bobBetLabel),
                new Guy("Arek", 45, alRadioButton, alBetLabel)
            };
            dogs = new Hound[] 
            {
                new Hound(dog1pictureBox, raceTrackPictureBox.Width - dog1pictureBox.Width),
                new Hound(dog2pictureBox, raceTrackPictureBox.Width - dog1pictureBox.Width),
                new Hound(dog3pictureBox, raceTrackPictureBox.Width - dog1pictureBox.Width),
                new Hound(dog4pictureBox, raceTrackPictureBox.Width - dog1pictureBox.Width)
            };

            minimumBetLabel.Text = "Minimalny zakład: " + minimalBet.ToString("C0");
            betMoneyNumericUpDown.Minimum = minimalBet;
            betMoneyNumericUpDown.Maximum = players[activeGuy].Chash;
            pickedGuyNameLabel.Text = players[activeGuy].Name;
        }

        private void joeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (joeRadioButton.Checked)
            {
                pickedGuyNameLabel.Text = players[0].Name;
                activeGuy = 0;
                betMoneyNumericUpDown.Maximum = players[activeGuy].Chash;
            }
        }

        private void bobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (bobRadioButton.Checked)
            {
                pickedGuyNameLabel.Text = players[1].Name;
                activeGuy = 1;
                betMoneyNumericUpDown.Maximum = players[activeGuy].Chash;
            }
        }

        private void alRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (alRadioButton.Checked)
            {
                pickedGuyNameLabel.Text = players[2].Name;
                activeGuy = 2;
                betMoneyNumericUpDown.Maximum = players[activeGuy].Chash;
            }
        }

        private void dog1pictureBox_Click(object sender, EventArgs e)
        {
            pickHoundNumericUpDown.Value = 1;
        }

        private void dog2pictureBox_Click(object sender, EventArgs e)
        {
            pickHoundNumericUpDown.Value = 2;
        }

        private void dog3pictureBox_Click(object sender, EventArgs e)
        {
            pickHoundNumericUpDown.Value = 3;
        }

        private void dog4pictureBox_Click(object sender, EventArgs e)
        {
            pickHoundNumericUpDown.Value = 4;
        }

        private void makeBettButton_Click(object sender, EventArgs e)
        {
            players[activeGuy].PlaceBet((int)betMoneyNumericUpDown.Value, (int)pickHoundNumericUpDown.Value - 1);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            bettingHouseGroupBox.Enabled = false;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                if (dogs[i].Run())
                {
                    timer.Stop();

                    foreach (Guy guy in players)
                    {
                        guy.Collect(i);
                    }
                    MessageBox.Show("Chart numer " + (i+1) + " wygrał wyścig!", "Mamy zwycięzcę");

                    foreach (Hound dog in dogs)
                    {
                        dog.TakeStartingPosition();
                    }
                    foreach (Guy guy in players)
                    {
                        guy.ClearBet();
                        guy.UpdateLables();
                    }

                    bettingHouseGroupBox.Enabled = true;
                }
            }
        }
    }
}
