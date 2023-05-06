public class Subject{
    private string subject;
    private string studentName;
    private int grade;

    public Subject(string name, string subject, int grade){
        this.studentName = name;
        this.subject = subject;
        this.grade = grade;
    }

    public string GetStudentName(){ return this.studentName; }
    public string GetSubject(){ return this.subject; }
    public int GetGrade(){ return this.grade; }

    public void SetStudentName(string name){ this.studentName = name; }
    public void SetSubject(string subject){ this.subject = subject; }
    public void SetGrade(int grade){ this.grade = grade; }

    public override string ToString()
    {
        return $"Subject Name: {this.subject}" +
        $"Student Name: {this.studentName}" +
        $"Grade: {this.grade}";
    }
}