using System;

public class Product{
    private int id;
    private double weight;
    private double price;
    private string shortDescription;

    public Product(){
        this.id = 0;
        this.weight = 0.0;
        this.price = 0.0;
        this.shortDescription = "";
    }

    public Product(int id, double weight, double price, string shortDesc){
        this.id = id;
        this.weight = weight;
        this.price = price;
        this.shortDescription = shortDesc;
    }

    public Product(Product p){
        this.id = p.GetID();
        this.weight = p.GetWeight();
        this.price = p.GetPrice();
        this.shortDescription = p.GetShortDesc();
    }

    // Getters
    public int GetID(){ return this.id; }
    public double GetWeight(){ return this.weight; }
    public double GetPrice(){ return this.price; }
    public string GetShortDesc(){ return this.shortDescription; }

    // Setters 
    public void SetID(int id){ this.id = id; }
    public void SetWeight(double weight){ this.weight = weight; }
    public void SetPrice(double price){ this.price = price; }
    public void SetShortDesc(string shortDesc){ this.shortDescription = shortDesc; }

    public void ComparePrices(Product p){
        // טענת כניסה: הפעולנ מקבלת עצם כפרמטר
        // טענת יציאה: הפעולה מדפיסה איזה מחיר יותר גדול או שהם שווים
        if (this.price > p.GetPrice())
            Console.WriteLine($"{this.id} product price is bigger than {p.GetID()}'s price");
        else if (this.price < p.GetPrice())
            Console.WriteLine($"{this.id} product price is smaller than {p.GetID()}'s price");
        else
            Console.WriteLine($"The prices are the same");
    }

    public Product CopyProduct(){
        // הפעולה במחלקה שיצרנו
        Product p = new Product(this.id, this.weight, this.price, this.shortDescription);
        return p;
    }
    
    // ToString()
    public override string ToString()
    {
        return $"Product Barcode: {this.id}\n" + 
        $"Product Price: {this.price}\n" + 
        $"Product Weight: {this.weight}\n" + 
        $"Product Description: {this.shortDescription}\n";
    }
}