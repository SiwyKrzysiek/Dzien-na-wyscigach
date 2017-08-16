using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dzień_na_wyścigach
{
    public class Hound
    {
        public int StartingPosition;
        public int RacetrackLength;
        public PictureBox MyPictureBox;
        public int Location = 0;
        public static Random MyRandom;

        public bool Run()
        {
            Location += MyRandom.Next(1, 5);
            MyPictureBox.Left = StartingPosition + Location;

            if (Location >= RacetrackLength)
                return true;
            else
                return false;
        }

        public void TakeStartingPosition()
        {
            MyPictureBox.Left = StartingPosition;
            Location = 0;
        }
    }
}
