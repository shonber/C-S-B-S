
using System;

public class Circle{
    private double radius;
    private int centerX;
    private int centerY;

    public Circle(double r, int x, int y){
        this.radius = r;
        this.centerX = x;
        this.centerY = y;
    }

    public Circle(Circle circle){
        this.radius = circle.GetRadius();
        this.centerX = circle.GetCenterX();
        this.centerY = circle.GetCenterY();
    }

    public double GetRadius(){ return this.radius; }
    public int GetCenterX(){ return this.centerX; }
    public int GetCenterY(){ return this.centerY; }

    public void SetRadius(double r){ this.radius = r; }
    public void SetCenterX(int x){ this.centerX = x; }
    public void SetCenterY(int y){ this.centerY = y; }

    public double Perimeter(){
        return (2 * Math.PI * this.radius);
    }

    public double Area(){
        return (Math.PI * this.radius * this.radius);
    }

    public void MoveCircle(int numx, int numy){
        this.centerX += numx;
        this.centerY += numy;
    }

    public Circle CopyCircle(){
        Circle circle = new Circle(this.radius, this.centerX, this.centerY);
        return circle;
    }

    public override string ToString()
    {
        return $"Circle Radius: {this.radius}\n" + 
        $"Circle Center X: {this.centerX}\n" + 
        $"Circle Center Y: {this.centerY}\n";
    }
}