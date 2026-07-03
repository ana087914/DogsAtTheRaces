namespace DogsAtTheRaces
{
    public class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;

        public string GetDescription()
        {
            if (Amount==0)
            {
                   return Bettor.Name+"hasn't placed a bet";
            }

            return Bettor.Name+"bets"+Amount+"on dog"+Dog;
        }

        public int PayOut(int winner)
        {
            if (Dog==winner)
            {
                return Amount;
            }

            return -Amount;
        }
    }
}