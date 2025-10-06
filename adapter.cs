using System;
public class OldPaymentSystem
{
    public void MakePayment(double amount)
    {
        Console.WriteLine($"Payment of {amount} processed using Old System.");
    }
}
public interface INewPayment
{
    void Pay(double amount);
}
public class PaymentAdapter : INewPayment
{
    private readonly OldPaymentSystem _oldPayment;

    public PaymentAdapter(OldPaymentSystem oldPayment)
    {
        _oldPayment = oldPayment;
    }
    public void Pay(double amount)
    {
        _oldPayment.MakePayment(amount); 
    }
}
class Program
{
    static void Main()
    {
        INewPayment payment = new PaymentAdapter(new OldPaymentSystem());
        payment.Pay(500);
    }
}