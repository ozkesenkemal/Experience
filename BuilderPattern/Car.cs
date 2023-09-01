namespace BuilderPattern
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Km { get; set; }
        public string Gear { get; set; }

        public override string ToString()
        {
            return string.Format($"{Brand} marka, {Model} model {Gear} vitesli araç {Km} kilometrede üretilmiştir.");
        }
    }
}