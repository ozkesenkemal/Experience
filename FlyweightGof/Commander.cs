using System;

namespace FlyweightGof
{
    public class CommanderFlyWeight : SoldierFlyweight
    {
        public CommanderFlyWeight()
        {
            UnitName = "SWAT";
            GunName = "HK33";
            Health = "Good";
        }

        public override void MoveTo(int x, int y, string name)
        {
            XLocation = x;
            YLocation = y;
            Name = name;
            Console.WriteLine($"komutan {name} ({XLocation} - {YLocation} noktasına hareket etti.)");
        }
    }
}
