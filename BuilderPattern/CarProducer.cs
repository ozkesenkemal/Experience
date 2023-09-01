namespace BuilderPattern
{
    public class CarProducer
    {
        public void Produce(CarBuilder carBuilder, string model, string gearType, int km)
        {
            carBuilder.SetBrand();
            carBuilder.SetModel(model);
            carBuilder.SetGear(gearType);
            carBuilder.SetKm(km);
        }
    }
}
