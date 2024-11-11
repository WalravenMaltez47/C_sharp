using System.Diagnostics;
using ConsoleApp;

public class Program
{
    public static void Main(string[] args)
    {
        Wallet saldo = new(100.00);
        Pagamento pagamento = new();

        pagamento.ReadType();
        pagamento.ReadAmount();

        saldo.ProcessPayment(pagamento);
    }
}