using System;

namespace BinaryTrees
{
    class Program
    {
        // Binary Tree program class
        static void Main(string[] args)
        {
            BinNode<int> bt = new BinNode<int>(1);

            bt.SetLeft(new BinNode<int>(2));
            bt.SetRight(new BinNode<int>(3));

            bt.GetLeft().SetLeft(new BinNode<int>(4));
            bt.GetLeft().SetRight(new BinNode<int>(5));

            bt.GetRight().SetRight(new BinNode<int>(6));

            Console.WriteLine(BinNodeFunctions.CountIntersections(bt));
            Console.WriteLine(BinNodeFunctions.CountIntersectionsValues(bt));
            Console.WriteLine(BinNodeFunctions.BiggestValue(bt));

            Console.Write("PreOrder Scan: ");
            BinNodeFunctions.PreOrderScan(bt); // 1 2 4 5 3 6

            Console.WriteLine();

            Console.Write("InOrder Scan: ");
            BinNodeFunctions.InOrderScan(bt); // 4 2 5 1 3 6
                        
            Console.WriteLine();

            Console.Write("PostOrder Scan: ");
            BinNodeFunctions.PostOrderScan(bt); // 4 5 2 6 3 1
        }
    }
}
