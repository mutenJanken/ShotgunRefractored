using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShotgunRefractored.Classes
{
    public class Player
    {
        public int Bullets { get; set; }
        public string Action { get; set; }
        public string Shoot;
        public string Load;
        public string Block;
        public string Shotgun;

        public Player()
        {
            Bullets = 0;
            Shoot = "Shoot";     
            Load = "Load";
            Block = "Block";       
            Shotgun = "Shotgun";
        }

        public bool CheckPlayerBullets(string selectedAction)
        {
            Action = selectedAction;
            if (Action == Shoot && Bullets <= 0)
            {        
                    MessageBox.Show("You dont have any bullets, reload.");
                    return false;               
            }
            else if (Action == Shotgun && Bullets < 3)
            {      
                    MessageBox.Show("You need at least 3 bullets to use shotgun.");
                    return false;                
            }
            return true;
        }
    }
}
