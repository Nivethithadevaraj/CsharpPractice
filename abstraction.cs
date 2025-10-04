using System;
abstract class Shape{
   public abstract double CalculateArea();
}
class Circle:Shape{
    private double radius;
    public Circle(double radius){
        this.radius=radius;
    }
    public override double CalculateArea(){
        return Math.PI*radius*radius;
    }
}
class Rectangle:Shape{
    private double length;
    private double width;
    public Rectangle(double length,double width){
        this.length=length;
        this.width=width;
    }
    public override double CalculateArea(){
        return length*width;
    }
}
class Program{
    static void Main(){
        Shape myCircle=new Circle(5);
        Shape myRectangle=new Rectangle(4,6);
        Console.WriteLine($"Area of Circle: {myCircle.CalculateArea()}");
        Console.WriteLine($"Area of Rectangle: {myRectangle.CalculateArea()}");
    }}