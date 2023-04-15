
using System;

public class Square{
    private Point a, b, c, d;


    public Square(Point a, Point b, Point c, Point d){
        this.a = new Point(a);
        this.b = new Point(b);
        this.c = new Point(c);
        this.d = new Point(d);
    }

    public Square(Square square){
        this.a = new Point(square.GetA());
        this.b = new Point(square.GetB());
        this.c = new Point(square.GetC());
        this.d = new Point(square.GetD());
    }

    public Point GetA(){ return this.a; }
    public Point GetB(){ return this.b; }
    public Point GetC(){ return this.c; }
    public Point GetD(){ return this.d; }

    public void SetA(Point a){ this.a = new Point(a); }
    public void SetB(Point b){ this.b = new Point(b); }
    public void SetC(Point c){ this.c = new Point(c); }
    public void SetD(Point d){ this.d = new Point(d); }

    public double Perimeter(){
        return (4 * this.GetLength());
    }

    public double Area(){
        return Math.Pow(this.a.Distance(this.b), 2);
    }

    public double GetLength(){
        return this.a.Distance(this.b);
    }

    public Square CopySquare(){
        Square square = new Square(this.a, this.b, this.c, this.d);
        return square;
    }

    public override string ToString()
    {
        return $"A: {this.a}" +
        $"B: {this.b}" +
        $"C: {this.c}" +
        $"D: {this.d}";
    }
}