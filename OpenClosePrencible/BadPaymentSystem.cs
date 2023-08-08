namespace OpenClosePrencible
{
    public class BadPaymentSystem
    {
        BadCreditCardPayment BadCreditCardPayment;
        BadAtDoorPayment BadAtDoorPayment;
        BadEftPayment BadEftPayment;

        public BadPaymentSystem()
        {
            BadCreditCardPayment = new BadCreditCardPayment();
            BadAtDoorPayment = new BadAtDoorPayment();
            BadEftPayment = new BadEftPayment();
        }

        public void DoPayment(int paymentType)
        {
            if (paymentType == 1)
            {
                BadCreditCardPayment.DoPayment();
            }
            else if (paymentType == 2)
            {
                BadAtDoorPayment.DoPayment();
            }
            else
            {
                BadEftPayment.DoPayment();
            }
        }
    }
}
