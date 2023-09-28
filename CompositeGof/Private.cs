using System;

namespace CompositeGof
{
    public class Private : Soldier
    {
        public Private(string name, string rank) : base(name, rank)
        {
        }

        public override void ExecuteOrder()
        {
            Console.WriteLine($"{Rank} - {Name} gets the order.");
        }
    }
}
