using GameWorldLib.Models.Characters;
using GameWorldLib.Models.Environment;




Fox badGuy = new Fox("BadGuy", 100, 10, 10);
Rabbit hero = new Rabbit("Hero", 40, 0, 0);




World world = new World(20, 20);

world.AddAnimal(badGuy);
world.Rabbit = hero;

world.PrintGameMap();







