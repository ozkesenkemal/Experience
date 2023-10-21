namespace CommandGof
{
    public abstract class BankCommand : ICommand
    {
        protected readonly ReceiverBank _receiverBank;

        protected BankCommand(ReceiverBank receiverBank)
        {
            _receiverBank = receiverBank;
        }

        public abstract void Execute();
    }
}
