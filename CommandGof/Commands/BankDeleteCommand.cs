namespace CommandGof
{
    public class BankDeleteCommand : BankCommand
    {
        public BankDeleteCommand(ReceiverBank receiverBank) : base(receiverBank)
        {
        }

        public override void Execute()
        {
            _receiverBank.Delete();
        }
    }
}
