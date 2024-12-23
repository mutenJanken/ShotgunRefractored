using ShotgunRefractored.Classes;

namespace ShotgunRefractored
{
    public partial class FormShotgun : Form
    {
        private Game game;         
        private int TurnCounter = 0;
        public int WinCounterPlayer = 0;
        public int WinCounterBot = 0;
        public FormShotgun()
        {
            InitializeComponent();
            game = new Game();

            UpdateBulletAmount(game.player.Bullets, game.bot.Bullets);
            DisplayPlayersAction();
            DisplayWinner();
        }
        public void DisplayWinner()
        {
            textBoxUserWins.Text = WinCounterPlayer.ToString();
            textBoxBotWins.Text = WinCounterBot.ToString();
        }
        public void UpdateBulletAmount(int playerBullets, int botBullets)
        {
            textBoxPlayerBullets.Text = playerBullets.ToString();
            textBoxBotBullets.Text = botBullets.ToString();
        }
        public void DisplayPlayersAction()
        {
            textBoxPlayerAction.Text = game.player.Action;
            textBoxBotAction.Text = game.bot.Action;            
        }
        public void DisplayCombatLog(string combatMessage)
        {
            TurnCounter++;
            textBoxTurn.Text = $"Turn {TurnCounter}: {combatMessage}";
            Application.DoEvents();
        }
        private void Resetvalues()
        {
            game.player.Bullets = 0;
            game.bot.Bullets = 0;
            game.player.Action = "";
            game.bot.Action = "";
            TurnCounter = 0;
            UpdateBulletAmount(game.player.Bullets, game.bot.Bullets);
            DisplayPlayersAction();
            textBoxTurn.Clear();
        }
        private void cmdShoot_Click(object sender, EventArgs e)
        {
                game.Play("Shoot", this);
        }

        private void cmdLoad_Click(object sender, EventArgs e)
        {
                game.Play("Load", this);
        }

        private void cmdBlock_Click(object sender, EventArgs e)
        {
                game.Play("Block", this);
        }

        private void cmdShotgun_Click(object sender, EventArgs e)
        {
                game.Play("Shotgun", this);
        }

        private void cmdPlayAgain_Click(object sender, EventArgs e)
        {
            game.PlayAgain();
            Resetvalues();
            MessageBox.Show("Game has been reset.");
        }
        private void cmdExitGame_Click(object sender, EventArgs e)
        {
            game.EndGame(this);
        }

    }
}
