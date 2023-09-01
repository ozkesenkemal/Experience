namespace BuilderPattern
{
    public class TOGGBuilder : CarBuilder
    {
        public TOGGBuilder()
        {
            car = new Car();
        }
        public override void SetBrand()
        {
            Car.Brand = "TOGG";
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
