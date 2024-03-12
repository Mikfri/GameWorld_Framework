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
        public bool Lootable { get; set; }
        public bool Removeable { get; set; }

        public WorldObj() { }
    }
}
