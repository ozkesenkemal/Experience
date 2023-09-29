using System;

namespace FlyweightGof
{
    internal class Private :SoldierFlyweight
    {
        public Private()
        {
            UnitName = "SWAT";
            GunName = "G3";
            Health = "Good";
        }

        public override void MoveTo(int x, int y, string name)
        {
            XLocation = x;
            YLocation = y;
            Name = name;
            Console.WriteLine($"Er {name} ({XLocation} - {YLocation} noktasına hareket etti.)");
        }
    }
}
