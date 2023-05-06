namespace C_S_B_S{
    public class Flower{
        private string name;
        private double height;
        private string color;
        private string season;

        public Flower(){
            this.name = "";
            this.height = 0.0;
            this.color = "";
            this.season = "";
        }

        public Flower(string n, double h, string c, string s){
            this.name = n;
            this.height = h;
            this.color = c;
            this.season = s;
        }

        public string GetName(){return this.name;}
        public double GetHeight(){return this.height;}
        public string GetColor(){return this.color;}
        public string GetSeason(){return this.season;}

        public void SetName(string n){this.name = n;}
        public void SetHeight(double h){this.height = h;}
        public void SetColor(string c){this.color = c;}
        public void SetSeason(string s){this.season = s;}
        
        public override string ToString()
        {
            return "Flower" +
            "________________________________" +
            $"\tName: {this.name}\n" +
            $"\tColor: {this.color}\n" +
            $"\tHeight: {this.height}\n" +
            $"\tSeason: {this.season}\n";
        }
    }
}