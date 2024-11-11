namespace ConsoleApp;
<<<<<<< HEAD
public class Pagamento
{
    public EPaymentType Type { get; set; }
    public double Amount { get; set; } 

    public void ReadType()
    {
        while (true)
        {
            Console.WriteLine("Enter payment type (bitcoin or cash):");
            if (Enum.TryParse(Console.ReadLine(), true, out EPaymentType paymentType))
            {
                Type = paymentType;
                break; 
            }
            else
            {
                Console.WriteLine("Invalid payment type. Please enter 'bitcoin' or 'cash'.");
            }
        }
=======
public class Pagamento(Wallet wallet)
{
    public EPaymentType Type { get; set; }
    public double Amount { get; set; }

    public void ReadType()
    {
        Console.WriteLine("Enter payment type (bitcoin or cash):");
        if (Enum.TryParse(Console.ReadLine(), true, out EPaymentType paymentType)) 
        {
            Type = paymentType;
        } 
        
        Console.WriteLine("Invalid payment type.");
>>>>>>> origin/main
    }

    public void ReadAmount()
    {
<<<<<<< HEAD
        while (true)
        {
            Console.WriteLine("Enter payment amount:");
            if (double.TryParse(Console.ReadLine(), out var amount)) 
            {
                Amount = amount;
                break;
                
            }

            else
            {
                Console.WriteLine("Invalid amount type.");
            }
=======
        Console.WriteLine("Enter payment amount:");
        if (!double.TryParse(Console.ReadLine(), out double amount))
        {
            throw new ArgumentException("Invalid payment amount.");
        }
        
        Amount = amount;
    }

    public void ProcessPayment()
    {
        wallet.Withdraw(Amount);
        
        switch (Type)
        {
            case EPaymentType.bitcoin:
                Console.WriteLine($"Bitcoin payment: {Amount}, remaining balance: {wallet.Amount}");
                break;
            case EPaymentType.cash:
                Console.WriteLine("Cash payment processed.");
                break;
            default:
                Console.WriteLine("Unknown payment type.");
                break;
>>>>>>> origin/main
        }
    }
}