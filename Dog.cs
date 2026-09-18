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
        public int StartingPosition
        {
            get{ return startingPosition;}
            set { startingPosition=value;}
        }

        public int RacetrackLength
        {
            get {return racetrackLength;}
            set {racetrackLength = value;}
        }

        public PictureBox MyPictureBox
        {
            get {return myPictureBox;}
            set {myPictureBox=value;}
        }

        public int Location
        {
            get {return location;}
            set {location=value;}
        }

        public Random Randomizer
        {
            get {return randomizer;}
            set {randomizer=value;}
        }
        public void TakeStartingPosition()
        {
            Location= 0;
            MyPictureBox.Left= StartingPosition;
        }
        public bool Run()
        {
            Location= Location+Randomizer.Next(1, 5);
            MyPictureBox.Left= StartingPosition +Location;

            if (Location >= RacetrackLength)
            {
                return true;
            }

            return false;
        }
    }
    }