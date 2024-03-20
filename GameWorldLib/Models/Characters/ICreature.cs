namespace GameWorldLib.Models.Characters
{
    public interface ICreature
    {
        int Hitpoints { get; set; }
        string Name { get; set; }
        int XCordinate { get; set; }
        int YCordinate { get; set; }

        void DoDamage(Creature enemy);
        void ReceiveDamage(int dmg);
    }
}