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
        // Left, Head, Right

        if (bt != null){
            PostOrderScan(bt.GetLeft());
            PostOrderScan(bt.GetRight());
            Console.Write(bt.GetValue() + " ");
        }
    }
}