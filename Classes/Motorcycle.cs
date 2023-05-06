public class Motorcycle{
    private string company;
    private int numOfTires;
    private Tire tire;
    private Engine engine;

    public Motorcycle(string company, int numOfTires, Tire tire, Engine engine){
        this.company = company;
        this.numOfTires = numOfTires;
        this.engine = new Engine(engine);
        this.tire = new Tire(tire);
    }

    public Motorcycle(Motorcycle car){
        this.company = car.GetCompany();
        this.numOfTires = car.GetNumOfTires();
        this.engine = new Engine(car.GetEngine());
        this.tire = new Tire(car.GetTire());
    }

    public string GetCompany() { return this.company; }
    public int GetNumOfTires() { return this.numOfTires; }
    public Tire GetTire() { return this.tire; }
    public Engine GetEngine() { return this.engine; }

    public void SetCompany(string company) { this.company = company; }
    public void SetNumOfTires(int numOfTires) { this.numOfTires = numOfTires; }
    public void SetEngine(Engine engine) { this.engine = new Engine(engine); }
    public void SetTire(Tire tire) { this.tire = new Tire(tire); }
 

    public override string ToString()
    {
        return $"Company: {this.company}" +
        $"numOfTires: {this.numOfTires}" +
        $"Tire: {this.tire}" +
        $"Engine: {this.engine}";
    }
}