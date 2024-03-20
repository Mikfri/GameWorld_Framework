using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLib.Models.Environment
{
    public class WorldObj
    {
        public string Name { get; set; }
        public int XCordinate { get; set; }
        public int YCordinate { get; set; }

        public bool Lootable { get; set; }
        public bool Removeable { get; set; }

        public WorldObj(string name, int xCord, int yCord)
        {
            Name = name;
            XCordinate = xCord;
            YCordinate = yCord;
            Lootable = false;
            Removeable = false;
        }

        public WorldObj() { }
    }
}
