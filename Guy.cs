using System.Windows.Forms;

namespace DogsAtTheRaces
{
    public class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;
        public RadioButton MyRadioButton;
        public Label MyLabel;
    
    public void UpdateLabels()
        {
            MyLabel.Text = MyBet.GetDescription();
            MyRadioButton.Text = Name+"has"+Cash+"bucks";
        }
        public void ClearBet()
        {
            MyBet = new Bet();
            MyBet.Bettor = this;

            UpdateLabels();
        }
        public bool PlaceBet(int betAmount, int dogToWin)
        {
            if (betAmount>Cash)
            {
                return false;
            }

            MyBet = new Bet();
            MyBet.Amount = betAmount;
            MyBet.Dog = dogToWin;
            MyBet.Bettor = this;

            UpdateLabels();

            return true;
        }
        public void Collect(int winner)
        {
            Cash=Cash+MyBet.PayOut(winner);

            ClearBet();
        }
    } }