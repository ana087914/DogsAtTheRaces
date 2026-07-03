using System;
using System.Windows.Forms;

namespace DogsAtTheRaces
{
    public class Dog
    {
        public int StartingPosition;
        public int RacetrackLength;
        public PictureBox MyPictureBox;
        public int Location;
        public Random Randomizer;

        public void TakeStartingPosition()
        {
            Location = 0;
            MyPictureBox.Left = StartingPosition;
        }
        public bool Run()
        {
            Location = Location + Randomizer.Next(1, 5);
            MyPictureBox.Left = StartingPosition + Location;

            return false;
        }
    }
    }