namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
  {
            var myAccount = new BankAccount();

            double userBalanace = myAccount.GetBalance();
            Console.WriteLine($"Your userBalance before deposit is: {userBalanace}");

            Console.WriteLine("How much $ do you want to deposit?");

            var amountToDeposit = double.Parse(Console.ReadLine());
            myAccount.Deposit(amountToDeposit);  //ASSIGN INPUT TO A VARIABLE
            Console.WriteLine($"Your amountToDeposit is: {amountToDeposit}");  //PRINT THE VALUE OF THE VARIABLE


            double newBalance = userBalanace + amountToDeposit;

            Console.WriteLine($"Your new balance is: {newBalance}");
        
        }
    }
}
