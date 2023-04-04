
using System;

public class Student{
    private string firstName;
    private string lastName;
    private string id;
    private int[] grades;
    private Date birthDate;

    public Student(){
        this.firstName = "";
        this.lastName = "";
        this.id = "";
        this.birthDate = new Date();
        this.grades = new int[] {};
    }

    public Student(string fs, string ls, string id, Date bt, int[] grades){
        this.firstName = fs;
        this.lastName = ls;
        this.id = id;
        this.birthDate = new Date(bt);
        this.grades = CopyArr(grades);
    }

    public Student(Student student){
        this.firstName = student.GetFirstName();
        this.lastName = student.GetLastName();
        this.id = student.GetID();
        this.birthDate = new Date(student.GetBirthDate());
        this.grades = student.GetGrades();
    }

    public string GetFirstName(){ return this.firstName; }
    public string GetLastName(){ return this.lastName; }
    public string GetID(){ return this.id; }
    public Date GetBirthDate(){ return this.birthDate; }
    public int[] GetGrades(){ return this.grades; }
    public string GetGradesString(){
        string retVal = "[";
        int length = this.grades.Length;

        for (int i = 0; i < length; i++)
        {
            if (i == length - 1)
                retVal += $"{this.grades[i]}";
            else
                retVal += $"{this.grades[i]}, ";
        }

        return (retVal + "]"); 
    }

    public void SetFirstName(string fs){ this.firstName = fs; }
    public void SetLastName(string ls){ this.lastName = ls; }
    public void SetID(string id){ this.id = id; }
    public void SetBirthDate(Date d){ this.birthDate = new Date (d); }
    public void AddGrades(int grade){
        int[] newGrades = new int[this.grades.Length + 1];

        for (int i = 0; i < this.grades.Length; i++)
        {
            if (i == this.grades.Length - 1){
                newGrades[i] = this.grades[i];
                newGrades[i + 1] = grade;
            }else{
                newGrades[i] = this.grades[i];
            }
        }

        this.grades = CopyArr(newGrades);
    }
    
    public T[] CopyArr<T>(T[] arr){
        T[] newArr = new T[arr.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            newArr[i] = arr[i];
        }
        return newArr;
    }

    public double Avg(){
        if (this.grades.Length == 0)
            return 0.0;

        int sum = 0;

        for (int i = 0; i < this.grades.Length; i++)
        {
            sum += this.grades[i];
        }
        return (sum / this.grades.Length);
    }

    public override string ToString()
    {
        return $"First Name: {this.firstName}\n" + 
        $"Last Name: {this.lastName}\n" + 
        $"ID: {this.id}\n" + 
        $"Birth Date: {this.birthDate}\n" + 
        $"Grades: {this.GetGradesString()}\n" + 
        $"Grades Average: {this.Avg()}\n";
    }
}