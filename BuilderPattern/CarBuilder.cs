namespace BuilderPattern
{
    public abstract class CarBuilder
    {
        protected Car car;
        public Car Car { get { return car; } }

        public abstract void SetBrand();
        public abstract void SetModel(string model);
        public abstract void SetGear(string gearType);
        public abstract void SetKm(int km);
    }
}
