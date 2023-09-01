namespace BuilderPattern
{
    public class MercedesBuilder : CarBuilder
    {
        public MercedesBuilder()
        {
            car = new Car();
        }
        public override void SetBrand()
        {
            Car.Brand = "Mercedes";
        }

        public override void SetGear(string gearType)
        {
            Car.Gear = gearType;
        }

        public override void SetKm(int km)
        {
            Car.Km = km;
        }

        public override void SetModel(string model)
        {
            Car.Model = model;
        }
    }
}
