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

        public Dog(PictureBox pictureBox, int startingPosition, int racetrackLength, Random randomizer)
        {
            myPictureBox = pictureBox;
            this.startingPosition = startingPosition;
            this.racetrackLength = racetrackLength;
            this.randomizer = randomizer;
            location = 0;
        }

        public void TakeStartingPosition()
        {
            location = 0;
            myPictureBox.Left = startingPosition;
        }

        public bool Run()
        {
            location = location + randomizer.Next(1, 5);
            myPictureBox.Left = startingPosition + location;

            if (location >= racetrackLength)
            {
                return true;
            }

            return false;
        }
    }
}