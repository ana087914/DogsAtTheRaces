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
    } }