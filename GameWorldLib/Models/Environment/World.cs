using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using GameWorldLib.Models.Characters;

namespace GameWorldLib.Models.Environment
{
    public class World
    {
        //Use camel casing ("camelCasing") when naming private or internal fields and prefix them with _
        //Use camel casing when naming local variables, including instances of a delegate type

        public List<Creature> Animals;


        public int MaxX { get; set; }
        public int MaxY { get; set; }

        public Rabbit Rabbit { get; set; }

        public World(int maxX, int maxY)
        {
            Animals = new List<Creature>();
            MaxX = maxX;
            MaxY = maxY;
        }

        public void AddAnimal(Creature animal)
        {
            Animals.Add(animal);
        }

        public void RemoveAnimal(Creature animal)
        {
            Animals.Remove(animal);
        }


        public string GetSquareContent(int x, int y)
        {
            // Check if there's a Fox at this position
            foreach (var fox in Animals)
            {
                if (fox is Fox && fox.X == x && fox.Y == y)
                {
                    return "[F]";
                }
            }

            // Check if there's a rabbit at this position
            if (Rabbit.X == x && Rabbit.Y == y)
            {
                return "[R]";
            }

            // Check if there's an object at this position
            //foreach (var obj in Objects)
            //{
            //    if (obj.X == x && obj.Y == y)
            //    {
            //        return "[O]";
            //    }
            //}

            // If the square is not occupied, return an empty square

            return "[ ]";
        }

        public void PrintGameMap()
        {
            Console.Clear(); // Clear console before printing new map

            for (int y = 0; y < MaxY; y++)
            {
                for (int x = 0; x < MaxX; x++)
                {
                    // Get the content of the square
                    string squareContent = GetSquareContent(x, y);

                    // Print the square content with a space separator
                    Console.Write(squareContent /*+ " "*/);
                }
                // Move to the next line for the next row
                Console.WriteLine();
            }

            // Print player's health
            // Print turn count
        }
    }
}
