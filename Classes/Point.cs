public class Point{
    private int x;
    private int y;

    public Point(){
        this.x = 0;
        this.y = 0;
    }

    public Point(int x, int y){
        this.x = x;
        this.y = y;
    }

    public Point(Point point){
        this.x = point.GetX();
        this.y = point.GetY();
    }

    public int GetX(){ return this.x; }
    public int GetY(){ return this.y; }

    public void SetX(int x){ this.x = x; }
    public void SetY(int y){ this.y = y; }

    public override string ToString()
    {
        return $"({this.x},{this.y})";
    }
}