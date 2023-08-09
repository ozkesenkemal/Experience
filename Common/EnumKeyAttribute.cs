namespace Common
{
    public class EnumKeyAttribute : Attribute
    {
        public EnumKeyAttribute(string key)
        {
            this.Key = key;
        }

        public string Key { get; set; }
    }
}
