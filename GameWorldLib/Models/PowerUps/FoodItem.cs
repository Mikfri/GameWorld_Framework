using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLib.Models.PowerUps
{
    public class FoodItem : IPowerUp
    {
        public int Power { get; set; }

        public FoodItem() { }
    }
}
