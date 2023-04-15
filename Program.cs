using System;

namespace C_S_B_S
{
    class Program
    {
        static void Main(string[] args)
        {
            // Binary Trees 
            // BinNode<int> bt = new BinNode<int>(1);

            // bt.SetLeft(new BinNode<int>(2));
            // bt.SetRight(new BinNode<int>(3));

            // bt.GetLeft().SetLeft(new BinNode<int>(4));
            // bt.GetLeft().SetRight(new BinNode<int>(5));

            // bt.GetRight().SetRight(new BinNode<int>(6));

            // Console.Write("PreOrder Scan: ");
            // BinNodeFunctions.PreOrderScan(bt); // 1 2 4 5 3 6

            // Console.WriteLine();

            // Console.Write("InOrder Scan: ");
            // BinNodeFunctions.InOrderScan(bt); // 4 2 5 1 3 6
                        
            // Console.WriteLine();

            // Console.Write("PostOrder Scan: ");
            // BinNodeFunctions.PostOrderScan(bt); // 4 5 2 6 3 1
            // Console.WriteLine();

            // Console.WriteLine(bt);

            // Console.WriteLine();

            // Console.WriteLine(BinNodeFunctions.Count2Child(bt));

            // Console.WriteLine();

            // Console.WriteLine(BinNodeFunctions.IsExists(bt, 6));


            // Node 
            // Node<char> n1 = new Node<char>('a', new Node<char>('b', new Node<char>('5', new Node<char>('$', new Node<char>('A', new Node<char>('4'))))));
            // Console.WriteLine();
            // Console.WriteLine($"Node<T> : {n1}");
            // Console.WriteLine(NodeFunctions.IsExists(n1, '5'));


            // IntNode 
            // IntNode n2 = new IntNode(3, new IntNode(0, new IntNode(5, new IntNode(7, new IntNode(9, new IntNode(10))))));
            // Console.WriteLine();
            // Console.WriteLine($"IntNode : {n2}");


            // Queue 


            // Song Class
            // Song[] playlist = new Song[50];
            // int taken_spaces = 0;

            // playlist[0] = new Song("abc", "AAAA", 5.41);
            // playlist[1] = new Song("def", "BBBB", 2.55);
            // taken_spaces = 2;

            // foreach (Song value in playlist)
            // {
            //     Console.WriteLine(value);
            // }
        }

        public static BilList GenerateBilist (Node<int> lst){
            Node<int> p1 = lst;
            Node<int> p2 = lst;

            while (p1 != null){
                while(p2 != null){
                    if (p1.GetValue() > p2.GetValue()){
                        p2 = p2.GetNext();
                    }
                }
                p1 = p1.GetNext();
            }
        }
    }
}
