using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using GameWorldLib.Models.Characters;

namespace GameWorldLib.Models.Environment
{
    /// <summary>
    /// World klassen håndterer alt som har med verdenen å gøre og dens objekter.
    /// Den har sine egne properties: X og Y, som er størrelsen på verdenen.
    /// </summary>
    public class World
    {
        //Use camel casing ("camelCasing") when naming private or internal fields and prefix them with _
        //Use camel casing when naming local variables, including instances of a delegate type

        public List<Creature> CreatureList;
        public List<WorldObj> ObjectList;


        public int MaxX { get; set; }
        public int MaxY { get; set; }

        public Rabbit Rabbit { get; set; }

        public World(int maxX, int maxY)
        {
            CreatureList = new List<Creature>();
            MaxX = maxX;
            MaxY = maxY;
        }

        public void AddAnimal(Creature animal)
        {
            CreatureList.Add(animal);
        }

        public void RemoveAnimal(Creature animal)
        {
            CreatureList.Remove(animal);
        }


        public string GetSquareContent(int x, int y)
        {
            // Check if there's a Fox at this position
            foreach (var fox in CreatureList)
            {
                if (fox is Fox && fox.XCordinate == x && fox.YCordinate == y)
                {
                    return "[F]";
                }
            }

            // Check if there's a rabbit at this position
            if (Rabbit.XCordinate == x && Rabbit.YCordinate == y)
            {
                return "[R]";
            }

            if (Rabbit.XCordinate == x && Rabbit.YCordinate == y)
            {
                return "[R]";
            }

            //Check if there's an object at this position
            foreach (var obj in ObjectList)
            {
                if (obj.XCordinate == x && obj.YCordinate == y)
                {
                    return "[O]";
                }
            }

            //If the square is not occupied, return an empty square

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
