namespace CompositeGof
{
    public abstract class Soldier
    {
        public string Name { get; set; }
        public string Rank { get; set; }
        public Soldier (string name, string rank)
        {
            Name = name;
            Rank = rank;
        }
        public abstract void ExecuteOrder();
    }
}
