namespace ConsoleApp;

public class Wallet(double initialAmount)
{
    public double Amount { get; private set; } = initialAmount;
    
    public void ProcessPayment(Pagamento pagamento)
    {
        if (!Withdraw(pagamento.Amount)) return;
            
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
            throw new ArgumentException("Invalid withdrawal amount.");
        }
        else
        {
            Amount -= amount;
            return true;
        }
    }
}