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
    public string name
        {
            get{ return Name;}
            set {Name = value;}
        }
        public Bet myBet
        {
            get {return MyBet;}
            set {MyBet = value; }
        }
        public int cash
        {
            get {return Cash;}
            set {Cash = value;}
        }
        public RadioButton myRadioButton
        {
            get {return MyRadioButton;}
            set {MyRadioButton = value;}
        }
        public Label myLabel
        {
            get {return MyLabel;}
            set {MyLabel = value;}
        }


        public void UpdateLabels()
        {
            MyLabel.Text = MyBet.GetDescription();
            MyRadioButton.Text = Name+"has"+Cash+"bucks";
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