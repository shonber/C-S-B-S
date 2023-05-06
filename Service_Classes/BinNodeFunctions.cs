using System;

public class BinNodeFunctions{
    public static int CountIntersections<T>(BinNode<T> bt){
        if (bt == null)
            return 0;

        if (bt.GetLeft() == null && bt.GetRight() == null)
            return 1;
        
        return 1 + CountIntersections(bt.GetLeft()) + CountIntersections(bt.GetRight());
    }

    public static int CountIntersectionsValues(BinNode<int> bt){
        if (bt == null)
            return 0;

        if (bt.GetLeft() == null && bt.GetRight() == null)
            return bt.GetValue();
        
        return bt.GetValue() + CountIntersectionsValues(bt.GetLeft()) + CountIntersectionsValues(bt.GetRight());
    }

    public static int BiggestValue(BinNode<int> bt, int maxNum=0){
        if (bt == null)
            return maxNum;

        maxNum = Math.Max(bt.GetValue(), maxNum);

        return Math.Max(Math.Max(BiggestValue(bt.GetLeft(), maxNum), maxNum), Math.Max(BiggestValue(bt.GetRight(), maxNum), maxNum));
    }

    public static void PreOrderScan<T>(BinNode<T> bt){
        // Head, Left, Right

        if (bt != null){
            Console.Write(bt.GetValue() + " ");
            PreOrderScan(bt.GetLeft());
            PreOrderScan(bt.GetRight());
        }
    }

    public static void InOrderScan<T>(BinNode<T> bt){
        // Left, Head, Right

        if (bt != null){
            InOrderScan(bt.GetLeft());
            Console.Write(bt.GetValue() + " ");
            InOrderScan(bt.GetRight());
        }
    }

    public static void PostOrderScan<T>(BinNode<T> bt){
        // Left, Right, Head

        if (bt != null){
            PostOrderScan(bt.GetLeft());
            PostOrderScan(bt.GetRight());
            Console.Write(bt.GetValue() + " ");
        }
    }

    public static int Count2Child<T>(BinNode<T> bt){
        if (bt != null){
            if (bt.GetLeft() != null && bt.GetRight() != null)
                if (!IsLeaf(bt.GetLeft()) && !IsLeaf(bt.GetRight())){
                    return Count2Child(bt.GetLeft()) + Count2Child(bt.GetRight()) + 1;
                }
                return Count2Child(bt.GetLeft()) + Count2Child(bt.GetRight());
        }
        return 0;
    }

    public static bool IsLeaf<T>(BinNode<T> bt){
        if (bt.GetLeft() == null && bt.GetRight() == null)
            return true;
        return false;
    }
    
    public static bool IsExists<T>(BinNode<T> bt, T value){
        if (bt != null){
            if (bt.GetValue().Equals(value))
                return true;
            return (IsExists(bt.GetLeft(), value) || IsExists(bt.GetRight(), value));
        }
        return false;
    }

    public static bool IsContained<T>(BinNode<T> bt1, BinNode<T> bt2){
        // Checks if all bt2 nodes are inside bt1
        if (bt2 == null){
            return false;
        }
        if (!IsExists(bt1, bt2.GetValue())){
            return false;
        }
        return (IsContained(bt1, bt2.GetLeft()) || IsContained(bt1, bt2.GetRight()));
    }
}