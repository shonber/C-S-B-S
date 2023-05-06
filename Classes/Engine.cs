public class Engine{
    private string company;
    private int horsePower;

    public Engine(string company, int horsePower){
        this.company = company;
        this.horsePower = horsePower;
    }

    public Engine(Engine engine){
        this.company = engine.GetCompany();
        this.horsePower = engine.GetHorsePower();
    }

    public string GetCompany() { return this.company; }
    public int GetHorsePower() { return this.horsePower; }

    public void SetCompany(string company) { this.company = company; }
    public void SetHorsePower(int horsePower) { this.horsePower = horsePower; }

    public bool Stronger(Engine e){
        if(this.horsePower > e.GetHorsePower())        
            return true;    
        else        
            return false;
    }
    public bool IsBMW(){
        if(this.company.Equals("Mercedes"))
            return true;    
        else        
            return false;
    }


    public override string ToString()
    {
        return $"Company: {this.company}" +
        $"Horse Power: {this.horsePower}";
    }
}