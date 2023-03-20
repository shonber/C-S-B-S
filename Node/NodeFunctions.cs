using System;

namespace cshrap
{
    public class NodeFunctions{
        public static Node<int> Calc(Node<char> l1){
            Node<int> l2 = null, temp;
            int x, y;
            char z;

            while (l1.HasNext()){
                // 48 --> 0 
                x = (int)l1.GetValue() - 48;
                y = (int)l1.GetNext().GetNext().GetValue() - 48;

                switch(l1.GetNext().GetValue()){
                    case '+':
                        temp = new Node<int> (x+y);
                        AddNode(l2, temp);
                        break;
                    case '-':
                        temp = new Node<int> (x-y);
                        AddNode(l2, temp);
                        break;
                    case '/':
                        temp = new Node<int> (x/y);
                        AddNode(l2, temp);
                        break;
                    case '*':
                        temp = new Node<int> (x*y);
                        AddNode(l2, temp);
                        break;
                }
                l1 = l1.GetNext();
            }
            return l2;
        }

        public static Node<int> AddNode(Node<int> nodeList, Node<int> add){
            Node<int> head = nodeList;

            if (head == null){
                head = add;
            }else{
                while(head.HasNext())
                    head = head.GetNext();
                head.SetNext(add);
            }
            return head;
        }

        public static Node<char> AddNode(Node<char> nodeList, Node<char> add){
            Node<char> head = nodeList;

            if (head == null){
                head = add;
            }else{
                while(head.HasNext())
                    head = head.GetNext();
                head.SetNext(add);
            }
            return head;
        }

        public static Node<string> IsSortedString(Node<string> l1){
            Node<string> pos = l1;

            while (pos.HasNext()){
                if (string.Compare(l1.GetValue(), pos.GetNext().GetValue()) == -1){
                    pos = pos.GetNext();
                }else{
                    return pos;
                }
            }
            return null;
        }

        public static int CountEven (Node<int> l1, Node<int> child){
            l1 = child;

            if(l1 == null){return 0;}
            
            if (l1.GetValue() % 2 == 0)
                return 1 + CountEven(l1, child.GetNext());
            return CountEven(l1, child.GetNext());
        }

        public static int DoubleIndexes (Node<int> l1){
            if(l1 == null){ return 0;}
            Console.WriteLine(l1.GetValue());
            return DoubleIndexes(l1.GetNext().GetNext());
        }

        public static int SumIndexesFromTwoPoints (Node<int> lst, Node<int> p, Node<int> q){
            lst = p;
            if(lst == null || lst == q){return 0;}
            return 1 + SumIndexesFromTwoPoints(lst, p.GetNext(), q);
        }

        // public static int MostRolled(Node<Backgammon> lst){
        //     int[] counters = {0,0,0,0,0,0,0};
        //     int max = 0, maxI = 0;

        //     while (lst != null){
        //         counters[lst.GetValue().GetDice1()]++;
        //         counters[lst.GetValue().GetDice2()]++;
        //         lst = lst.GetNext();
        //     }

        //     for (int i = 1; i < counters.Length; i++){
        //         if (counters[i] > max){
        //             maxI = i;
        //             max = counters[i];
        //         }
        //     }
        //     return maxI;
        // }

        // public static Node<char> CreateCharList(Node<TavNum> lst){
        //     Node<char> temp = lst, my_list = null, mit = null;

        //     while(temp != null){
        //         for (int i = 0; i < temp.GetValue().GetNum(); i++)
        //         {
        //             mit = new Node<char>(temp.GetValue().GetChar());
        //             AddNode(my_list, mit);
        //         }
        //         temp = temp.GetNext();
        //     }
        //     return my_list;
        // }


        // public static Node<Polynom> SumOfPolynomLists(Node<Polynom> lst1, Node<Polynom> lst2){
        //     Node<Polynom> result = null, p1 = lst1, p2 = lst2, p3 = result;
        //     bool flag = false;

        //     while (p1 != null){
        //         flag = false;
        //         while(p2 != null){
        //             if (p1.GetValue().GetN() == p2.GetValue().GetN()){
        //                 flag = true;
        //                 p3 = new Node<Polynom>(p1.GetValue().GetX() + p2.GetValue().GetX());
        //                 AddNode(result, p3);
        //             }
        //             p2 = p2.GetNext();
        //         }
        //         p1 = p1.GetNext();  

        //         if(!flag)
        //             AddNode(result, p1); 
        //     }
        //     p2 = lst2;
        //     while (p2 != null){
        //         if (!IsExists(result, p2.GetValue().GetN()))
        //             AddNode(result, p2);
        //         p2 = p2.GetNext();
        //     }
        //     return result;
        // }

        // public static Node<Polynom> AddNode(Node<Polynom> lst, Node<Polynom> p){
        //     Node<Polynom> head = lst;

        //     if (head == null){
        //         head = p;
        //     }else{
        //         while(head.GetNext() != null){
        //             head = head.GetNext();
        //         head.SetNext(p);
        //         }
        //     }
        //     return head;
        // }

        // public static bool IsExists(Node<Polynom> n, int value){
        //     while (n != null){
        //         if (n.GetValue().GetN() == value)
        //             return true;
        //         n = n.GetNext();
        //     }
        //     return false;
        // }
    }
}