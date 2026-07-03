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

        guys[1] = new Guy();
        guys[1].Name = "Bob";
        guys[1].Cash = 75;
        guys[1].MyRadioButton = rb_Guy2;
        guys[1].MyLabel = lb_guy2BetLabel;
        guys[1].ClearBet();

        guys[2] = new Guy();
        guys[2].Name = "Al";
        guys[2].Cash = 100;
        guys[2].MyRadioButton = rb_Guy3;
        guys[2].MyLabel = lb_guy3BetLabel;
        guys[2].ClearBet();
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
