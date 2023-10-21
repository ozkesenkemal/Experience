namespace CommandGof
{
    public class ReceiverBank
    {
        public string _bankName;
        public ReceiverBank(string bankName)
        {
            _bankName = bankName;
        }

        public void Add()
        {
            Console.WriteLine($"{_bankName} adlı banka sisteme eklendi");
        }

        public void Delete()
        {
            Console.WriteLine($"{_bankName} adlı banka sistemden silindi");
        }
    }
}