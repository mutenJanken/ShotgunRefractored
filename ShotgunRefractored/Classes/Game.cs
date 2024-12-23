namespace ShotgunRefractored.Classes
{
    public class Game
    {
        public Bot bot;
        public Player player;
        private bool isGameOver;

        public Game()
        {
            bot = new Bot(this);
            isGameOver = false;
            player = new Player();
        }

        public void Play(string playerAction, FormShotgun formShotgun)
        {
            if (isGameOver == true)
            {
                MessageBox.Show("Game has ended. Press 'Play again' or 'Exit game'");
                return;
            }
            bot.Action = bot.GetBotAction();
            bool enoughBullets = player.CheckPlayerBullets(playerAction);
            if (enoughBullets == true)
            {
                Turn(playerAction, bot.Action, formShotgun);
            }
        }
        public void Turn(string playerAction, string botAction, FormShotgun formShotgun)
        {
            if (playerAction == player.Shotgun && botAction == bot.Shotgun)
            {
                ShotgunOnShotgun(formShotgun);
            }
            else
            {
                switch (playerAction)
                {
                    case "Shoot":
                        HandleShootAction(botAction, formShotgun);
                        break;
                    case "Load":
                        HandleLoadAction(botAction, formShotgun);
                        break;
                    case "Block":
                        HandleBlockAction(botAction, formShotgun);
                        break;
                    case "Shotgun":
                        HandleShotgunAction(formShotgun);
                        break;
                }
            }
            formShotgun.UpdateBulletAmount(player.Bullets, bot.Bullets);
            formShotgun.DisplayPlayersAction();
            formShotgun.DisplayWinner();
        }
        public void EndGame(FormShotgun formShotgun)
        {
            formShotgun.Close();
        }
        public void PlayAgain()
        {
            isGameOver = false;
        }
        public void HandleShootAction(string botAction, FormShotgun formShotgun)
        {
            player.Bullets--;
            if (botAction == "Shoot")
            {
                bot.Bullets--;
                formShotgun.DisplayCombatLog("Both took a shot, no one wins.");
            }
            else if (botAction == "Load")
            {
                bot.Bullets++;
                formShotgun.DisplayCombatLog("You shot opponent while they where loading. You win!");
                formShotgun.WinCounterPlayer++;
                isGameOver = true;
            }
            else if (botAction == "Block")
            {
                formShotgun.DisplayCombatLog("Opponent blocked your shot");
            }
            else if (botAction == "Shotgun")
            {
                bot.Bullets -= 3;
                formShotgun.DisplayCombatLog("Opponent shots you with a shotgun. Opponent wins!");
                formShotgun.WinCounterBot++;
                isGameOver = true;
            }
        }
        public void HandleLoadAction(string botAction, FormShotgun formShotgun)
        {
            player.Bullets++;
            if (botAction == "Shoot")
            {
                bot.Bullets--;
                formShotgun.DisplayCombatLog("Opponent shot you while you where loading. Opponent wins!");
                formShotgun.WinCounterBot++;
                isGameOver = true;
            }
            else if (botAction == "Load")
            {
                bot.Bullets++;
                formShotgun.DisplayCombatLog("Both reloaded.");
            }
            else if (botAction == "Block")
            {
                formShotgun.DisplayCombatLog("You load a bullet while opponent blocks.");
            }
            else if (botAction == "Shotgun")
            {
                bot.Bullets--;
                formShotgun.DisplayCombatLog("Opponent shots you with a shotgun. Opponent wins!");
                formShotgun.WinCounterBot++;
                isGameOver = true;
            }
        }
        public void HandleBlockAction(string botAction, FormShotgun formShotgun)
        {
            if (botAction == "Shoot")
            {
                bot.Bullets--;
                formShotgun.DisplayCombatLog("You Successfully blocked opponents shot!");
            }
            else if (botAction == "Load")
            {
                bot.Bullets++;
                formShotgun.DisplayCombatLog("You block while opponent loads a bullet.");
            }
            else if (botAction == "Block")
            {
                formShotgun.DisplayCombatLog("You both block.");
            }
            else if (botAction == "Shotgun")
            {
                bot.Bullets -= 3;
                formShotgun.DisplayCombatLog("Opponent shots you with a shotgun. Opponent wins!");
                formShotgun.WinCounterBot++;
                isGameOver = true;
            }
        }
        public void HandleShotgunAction(FormShotgun formShotgun)
        {
            player.Bullets -= 3;
            formShotgun.DisplayCombatLog("You shot opponent with a shotgun. You win!");
            formShotgun.WinCounterPlayer++;
            isGameOver = true;
        }
        public void ShotgunOnShotgun(FormShotgun formShotgun)
        {
            Random random = new Random();
            int fiftyFifty = random.Next(0, 2);
            switch (fiftyFifty)
            {
                case 0:
                    player.Bullets -= 3;
                    bot.Bullets -= 3;
                    formShotgun.DisplayCombatLog("Lucky you, you won!");
                    formShotgun.WinCounterPlayer++;
                    isGameOver = true;
                    break;
                case 1:
                    bot.Bullets -= 3;
                    player.Bullets -= 3;
                    formShotgun.DisplayCombatLog("Not so lucky, bot won!");
                    formShotgun.WinCounterBot++;
                    isGameOver = true;
                    break;
            }
        }
    }
}
