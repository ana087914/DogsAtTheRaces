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

        guys[0] = new Guy("Joe", 50, rb_Guy1, lb_guy1BetLabel);
        guys[0].UpdateLabels();

        guys[1] = new Guy("Bob", 75, rb_Guy2, lb_guy2BetLabel);
        guys[1].UpdateLabels();

        guys[2] = new Guy("Al", 45, rb_Guy3, lb_guy3BetLabel);
        guys[2].UpdateLabels();

        dogs[0] =new Dog(
     pb_dog1,
     pb_dog1.Left,
     pb_raceTrack.Width - pb_dog1.Width,
     randomizer
 );

        dogs[1] =new Dog(
            pb_dog2,
            pb_dog2.Left,
            pb_raceTrack.Width - pb_dog2.Width,
            randomizer
        );

        dogs[2] = new Dog(
            pb_dog3,
            pb_dog3.Left,
            pb_raceTrack.Width - pb_dog3.Width,
            randomizer
        );

        dogs[3]= new Dog(
            pb_dog4,
            pb_dog4.Left,
            pb_raceTrack.Width - pb_dog4.Width,
            randomizer
        );

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