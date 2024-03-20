using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLib.Models.Characters
{
    public class Rabbit : Creature
    {

        // IDE: notification pattern. Hvis det er er et  tur baseret spil, hvor terningkast bestemmer
        // antal actions/movemements og man har begrænset view, så kan man evt få en notification hvis
        // der er noget gemt loot i nærheden.

        public Rabbit(string name, int hitPoints, int x, int y) : base(name, hitPoints, x, y)
        {
        
        }
    }
}
