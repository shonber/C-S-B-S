public class BinNode<T>
{
    private T value;
    private BinNode<T> left;
    private BinNode<T> right;

    public BinNode(T value)
    {
        this.value = value;
        this.left = null;
        this.right = null;
    }
    public BinNode(BinNode<T> left, T value, BinNode<T> right)
    {
        this.value = value;
        this.left = left;
        this.right = right;
    }
    public T GetValue()
    {
        return value;
    }
    public BinNode<T> GetLeft()
    {
        return left;
    }
    public BinNode<T> GetRight()
    {
        return right;
    }
    public void SetValue(T value)
    {
        this.value = value;
    }
    public void SetLeft(BinNode<T> left)
    {
        this.left = left;
    }
    public void SetRight(BinNode<T> right)
    {
        this.right = right;
    }
    public override string ToString()
    {
        return "( " + left + " " + value + " " + right + " )";
    }
}