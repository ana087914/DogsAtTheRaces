using System.Windows.Forms;

namespace DogsAtTheRaces
{
    public class Guy
    {
        public string Name;
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

        public Bet MyBet
        {
            get { return myBet; }
            set { myBet = value; }
        }

        public int Cash
        {
            get { return cash; }
            set { cash = value; }
        }

        public RadioButton MyRadioButton
        {
            get { return myRadioButton; }
            set { myRadioButton = value; }
        }

        public Label MyLabel
        {
            get { return myLabel; }
            set { myLabel = value; }
        }
        public Guy(string name, int cash, RadioButton radioButton, Label label)
        {
            Name=name;
            Cash=cash;
            MyRadioButton=radioButton;
            MyLabel=label;
            MyBet=null;
        }
        public void UpdateLabels()
        {
       if (MyBet== null)
       {
          MyLabel.Text=Name + "Hasn't placed a bet";
            }
            else
            {
          MyLabel.Text =MyBet.GetDescription();
            }

            MyRadioButton.Text =Name+"has"+ Cash +"bucks";
        }
        public void ClearBet()
        {
            MyBet=null;
        }
        public bool PlaceBet(int betAmount, int dogToWin)
        {
            if (betAmount>Cash)
            {
                return false;
            }

            MyBet = new Bet(betAmount, dogToWin, this);

            UpdateLabels();

            return true;
        }
        public void Collect(int winner)
        {
            Cash=Cash+MyBet.PayOut(winner);

            ClearBet();
        }
    } }