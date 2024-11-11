namespace ConsoleApp;
public class Pagamento
{
    public EPaymentType Type { get; set; }
    public double Amount { get; set; } 

    public void ReadType()
    {
        bool validador = false; 
        while (!validador)
        {
            Console.WriteLine("Enter payment type (bitcoin or cash):");
            string input = Console.ReadLine();
            
            if (double.TryParse(input, out _)) 
            {
                Console.WriteLine("Invalid payment type. Please enter 'bitcoin' or 'cash'.");
            }
            else if (Enum.TryParse(input, true, out EPaymentType paymentType))
            {
                Type = paymentType;
                validador = true; 
            }
            else
            {
                Console.WriteLine("Invalid payment type. Please enter 'bitcoin' or 'cash'.");
            }
        }
    }

    public void ReadAmount()
    {
        bool validador = false;
        while (!validador)
        {
            Console.WriteLine("Enter payment amount:");
            if (double.TryParse(Console.ReadLine(), out var amount)) 
            {
                Amount = amount;
                validador = true; 
            }
            else
            {
                Console.WriteLine("Invalid amount type."); 
            }
        }
    }
}