using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLib.Models.Characters
{
    public class Hero : Creature
    {
        public Hero(string name, int hitPoints, int x, int y) : base(name, hitPoints, x, y) 
        { 
        }
    }
    
}
