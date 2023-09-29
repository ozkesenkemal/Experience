using System.Collections.Generic;

namespace FlyweightGof
{
    public class SoldierFactory
    {
        private readonly Dictionary<SoldierType, SoldierFlyweight> _soldiers;
        public SoldierFactory()
        {
            _soldiers = new Dictionary<SoldierType, SoldierFlyweight>();
        }

        public SoldierFlyweight GetSoldier(SoldierType soldierType)
        {
            SoldierFlyweight soldier;
            if (_soldiers.ContainsKey(soldierType))
            {
                return _soldiers[soldierType];
            }
            else
            {
                switch (soldierType)
                {
                    case SoldierType.Private:
                        soldier = new Private();
                        break;
                    case SoldierType.Sergeant:
                        soldier = new Sergeant();
                        break;
                    case SoldierType.Commander:
                        soldier = new CommanderFlyWeight();
                        break;
                    default:
                        soldier = new Private();
                        break;
                }

                return soldier;
            }
        }
    }
}
