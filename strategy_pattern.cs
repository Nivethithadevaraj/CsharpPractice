using System;   
public interface IShapeStrategy{
    void Draw();
}
public class CircleStrategy : IShapeStrategy{
    public void Draw() => Console.WriteLine("Drawing a Circle");
}
public class SquareStrategy : IShapeStrategy{
    public void Draw() => Console.WriteLine("Drawing a Square");
}
public class TriangleStrategy : IShapeStrategy{
    public void Draw() => Console.WriteLine("Drawing a Triangle");
}
public class ShapeContext{
    private IShapeStrategy strategy;
    public void SetStrategy(IShapeStrategy strategy){
        this.strategy = strategy;
    }
    public void DrawShape(){
        strategy.Draw();
    }}
class Program{
    static void Main(){
        ShapeContext context = new ShapeContext();
        context.SetStrategy(new CircleStrategy());
        context.DrawShape();
        context.SetStrategy(new SquareStrategy());
        context.DrawShape();
        context.SetStrategy(new TriangleStrategy());
        context.DrawShape();
    }}