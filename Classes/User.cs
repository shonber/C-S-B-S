public class User{
    private string username;
    private string password;
    private int loginCounter;

    public User(string u, string p, int l){
        this.username = u;
        this.password = p;
        this.loginCounter = l;
    }

    public User(User user){
        this.username = user.GetUsername();
        this.password = user.GetPassword();
        this.loginCounter = user.GetLoginCounter();
    }

    public string GetUsername(){ return this.username; }
    public string GetPassword(){ return this.password; }
    public int GetLoginCounter(){ return this.loginCounter; }

    public void SetUsrname(string username){ this.username = username; }
    public void SetPassword(string password){ this.password = password; }
    public void SetLoginCounter(int loginCounter){ this.loginCounter = loginCounter; }

    public override string ToString()
    {
        return $"Username: {this.username}\n" + 
        $"Password: {this.password}\n" + 
        $"Login Counter: {this.loginCounter}\n";
    }
}