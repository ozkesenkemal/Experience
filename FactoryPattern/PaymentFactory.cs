namespace FactoryPattern
{
    public class PaymentFactory
    {
        public IPayment DoPayment(string paymentType)
        {
            switch (paymentType)
            {
                case "CreditCard":
                    return new CreditCard();
                case "Eft":
                    return new Eft();
                case "AtDoor":
                    return new AtDoor();
                default:
                    return new CreditCard();
            }
        }
    }
}
