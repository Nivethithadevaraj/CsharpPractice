using System;
interface IShape{
    double CalculateArea();
}
class Circle:IShape{
    private double radius;
    public Circle(double radius){
        this.radius=radius;
    }
    public double CalculateArea(){
        return Math.PI*radius*radius;
    }
}
class Rectangle:IShape{
    private double length;
    private double width;
    public Rectangle(double length,double width){
        this.length=length;
        this.width=width;
    }
    public double CalculateArea(){
        return length*width;
    }
}
class Program{
    static void Main(){
        IShape myCircle=new Circle(5);
        IShape myRectangle=new Rectangle(4,6);
        Console.WriteLine($"Area of Circle: {myCircle.CalculateArea()}");
        Console.WriteLine($"Area of Rectangle: {myRectangle.CalculateArea()}");
    }}