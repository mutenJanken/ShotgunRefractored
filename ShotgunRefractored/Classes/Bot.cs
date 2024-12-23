using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShotgunRefractored.Classes
{
    public class Bot : Player
    {
        private Game game;

        public Bot(Game game)
        {
            this.game = game;
        }

        public string GetBotAction()
        {
            Random random = new Random();
            int botAction = random.Next(0, 2);

            if (this.Bullets == 0 && game.player.Bullets == 0)
            {
                return this.Load;
            }
            // User underläge
            else if (game.player.Bullets == 0 && this.Bullets > 0 && this.Bullets <= 2)
            {
                if (botAction == 0)
                {
                    return this.Shoot;
                }
                else
                {
                    return this.Load;
                }
            }
            // Bot underläge
            else if (this.Bullets == 0 && game.player.Bullets > 0)
            {
                if (botAction == 0)
                {
                    return this.Block;
                }
                else
                {
                    return this.Load;
                }
            }
            // Even steven
            else if (this.Bullets > 0 && this.Bullets <= 2 && game.player.Bullets > 0)
            {
                botAction = random.Next(0, 3);
                if (botAction == 0)
                {
                    return this.Shoot;
                }
                else if (botAction == 1)
                {
                    return this.Load;
                }
                else
                {
                    return this.Block;
                }
            }
            else if (this.Bullets >= 3)
            {
                return this.Shotgun;
            }
            return this.Block;
        }
    }
}
