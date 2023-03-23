using System;

namespace C_S_B_S{
    public class NodeFunctions{
        public static Node<int> Calc(Node<char> lst){
            Node<char> p = lst;
            Node<int> resultLst = null, temp = null;
            int x, y;

            while (p.HasNext()){
                // 48 --> 0 
                x = (int)p.GetValue() - 48;
                y = (int)p.GetNext().GetNext().GetValue() - 48;

                switch(p.GetNext().GetValue()){
                    case '+':
                        temp = new Node<int> (x+y);
                        AddNode(resultLst, temp);
                        break;
                    case '-':
                        temp = new Node<int> (x-y);
                        AddNode(resultLst, temp);
                        break;
                    case '/':
                        temp = new Node<int> (x/y);
                        AddNode(resultLst, temp);
                        break;
                    case '*':
                        temp = new Node<int> (x*y);
                        AddNode(resultLst, temp);
                        break;
                }
                p = p.GetNext();
            }
            return resultLst;
        }

        public static Node<T> AddNode<T>(Node<T> lst, Node<T> node){
            Node<T> p = lst;

            if (p == null){
                p = node;
            }else{
                while(p.HasNext())
                    p = p.GetNext();
                p.SetNext(node);
            }
            return p;
        }

        public static Node<string> IsSortedString(Node<string> lst){
            // Checks if the list<string> nodes are sorted in the ABCs. 
            // Returns the string that destroys the UpSort.
            Node<string> p = lst;

            while (p.HasNext()){
                if (string.Compare(p.GetValue(), p.GetNext().GetValue()) == -1){
                    p = p.GetNext();
                }else{
                    return p;
                }
            }
            return null;
        }

        public static int CountEvenNodes (Node<int> lst, Node<int> node){
            lst = node;
            if(lst == null){
                return 0;
            }

            if (lst.GetValue() % 2 == 0)
                return 1 + CountEvenNodes(lst, node.GetNext());
            return CountEvenNodes(lst, node.GetNext());
        }

        public static int EvenIndexes (Node<int> lst){
            if(lst == null){ 
                return 0;
            }

            Console.WriteLine(lst.GetValue());
            return EvenIndexes(lst.GetNext().GetNext());
        }

        public static int SumRange (Node<int> lst, Node<int> p1, Node<int> p2){
            lst = p1;
            if(lst == null){
                return 0;
            }else if(lst == p2){
                return lst.GetValue();
            }
            return lst.GetValue() + SumRange(lst, p1.GetNext(), p2);
        }

        public static bool IsExists<T>(Node<T> lst, T value){
            if (lst == null){
                return false;
            }
            
            if (lst.GetValue().Equals(value)){
                return true;
            }
            return (IsExists(lst.GetNext(), value));
        }

        public static Node<T> CopyList<T>(Node<T> lst){
            Node<T> p = lst, newList = null;

            while(p != null){
                AddNode(newList, new Node<T>(p.GetValue()));
                p = p.GetNext();
            }
            return newList;
        }

        public static int SumList (Node<int> lst){
            Node<int> p = lst;
            if (p == null)
                return 0;

            return p.GetValue() + SumList(p.GetNext());
        }

        public static int CountLength<T> (Node<T> lst){
            Node<T> p = lst;
            if (p == null)
                return 0;

            return 1 + CountLength(p.GetNext());
        }

        public static double AvgFlowerHeights (Node<Flower> lst){
            Node<Flower> p = lst;
            int counter = CountLength(lst);
            double sum = 0;

            while (p != null){
                sum += p.GetValue().GetHeight();
            }

            return (sum / counter);
        }
    }
}