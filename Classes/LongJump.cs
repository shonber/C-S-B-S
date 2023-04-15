public class LongJump{
    private string name;
    private double personalBest;
    private double[] results;
    private int jumpsCounter;
    private static int jumpers = 0;

    public LongJump(string name){
        this.name = name;
        this.personalBest = 0;
        this.jumpsCounter = 0;
        this.results = new double[3];

        for (int i = 0; i < this.results.Length; i++)
        {
            this.results[i] = 0;
        }

        jumpers++;
    }

    public int GetPersonalBest(){
        int max = int.MinValue;

        foreach (int record in this.results)
        {
            if (record > max)
                max = record;
        }

        return max;
    }

    public static int GetJumpers(){
        return jumpers;
    }
    public int CountInvalidJumps(){
        int counter = 0;
        for (int i = 0; i < this.jumpsCounter; i++)
            if (this.results[i] == -1)
                counter++;
        return counter;
    }

    public void InvalidJump() {
        if (this.jumpsCounter < 3)
        {
            this.results[jumpsCounter] = -1;
            this.jumpsCounter++;
        }
    }

    public void ValidJump(double jumpDistance) {
        
        if (this.jumpsCounter < 3)
        {
            this.results[jumpsCounter] = jumpDistance;
            this.jumpsCounter++;
        }
    }

    public override string ToString()
    {
        string result = "[";
        for (int i = 0; i < this.results.Length; i++)
        {
            if (i == this.results.Length - 1)
            {
                result += $"{this.results[i]}]";
            }else{
                result += $"{this.results[i]}, ";
            }
        }
        return result;
    }

}