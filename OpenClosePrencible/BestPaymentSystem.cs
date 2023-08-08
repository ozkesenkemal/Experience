namespace OpenClosePrencible
{
    public class BestPaymentSystem : IPayment
    {
        private IPayment payment;

        public BestPaymentSystem(IPayment payment)
        {
            this.payment = payment;
        }

        public void DoPayment()
        {
            this.payment.DoPayment();
        }
    }
}
