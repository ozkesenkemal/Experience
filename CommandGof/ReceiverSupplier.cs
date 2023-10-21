namespace CommandGof
{
    public class ReceiverSupplier
    {
        public int _supplierId;
        public string _supplierName;
        public ReceiverSupplier(int supplierId, string supplierName)
        {
            _supplierId = supplierId;
            _supplierName = supplierName;
        }

        public void Enable()
        {
            Console.WriteLine($"{_supplierId} idli {_supplierName} adlı supplier aktif edildi");
        }

        public void Disable()
        {
            Console.WriteLine($"{_supplierId} idli {_supplierName} adlı supplier pasif edildi");
        }
    }
}