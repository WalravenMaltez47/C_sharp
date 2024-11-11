namespace ConsoleApp;

public class Wallet(double initialAmount)
{
    public double Amount { get; private set; } = initialAmount;

    public void ProcessPayment(Pagamento pagamento)
    {
        while (!Withdraw(pagamento.Amount)) 
        {
            Console.WriteLine("Digite um valor válido.");
            pagamento.ReadAmount(); // Lê um novo valor de pagamento
        }
        
        switch (pagamento.Type)
        {
            case EPaymentType.bitcoin:
                Console.WriteLine($"Bitcoin payment: {pagamento.Amount}, remaining balance: {Amount}");
                break;

            case EPaymentType.cash:
                Console.WriteLine("Cash payment processed.");
                break;

            default:
                Console.WriteLine("Unknown payment type.");
                break;
        }
    }
    private bool Withdraw(double amount)
    {
        if (amount <= 0 || amount > Amount)
        {
            Console.WriteLine("Invalid amount.");
            return false;
        }
        else
        {
            Amount -= amount;
            return true;
        }
    }
}