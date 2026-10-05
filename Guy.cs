using System.Windows.Forms;

namespace DogsAtTheRaces
{
    public class Guy
    {
        private string name;
        private Bet myBet;
        private int cash;
        private RadioButton myRadioButton;
        private Label myLabel;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Guy(string name, int cash, RadioButton radioButton, Label label)
        {
            this.name = name;
            this.cash = cash;
            myRadioButton = radioButton;
            myLabel = label;
            myBet = null;
        }

        public void UpdateLabels()
        {
            if (myBet == null)
            {
                myLabel.Text = name + " hasn't placed a bet";
            }
            else
            {
                myLabel.Text = myBet.GetDescription();
            }

            myRadioButton.Text = name + " has " + cash + " bucks";
        }

        public void ClearBet()
        {
            myBet = null;
        }

        public bool PlaceBet(int betAmount, int dogToWin)
        {
            if (betAmount > cash)
            {
                return false;
            }

            myBet = new Bet(betAmount, dogToWin, this);
            UpdateLabels();

            return true;
        }

        public void Collect(int winner)
        {
            if (myBet != null)
            {
                cash = cash + myBet.PayOut(winner);
            }

            ClearBet();
            UpdateLabels();
        }
    }
}