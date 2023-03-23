using System;

namespace C_S_B_S{
    public class IntNodeFunctions{
        public static int CountLength(IntNode lst){
            IntNode p = lst;
            int counter = 0;

            while (p != null){
                counter += 1;
                p = p.GetNext();
            }
            return counter;
        }

        public static int GetListSum(IntNode lst){
            int sum = 0;
            IntNode p = lst;
            
            while (p != null){
                sum += p.GetValue();
                p = p.GetNext();
            }
            return sum;
        }

        public static double GetListAvg(IntNode lst){
            double sum = 0;
            int count = 0;
            IntNode p = lst;
            
            while (p != null){
                count ++;
                sum += p.GetValue();
                p = p.GetNext();
            }
            return (sum/count);
        }

        public static IntNode GetMaxValueNode(IntNode lst){
            int maxValue = int.MinValue;
            IntNode maxNode = null;
            IntNode p = lst;

            while (p != null){
                if (p.GetValue() > maxValue){
                    maxValue = p.GetValue();
                    maxNode = p;
                }
                p = p.GetNext();    
            }
            return maxNode;
        }

        public static int GetMinValue(IntNode lst){
            int minValue = int.MaxValue;
            IntNode p = lst;

            while (p != null){
                if(p.GetValue() < minValue){
                    minValue = p.GetValue();
                }
                p = p.GetNext();
            }
            return minValue;
        }

        public static int GetValueOfIndex(IntNode lst, int index){
            IntNode p = lst;
            int length = CountLength(p);

            for (int i = 1; i <= length; i++)
            {
                if (i == index){
                    return p.GetValue();
                }
                else{
                    p = p.GetNext();
                }
            }
            return 0;
        }

        public static void GetEvenValues(IntNode lst){
            IntNode p = lst;

            while (p != null){
                if (p.GetValue() % 2 == 0)
                    Console.WriteLine(p.GetValue());
                p = p.GetNext();
            }
        }

        public static bool IsExists(IntNode lst, int value){
            IntNode p = lst;

            while (p != null){
                if (p.GetValue() == value)
                    return true;
                p = p.GetNext();
            }
            return false;
        }

        public static bool IsAscSorted(IntNode lst){
            IntNode p = lst;

            while (p.HasNext()){
                if (p.GetValue() > p.GetNext().GetValue())
                    return false;
                p = p.GetNext();
            }
            return true;
        }

        public static int CountFours(IntNode lst, int x){
            // returns the amount of sequences in the list of the given number
            int counter = 0;
            IntNode p = lst;

            if (p.GetValue() == x && p.HasNext())
                counter++;

            while (p.HasNext()){
                if(p.GetValue() == x){
                    if(p.GetNext().GetValue() == x){
                        p = p.GetNext();
                    }else{
                        counter++;
                    }
                }
                p = p.GetNext();
            }
            return counter;
        }

        public static void InsertToSortedList(IntNode lst, IntNode node){
            // The node will change because the argument is a pointer to the original
            // So the make sure the original list won't change we create a backup.
            IntNode p = lst, prevNode = null;

            while(node.GetValue() > p.GetValue())
                p = p.GetNext();

            prevNode = GetPrev(lst, p);
            node.SetNext(p);
            prevNode.SetNext(node);
        }

        public static IntNode GetPrev(IntNode lst, IntNode node){
            IntNode p = lst;

            if (p == node)
                return null;

            while (p.GetNext() != node)
                p = p.GetNext();
            return p;
        }

        public static string EvenAndOddCounter(IntNode lst){
            IntNode p = lst;
            int evenCounter = 0, oddCounter = 0;

            while (p != null){
                if ((p.GetValue() % 2) == 0)
                    evenCounter++;
                else
                    oddCounter++;
                p = p.GetNext();
            }

            if (evenCounter > oddCounter)
                return "even";

            if (evenCounter < oddCounter)
                return "odd";
            return "same";
        }
        
        public static void PrintAsc(IntNode lst){
            IntNode p = lst;

            while (p.HasNext()){
                if(p.GetValue() > p.GetNext().GetValue())
                    Console.WriteLine(p.GetValue());
                p = p.GetNext();
            }
        }

        public static bool IsBalanced(IntNode lst){
            IntNode p = lst;
            double avg = GetListAvg(p);
            int biggerCounter = 0, smallerCounter = 0;

            while (p != null){
                if (p.GetValue() > avg)
                    biggerCounter += 1;
                else if (p.GetValue() < avg)
                    smallerCounter += 1;
                p = p.GetNext();
            }

            if (biggerCounter == smallerCounter)
                return true;
            return false;
        }

        public static void PrintNodesRange(IntNode lst, int num1, int num2){
            int counter = 0;
            IntNode p = lst;

            while (p != null){
                if (counter > num1 && counter < num2)
                    Console.WriteLine(p);
                counter ++;
                p = p.GetNext();
            }
        }

        public static IntNode AddNodesOpposite(){
            int input = 0;
            IntNode lst = null, temp = null;
            
            while (input != -999){
                input = int.Parse(Console.ReadLine());
                temp = new IntNode(input);

                lst.SetNext(temp);
                lst = lst.GetNext();
            }
            return lst;
        }

        public static IntNode Random50NumbersMissing(IntNode n){
            // HERE
            IntNode newNode = null;
            IntNode pos = n;
            IntNode pos2 = n;
            int[] arr = new int[50];
            int[] arr2 = new int[50];
            int counter = 0;
            int number = 10;
            bool flag = false;

            while(pos != null){
                arr[counter] = pos.GetValue();
                counter ++;
                pos = pos.GetNext();
            }
            
            counter = 0;
            for (int i = 0; i < arr.Length; i++){
                if (number == arr[i]){
                    flag = true;
                    number ++;
                }

                if (flag == false){
                    arr2[counter] = number;
                    number ++;
                    counter ++;
                }
                flag = false;
            }

            for (int i = 0; i < arr2.Length; i++){
                newNode = new IntNode(arr2[i]);
                pos2.SetNext(newNode);
                pos2 = pos2.GetNext();
            }
            return pos2;
        }

        public static IntNode SequenceOfNum(int beginner, int num){
            IntNode list = new IntNode(beginner), node = null;

            for (int i = 0; i < num; i++)
            {
                node = new IntNode(beginner);
                AddNode(list, node);
                beginner ++;
                list = list.GetNext();
            }
            return list;
        }

        public static IntNode AddNode(IntNode nodeList, IntNode add){
            IntNode head = nodeList;

            if (head == null){
                head = add;
            }else{
                while(head.HasNext())
                    head = head.GetNext();
                head.SetNext(add);
            }
            return head;
        }

        public static void RemoveGivenNumber(IntNode n, int number){
            IntNode prev = null, start = n;

            while (start != null){
                if (start.GetValue() == number)
                {
                    prev = GetPrev(n, start);
                    prev.SetNext(n.GetNext());
                }
                start = start.GetNext();
            }
        }

        public static void InsertNode(IntNode chain, IntNode n, int pos){
            int count = 0, x = 0;
            IntNode prev = null;

            if (pos == 0){
                x = chain.GetValue();
                chain.SetValue(n.GetValue());
                n.SetValue(x);
                n.SetNext(chain.GetNext());
                chain.SetNext(n);
            }else if (pos != 0){
                while (chain != null && count < pos){
                    count ++;
                    prev = chain;
                    chain = chain.GetNext();
                }
                n.SetNext(chain);
                prev.SetNext(n);
            }
        }

        public static void RemoveNode(IntNode chain, int pos){
            int count = 0;
            IntNode prev = null;

            if (pos == 0){
                chain.SetNext(null);
            } else if (pos != 0){
                while (chain != null && count < pos){
                    count++;
                    prev = chain;
                    chain = chain.GetNext();
                }

                if (chain.GetNext() == null)
                    prev.SetNext(null);
                else
                    prev.SetNext(chain.GetNext());
            }
        }
    }
}