namespace CommandGof
{
    public abstract class SupplierCommand : ICommand
    {
        protected readonly ReceiverSupplier _receiverSupplier;

        protected SupplierCommand(ReceiverSupplier receiverSupplier)
        {
            _receiverSupplier = receiverSupplier;
        }

        public abstract void Execute();
    }
}
