namespace DogsAtTheRaces
{
    public class Bet
    {
        private int amount;
        private int dog;
        private Guy bettor;

        public Bet(int amount, int dog, Guy bettor)
        {
            this.amount = amount;
            this.dog = dog;
            this.bettor = bettor;
        }

        public string GetDescription()
        {
            if (amount == 0)
            {
                return bettor.Name + " hasn't placed a bet";
            }

            return bettor.Name + " bets " + amount + " on dog " + dog;
        }

        public int PayOut(int winner)
        {
            if (dog == winner)
            {
                return amount;
            }

            return -amount;
        }
    }
}