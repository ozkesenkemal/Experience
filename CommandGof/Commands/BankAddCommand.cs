namespace CommandGof
{
    public class BankAddCommand : BankCommand
    {
        public BankAddCommand(ReceiverBank receiverBank) : base(receiverBank)
        {
        }

        public override void Execute()
        {
            _receiverBank.Add();
        }
    }
}
