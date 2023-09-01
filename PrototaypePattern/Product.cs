namespace PrototaypePattern
{
    [Serializable]
    public class Product : ICloneable, ICloneableImplement
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
        public object Clone()
        {
            return MemberwiseClone();
        }

        public object CloneImplement()
        {
            return CloneHelper.Clone(this);
        }
    }
}
