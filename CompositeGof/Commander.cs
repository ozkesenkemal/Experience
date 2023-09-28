using System;
using System.Collections.Generic;

namespace CompositeGof
{
    public class Commander : SoldierComposite
    {
        readonly List<Soldier> soldierList = new();
        public Commander(string name, string rank) : base(name, rank)
        {
        }

        public override void AddSoldier(Soldier soldier)
        {
            soldierList.Add(soldier);
        }
        
        public override void RemoveSoldier(Soldier soldier)
        {
            soldierList.Remove(soldier);
        }

        public override void ExecuteOrder()
        {
            if(Rank == "General")
            {
                Console.WriteLine($"{Rank} - {Name} ordered to all!");
            }

            foreach (var soldier in soldierList)
            {
                if(soldier.Rank != "Er")
                {
                    Console.WriteLine($"{soldier.Rank} - {soldier.Name} get order and ordered to soldiers!");
                }
                soldier.ExecuteOrder();
            } 
        }
    }
}
