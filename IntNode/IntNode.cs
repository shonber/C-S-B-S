public class IntNode{
    private int value;
    private IntNode next;

    public IntNode(int v){
        this.value = v;
        this.next = null;
    }

    public IntNode(int v, IntNode n){
        this.value = v;
        this.next = n;
    }

    public int GetValue(){return this.value;}
    public IntNode GetNext(){return this.next;}

    public void SetValue(int v){this.value = v;}
    public void SetNext(IntNode n){this.next = n;}

    public bool HasNext(){
        if (this.next != null)
            return true;
        return false;
    }

    public override string ToString()
    {
        if (this.next == null){
            return this.value + " --> " + "null";
        }
        return this.value + " --> " + this.next;
    }
}