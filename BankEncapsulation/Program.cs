namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var DarronsAccount = new BankAccount();
            Console.WriteLine("How much do you like to deposit?");
            var amounttoDeposit = double.Parse(Console.ReadLine());
            DarronsAccount.Deposit(amounttoDeposit);
            Console.WriteLine($"Your balance is {DarronsAccount.GetBalance()}");
        }
    }
}
