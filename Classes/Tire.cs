public class Tire{
    private string company;
    private double width;
    private double section;
    private double radius;

    public Tire(string company, double width, double section, double radius){
        this.company = company;
        this.width = width;
        this.section = section;
        this.radius = radius;
    }

    public Tire(Tire tire){
        this.company = tire.GetCompany();
        this.width = tire.GetWidth();
        this.section = tire.GetSection();
        this.radius = tire.GetRadius();
    }

    public string GetCompany() { return this.company; }
    public double GetWidth() { return this.width; }
    public double GetSection() { return this.section; }
    public double GetRadius() { return this.radius; }

    public void SetCompany(string company) { this.company = company; }
    public void SetWidth(double width) { this.width = width; }
    public void SetSection(double section) { this.section = section; }
    public void SetRadius(double radius) { this.radius = radius; }

    public Tire CopyTyre(){
        Tire newTyre = new Tire(this.company, this.width, this.section, this.radius);    
        return newTyre;           
    }
    public bool Bigger(Tire t){
        if (this.radius > t.GetRadius())        
            return true;    
        else        
            return false;
    }

    public override string ToString()
    {
        return $"Company: {this.company}" +
        $"Width: {this.width}" + 
        $"Section: {this.section}" + 
        $"Radius: {this.radius}";
    }
}