using System;

namespace CompositeGof
{
    internal class Private : SoldierComposite
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
