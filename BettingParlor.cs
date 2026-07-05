namespace DogsAtTheRaces;

public partial class BettingParlor : Form
{
    Random randomizer = new Random();

    Dog[] dogs = new Dog[4];
    Guy[] guys = new Guy[3];

    int minimumBet = 5;

    public BettingParlor()
    {
        InitializeComponent();

        lb_minimumBet.Text = minimumBet + " bucks";
        num_dogNumber.Minimum = 1;
        num_dogNumber.Maximum = 4;

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
        guys[2].Cash = 45;
        guys[2].MyRadioButton = rb_Guy3;
        guys[2].MyLabel = lb_guy3BetLabel;
        guys[2].ClearBet();

        dogs[0] = new Dog();
        dogs[0].MyPictureBox = pb_dog1;
        dogs[0].StartingPosition = pb_dog1.Left;
        dogs[0].RacetrackLength = pb_raceTrack.Width - pb_dog1.Width;
        dogs[0].Randomizer = randomizer;

        dogs[1] = new Dog();
        dogs[1].MyPictureBox = pb_dog2;
        dogs[1].StartingPosition = pb_dog2.Left;
        dogs[1].RacetrackLength = pb_raceTrack.Width - pb_dog2.Width;
        dogs[1].Randomizer = randomizer;

        dogs[2] = new Dog();
        dogs[2].MyPictureBox = pb_dog3;
        dogs[2].StartingPosition = pb_dog3.Left;
        dogs[2].RacetrackLength = pb_raceTrack.Width - pb_dog3.Width;
        dogs[2].Randomizer = randomizer;

        dogs[3] = new Dog();
        dogs[3].MyPictureBox = pb_dog4;
        dogs[3].StartingPosition = pb_dog4.Left;
        dogs[3].RacetrackLength = pb_raceTrack.Width - pb_dog4.Width;
        dogs[3].Randomizer = randomizer;

        rb_Guy1.Checked = true;
        lb_name.Text = guys[0].Name;
    }

    private void bt_bet_Click(object sender, EventArgs e)
    {
        int guyNumber = 0;

        if (rb_Guy1.Checked)
        {
            guyNumber = 0;
        }

        if (rb_Guy2.Checked)
        {
            guyNumber = 1;
        }

        if (rb_Guy3.Checked)
        {
            guyNumber = 2;
        }

        int betAmount = minimumBet;
        int dogNumber = (int)num_dogNumber.Value;

        guys[guyNumber].PlaceBet(betAmount, dogNumber);
    }

    private void bt_race_Click(object sender, EventArgs e)
    {
        gB_bettingParlor.Enabled = false;
        t_raceTimer.Start();
    }

    private void t_raceTimer_Tick(object sender, EventArgs e)
    {
        for (int i = 0; i < dogs.Length; i++)
        {
            if (dogs[i].Run())
            {
                t_raceTimer.Stop();

                int winner = i + 1;

                MessageBox.Show("Dog #" + winner + " won the race!");

                for (int j = 0; j < guys.Length; j++)
                {
                    guys[j].Collect(winner);
                }

                for (int k = 0; k < dogs.Length; k++)
                {
                    dogs[k].TakeStartingPosition();
                }

                gB_bettingParlor.Enabled = true;
                break;
            }
        }
    }
}