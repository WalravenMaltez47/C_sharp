using System.Diagnostics;
using ConsoleApp;

public class Program
{
    public static void Main(string[] args)
    {
        Wallet saldo = new(100.00);
<<<<<<< HEAD
        Pagamento pagamento = new();
=======
        Pagamento pagamento = new(saldo);
>>>>>>> origin/main

        pagamento.ReadType();
        pagamento.ReadAmount();

<<<<<<< HEAD
        saldo.ProcessPayment(pagamento);
=======
        pagamento.ProcessPayment();
>>>>>>> origin/main
    }
}