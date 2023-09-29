using System;

namespace FlyweightGof
{
    internal class Sergeant : SoldierFlyweight
    {
        public Sergeant()
        {
            UnitName = "SWAT";
            GunName = "Machine Gun";
            Health = "Good";
        }

        public override void MoveTo(int x, int y, string name)
        {
            XLocation = x;
            YLocation = y;
            Name = name;
            Console.WriteLine($"Çavuş {name} ({XLocation} - {YLocation} noktasına hareket etti.)");
        }
    }
}
