using System;
public interface IShape{
    void Draw();
}
public class Circle : IShape{
    public void Draw(){
        Console.WriteLine("Drawing a Circle.");
    }}
public class Square : IShape{
    public void Draw(){
        Console.WriteLine("Drawing a Square.");
    }}
public class Triangle : IShape{
    public void Draw(){
        Console.WriteLine("Drawing a Triangle.");
    }}
public class ShapeFactory{
    public IShape GetShape(string shapeType){
        if (shapeType.Equals("Circle", StringComparison.OrdinalIgnoreCase))
            return new Circle();
        else if (shapeType.Equals("Square", StringComparison.OrdinalIgnoreCase))
            return new Square();
        else if (shapeType.Equals("Triangle", StringComparison.OrdinalIgnoreCase))
            return new Triangle();
        else
            return null;
    }}
class Program{
    static void Main(){
        ShapeFactory factory = new ShapeFactory();
        IShape shape1 = factory.GetShape("Circle");
        shape1.Draw();
        IShape shape2 = factory.GetShape("Square");
        shape2.Draw();
        IShape shape3 = factory.GetShape("Triangle");
        shape3.Draw();
    }}