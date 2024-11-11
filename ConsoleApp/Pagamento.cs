namespace ConsoleApp;
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
    }

    public void ReadAmount()
    {
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
        }
    }
}