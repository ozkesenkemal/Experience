using System;

namespace CompositeGof
{
    internal class Private : Soldier
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
