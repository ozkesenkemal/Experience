namespace CommandGof
{
    public class DisableSupplierCommand : SupplierCommand
    {
        public DisableSupplierCommand(ReceiverSupplier receiverSupplier) : base(receiverSupplier)
        {
        }

        public override void Execute()
        {
            _receiverSupplier.Disable();
        }
    }
}
