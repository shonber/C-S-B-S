
using System;

public class Triangle{
    private Point a, b, c;


    public Triangle(Point a, Point b, Point c){
        this.a = new Point(a);
        this.b = new Point(b);
        this.c = new Point(c);
    }

    public Triangle(Triangle triangle){
        this.a = new Point(triangle.GetA());
        this.b = new Point(triangle.GetB());
        this.c = new Point(triangle.GetC());
    }

    public Point GetA(){ return this.a; }
    public Point GetB(){ return this.b; }
    public Point GetC(){ return this.c; }

    public void SetA(Point a){ this.a = new Point(a); }
    public void SetB(Point b){ this.b = new Point(b); }
    public void SetC(Point c){ this.c = new Point(c); }

    public double Perimeter(){
        double ab = this.a.Distance(this.b);
        double ac = this.a.Distance(this.c);
        double bc = this.b.Distance(this.c);

        return (ab + ac + bc);
    }

    public double Area(){
        double p = this.Perimeter();
        return (0.25 * Math.Sqrt(p * (p - 2 * this.GetAB()) * (p - 2 * this.GetAC()) * (p - 2 * this.GetBC())));

    }

    public double GetAB(){
        return this.a.Distance(this.b);
    }
    public double GetAC(){
        return this.a.Distance(this.c);
    }
    public double GetBC(){
        return this.b.Distance(this.c);
    }

    public Triangle CopyTriangle(){
        Triangle triangle = new Triangle(this.a, this.b, this.c);
        return triangle;
    }

    public override string ToString()
    {
        return $"A: {this.a}" +
        $"B: {this.b}" +
        $"C: {this.c}";
    }
}