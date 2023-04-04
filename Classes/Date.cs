using System;

public class Date{
    private int day;
    private int month;
    private int year;

    public Date(){
        this.day = DateTime.Now.Day;
        this.month = DateTime.Now.Month;
        this.year = DateTime.Now.Year;
    }

    public Date(int d, int m, int y){
        this.day = d;
        this.month = m;
        this.year = y;
    }

    public Date(Date date){
        this.day = date.GetDay();
        this.month = date.GetMonth();
        this.year = date.GetYear();
    }

    public int GetDay(){ return this.day; }
    public int GetMonth(){ return this.month; }
    public int GetYear(){ return this.year; }

    public void SetDay(int d){ this.day = d; }
    public void SetMonth(int m){ this.month = m; }
    public void SetYear(int y){ this.year = y; }

    public bool IsBefore(Date date){
        // טענת כניסה: הםעולה מקבלת עצם כפרמטר
        // טענת יציאה: הפעולה מחזירה אמת אם העצם הנוכחי לפני העצם כפרמטר.
        if (this.year > date.GetYear()){
            return false;
        } else if (this.year == date.GetYear()){
            if (this.month > date.GetMonth()){
                return false;
            } else if (this.month == date.GetMonth()){
                if (this.day > date.GetDay() || this.day == date.GetDay()){
                    return false;
                }
            }
        }

        return true;
    }

    public override string ToString()
    {
        return $"{this.day}/{this.month}/{this.year}";
    }
}