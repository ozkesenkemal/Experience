using System;

namespace FlyweightGof
{
    public abstract class SoldierFlyweight
    {
        #region Instrinsic Fields
        protected string UnitName;
        protected string GunName;
        protected string Health;
        #endregion

        #region Extrinsic Fields
        public int XLocation;
        public int YLocation;
        public string Name;
        #endregion

        public abstract void MoveTo(int x, int y, string name);
    }
}
