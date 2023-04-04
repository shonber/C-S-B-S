public class Book{
    // Properties
    private string title;
    private string author;
    private string publisher;
    private int year; // publish year
    private double cost;


    // Methods
    // Constructors
    public Book(){
        this.title = "";
        this.author = "";
        this.publisher = "";
        this.year = 0;
        this.cost = 0.0;
    }

    public Book(string t, string a, string p, int y, double c){
        this.title = t;
        this.author = a;
        this.publisher = p;
        this.year = y;
        this.cost = c;
    }

    public Book(Book book){
        this.title = book.GetTitle();
        this.author = book.GetAuthor();
        this.publisher = book.GetPublisher();
        this.year = book.GetYear();
        this.cost = book.GetCost();
    }

    // Getters
    public string GetTitle(){ return this.title; }
    public string GetAuthor(){ return this.author; }
    public string GetPublisher(){ return this.publisher; }
    public int GetYear(){ return this.year; }
    public double GetCost(){ return this.cost; }

    // Setters
    public void SetTitle(string title){ this.title = title; }
    public void SetAuthor(string author){ this.author = author; }
    public void SetPublisher(string publisher){ this.publisher = publisher; }
    public void SetYear(int year){ this.year = year; }
    public void SetCost(double cost){ this.cost = cost; }

    // ToString()
    public override string ToString()
    {
        return $"Book Title: {this.title}\n" + 
        $"Book Author: {this.author}\n" + 
        $"Book Publish Year: {this.year}\n" + 
        $"Book Publisher: {this.publisher}\n" + 
        $"Book Cost: {this.cost}\n";
    }
}