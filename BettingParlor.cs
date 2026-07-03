namespace DogsAtTheRaces;

public partial class BettingParlor : Form
{
    Random randomizer = new Random();

Dog[] dogs = new Dog[4];
Guy[] guys = new Guy[3];
    public BettingParlor()
    {
        InitializeComponent();
        guys[0] = new Guy();
        guys[0].Name = "Joe";
        guys[0].Cash = 50;
        guys[0].MyRadioButton = rb_Guy1;
        guys[0].MyLabel = lb_guy1BetLabel;
        guys[0].ClearBet();
    }


    private void bt_race_Click(object sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

    private void bt_bet_Click(object sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

    private void t_raceTimer_Tick(object sender, EventArgs e)
    {
        throw new NotImplementedException();
    }
}
