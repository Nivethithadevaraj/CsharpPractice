using System;

// Old payment system (already exists)
public class OldPaymentSystem
{
    public void MakePayment(double amount)
    {
        Console.WriteLine($"Payment of {amount} processed using Old System.");
    }
}

// New interface expected by your application
public interface INewPayment
{
    void Pay(double amount);
}

// Adapter bridges the old system with new interface
public class PaymentAdapter : INewPayment
{
    private readonly OldPaymentSystem _oldPayment;

    public PaymentAdapter(OldPaymentSystem oldPayment)
    {
        _oldPayment = oldPayment;
    }

    public void Pay(double amount)
    {
        _oldPayment.MakePayment(amount); // Reusing old method
    }
}

// Client
class Program
{
    static void Main()
    {
        INewPayment payment = new PaymentAdapter(new OldPaymentSystem());
        payment.Pay(500); // ? Works with new interface
    }
}
