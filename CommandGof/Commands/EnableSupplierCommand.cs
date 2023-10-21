namespace CommandGof
{
    public class EnableSupplierCommand : SupplierCommand
    {
        public EnableSupplierCommand(ReceiverSupplier receiverSupplier) : base(receiverSupplier)
        {
        }

        public override void Execute()
        {
            _receiverSupplier.Enable();
        }
    }
}
