using System;

public class Scout{
    // Properties
    private string name;
    private string phoneNumber;
    private int yearOfBirth;
    private int joinedScouts;


    // Methods
    // Constructors
    public Scout(){
        this.name = "";
        this.phoneNumber = "";
        this.yearOfBirth = 0;
        this.joinedScouts = 0;
    }

    public Scout(string n, string p, int y, int js){
        this.name = n;
        this.phoneNumber = p;
        this.yearOfBirth = y;
        this.joinedScouts = js;
    }

    public Scout(Scout scout){
        this.name = scout.GetName();
        this.phoneNumber = scout.GetNumber();
        this.yearOfBirth = scout.GetYear();
        this.joinedScouts = scout.GetJoinedScouts();
    }

    // Getters
    public string GetName(){ return this.name; }
    public string GetNumber(){ return this.phoneNumber; }
    public int GetJoinedScouts(){ return this.joinedScouts; }
    public int GetYear(){ return this.yearOfBirth; }

    // Setters
    public void SetTitle(string name){ this.name = name; }
    public void SetAuthor(string number){ this.phoneNumber = number; }
    public void SetPublisher(int js){ this.joinedScouts = js; }
    public void SetYear(int year){ this.joinedScouts = year; }

    // Additional Methods
    public int Age(){
        int currentYear = DateTime.Now.Year;
        return (currentYear - yearOfBirth);
    }

    public int YearsInScouts(){
        int currentYear = DateTime.Now.Year;
        return (currentYear - this.joinedScouts);
    }

    // ToString()
    public override string ToString()
    {
        return $"Name: {this.name}\n" + 
        $"Mobile Number: {this.phoneNumber}\n" + 
        $"Birth Year: {this.yearOfBirth}\n" + 
        $"Joined: {this.joinedScouts}\n";
    }
}