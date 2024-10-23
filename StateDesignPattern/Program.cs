namespace StateDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ATMMachine atmMachine = new ATMMachine();
            Console.WriteLine("ATM Machine Current state : "
                            + atmMachine.AtmMachineState.GetType().Name);
            Console.WriteLine();
            atmMachine.EnterPin();
            atmMachine.WithdrawMoney();
            atmMachine.EjectDebitCard();
            atmMachine.InsertDebitCard();
            Console.WriteLine();
            Console.WriteLine("ATM Machine Current state : "
                            + atmMachine.AtmMachineState.GetType().Name);
            Console.WriteLine();
            atmMachine.EnterPin();
            atmMachine.WithdrawMoney();
            atmMachine.InsertDebitCard();
            atmMachine.EjectDebitCard();
            Console.WriteLine("");
            Console.WriteLine("ATM Machine Current state : "
                            + atmMachine.AtmMachineState.GetType().Name);
            
        }
        
    }
}
