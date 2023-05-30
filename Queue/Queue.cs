using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Queue<T>
{
    private Node<T> first;
    private Node<T> last;
    public Queue()
    {
        this.first = null;
        this.last = null;
    }
    public void Insert(T x)
    {
        Node<T> temp = new Node<T>(x);
        if (first == null)
            first = temp;
        else last.SetNext(temp);
        this.last = temp;
    }
    public T Remove()
    {
        T x = first.GetValue();
        first = first.GetNext();
        if (first == null)
            last = null;
        return x;
    }
    public T Head()
    {
        return first.GetValue();
    }
    public bool IsEmpty()
    {
        return first == null;
    }
    public override string ToString()
    {
        if (this.IsEmpty())
            return "[]";

        Queue<T> ezer = new Queue<T>();
        string s = "[";
        T tmp;
        while (!this.IsEmpty())
        {
            tmp = this.Remove();
            s = s + tmp + ",";
            ezer.Insert(tmp);
        }
        while (!ezer.IsEmpty())
        {
            this.Insert(ezer.Remove());
        }
        s = s.Substring(0, s.Length - 1) + "]";
        return s;
    }
}