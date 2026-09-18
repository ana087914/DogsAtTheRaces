namespace DogsAtTheRaces
{
    public class Bet
    {
        private int amount;
        private int dog;
        private Guy bettor;

        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public int Dog
        {
            get { return dog; }
            set { dog = value; }
        }

        public Guy Bettor
        {
            get { return bettor; }
            set { bettor = value; }
        }

        public Bet(int amount, int dog, Guy bettor)
        {
            Amount = amount;
            Dog = dog;
            Bettor = bettor;
        }

        public string GetDescription()
        {
            if (Amount == 0)
            {
                return Bettor.Name + " hasn't placed a bet";
            }

            return Bettor.Name + " bets " + Amount + " on dog " + Dog;
        }

        public int PayOut(int winner)
        {
            if (Dog == winner)
            {
                return Amount;
            }

            return -Amount;
        }
    }
}