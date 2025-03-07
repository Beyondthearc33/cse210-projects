public class Square : Shape
{
private double _side;

public Square(string color, double side) :base(color)
{
    _side = side;
}
public override double getArea(){
    double area = _side * _side;
    return area;
}

}