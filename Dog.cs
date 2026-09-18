using System;
using System.Windows.Forms;

namespace DogsAtTheRaces
{
    public class Dog
    {
        private int startingPosition;
        private int racetrackLength;
        private PictureBox myPictureBox;
        private int location;
        private Random randomizer;

        public int StartingPosition
        {
            get { return startingPosition; }
            set { startingPosition = value; }
        }

        public int RacetrackLength
        {
            get { return racetrackLength; }
            set { racetrackLength = value; }
        }

        public PictureBox MyPictureBox
        {
            get { return myPictureBox; }
            set { myPictureBox = value; }
        }

        public int Location
        {
            get { return location; }
            set { location = value; }
        }

        public Random Randomizer
        {
            get { return randomizer; }
            set { randomizer = value; }
        }

        public Dog(PictureBox pictureBox, int startingPosition, int racetrackLength, Random randomizer)
        {
            MyPictureBox = pictureBox;
            StartingPosition = startingPosition;
            RacetrackLength = racetrackLength;
            Randomizer = randomizer;
            Location = 0;
        }

        public void TakeStartingPosition()
        {
            Location = 0;
            MyPictureBox.Left = StartingPosition;
        }

        public bool Run()
        {
            Location = Location + Randomizer.Next(1, 5);
            MyPictureBox.Left = StartingPosition + Location;

            if (Location >= RacetrackLength)
            {
                return true;
            }

            return false;
        }
    }
}