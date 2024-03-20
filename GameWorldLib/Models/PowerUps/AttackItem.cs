using GameWorldLib.Models.Environment;
using GameWorldLib.Models.PowerUps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLib.Models.Items
{
    public class AttackItem : WorldObj, IPowerUp
    {
        public int Power { get; set; }

        public AttackItem(string name, int power, int xCord, int yCord) : base(name, xCord, yCord)
        {
            Name = name;
            Power = power;
            XCordinate = xCord;
            YCordinate = yCord;
            Lootable = true;
            Removeable = true;
        }
    }
}
