using System;
using System.Collections.Generic;
public class NewsPublisher{
    private List<ISubscriber> subscribers = new List<ISubscriber>();
    public void Subscribe(ISubscriber subscriber)
    {
        subscribers.Add(subscriber);
    }
    public void Unsubscribe(ISubscriber subscriber)
    {
        subscribers.Remove(subscriber);
    }
    public void Notify(string news)
    {
        foreach (var subscriber in subscribers)
        {
            subscriber.Update(news);
        }
    }}
public interface ISubscriber{
    void Update(string news);
}
public class EmailSubscriber : ISubscriber
{
    private string name;
    public EmailSubscriber(string name)
    {
        this.name = name;
    }
    public void Update(string news)
    {
        Console.WriteLine($"{name} received Email: {news}");
    }}
public class SmsSubscriber : ISubscriber{
    private string name;
    public SmsSubscriber(string name){
        this.name = name;
    }
    public void Update(string news){
        Console.WriteLine($"{name} received SMS: {news}");
    }}
class Program{
    static void Main(){
        NewsPublisher publisher = new NewsPublisher();
        ISubscriber s1 = new EmailSubscriber("Nivi");
        ISubscriber s2 = new SmsSubscriber("Arun");
        ISubscriber s3 = new EmailSubscriber("Meena");
        publisher.Subscribe(s1);
        publisher.Subscribe(s2);
        publisher.Subscribe(s3);
        publisher.Notify("Breaking News: New C# Design Pattern released!");
        publisher.Unsubscribe(s2);
        publisher.Notify("Update: Observer pattern");
    }}