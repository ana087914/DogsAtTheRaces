using System.Reflection.Metadata.Ecma335;

namespace DogsAtTheRaces
{
    public class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;

        public int Amount {
            get {return Amount;}
            set {Amount = value;}
        }
        public int Dog
        {
            get {return Dog;}
            set {Dog = value;}
        }
        public Guy Bettor
        {
            get {return Bettor;}
            set {Bettor = value;}
        }
        public Bet(int amount, int dog, Guy bettor)
        {
            Amount = amount;
            Dog = dog;
            Bettor = bettor;
        }
        {
            Amount = amount;
            Dog = dog;
            Bettor = bettor;
        })
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