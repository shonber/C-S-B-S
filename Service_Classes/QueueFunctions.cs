public class QueueFunctions{
    public static Queue<string> Copy(Queue<string> q){
        Queue<string> temp = new Queue<string>();
        Queue<string> copy = new Queue<string>();

        while (!q.IsEmpty()){
            copy.Insert(q.Head());
            temp.Insert(q.Remove());
        }

        while (!temp.IsEmpty()){
            q.Insert(temp.Remove());
        }

        return copy;
    } 

    public static Queue<int> Copy(Queue<int> q){
        Queue<int> temp = new Queue<int>();
        Queue<int> copy = new Queue<int>();

        while (!q.IsEmpty()){
            copy.Insert(q.Head());
            temp.Insert(q.Remove());
        }

        while (!temp.IsEmpty()){
            q.Insert(temp.Remove());
        }

        return copy;
    } 

    public static void RemoveTav(Queue<char> q, char t){
        Queue<char> temp = new Queue<char>();

        while(!q.IsEmpty()){
            if (q.Head() == t)
                q.Remove();
            else
                temp.Insert(q.Remove());
        }

        while (!temp.IsEmpty()){
            q.Insert(temp.Remove());
        }            
    }

    public static void AddInt(Queue<int> q, int x){
        Queue<int> temp = new Queue<int>();
        bool flag = false;

        while(!q.IsEmpty()){
            if (q.Head() < x && !flag){
                flag = true;
                temp.Insert(x);
            }
            else
                temp.Insert(q.Remove());
        }

        while (!temp.IsEmpty()){
            q.Insert(temp.Remove());
        }            
    }

    public static int MinInt(Queue<int> q){
        Queue<int> temp = new Queue<int>();
        int x = q.Head();

        while(!q.IsEmpty()){
            if (x > q.Head())
                x = q.Head();
            temp.Insert(q.Remove());
        }

        while (!temp.IsEmpty()){
            q.Insert(temp.Remove());
        }  

        return x;          
    }

    public static int MaxInt(Queue<int> q){
        Queue<int> temp = new Queue<int>();
        int x = q.Head(); // 10

        while(!q.IsEmpty()){
            if (x < q.Head())
                x = q.Head();
            temp.Insert(q.Remove());
        }

        while (!temp.IsEmpty()){
            q.Insert(temp.Remove());
        }  

        return x;          
    }

    public static bool IsSequence<T>(Queue<T> q, T x){
        Queue<T> temp = new Queue<T>();
        bool flag = false;

        while(!q.IsEmpty()){
            if (flag && q.Head() == x)
                return true;

            if (q.Head() == x)
                flag = true;
                temp.Insert(q.Remove());
            else
                temp.Insert(q.Remove());
        }

        while (!temp.IsEmpty()){
            q.Insert(temp.Remove());
        }  
        return false;          
    }
    
    public static bool SameOrNot(Queue<int> q1, Queue<int> q2){
        Queue<int> temp1 = new Queue<int>();
        Queue<int> temp2 = new Queue<int>();

        while(!q1.IsEmpty()){
            while (!q2.IsEmpty()){
                if (q1.Head() != q2.Head())
                    return false;
                else
                    temp1.Insert(q1.Remove());
                    temp2.Insert(q2.Remove());
            }
        }

        while (!temp1.IsEmpty()){
            q1.Insert(temp1.Remove());
        }  
        while (!temp2.IsEmpty()){
            q2.Insert(temp2.Remove());
        } 

        return true;          
    }

    public static bool SameOrNotRecursive(Queue<int> q1, Queue<int> q2){
        Queue<int> p = Copy(q1);
        Queue<int> p1 = Copy(q2);

        Queue<int> p2 = new Queue<int>();
        Queue<int> p3 = new Queue<int>();


        if (p.IsEmpty() && p1.IsEmpty()){
            return true;
        } else {
            if (p1.Head() != p.Head()){
                return false;
            }

            p2.Insert(p.Remove());
            p3.Insert(p1.Remove());

            if ((p.IsEmpty() && !p1.IsEmpty() || (!p.IsEmpty() && p1.IsEmpty())))
                return false;
            return SameOrNotRecursive(p, p1);
        }
    }

    public static Queue<int> RemoveDuplicates(Queue<int> q){
        Queue<int> p = Copy(q);
        Queue<int> p2 = new Queue<int>();
        p2.Insert(p.Remove());

        Queue<int> x = new Queue<int>();
        while(!p.IsEmpty()){
            x.Insert(p.Remove());
            if (p.Head() != x.Head())
                p2.Insert(p.Remove());

            x.Remove();
        }

        return p;
    }

    public static bool XElements(int X, nODE)
}