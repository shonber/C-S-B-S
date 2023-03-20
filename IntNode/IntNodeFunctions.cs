using System;

public class IntNodeFunctions{
    public static int GetIndexCount(IntNode n){
        int counter = 0;

        while (n != null){
            counter += 1;
            n = n.GetNext();
        }
        return counter;
    }

    public static int GetSum(IntNode n){
        int sum = 0;
        
        while (n != null){
            sum += n.GetValue();
            n = n.GetNext();
        }
        return sum;
    }

    public static double GetAvg(IntNode n){
        double sum = 0;
        int count = 0;
        
        while (n != null){
            count ++;
            sum += n.GetValue();
            n = n.GetNext();
        }
        return (sum/count);
    }

    public static IntNode GetMaxValue(IntNode n){
        int maxValue = int.MinValue;
        IntNode maxNode = null;

        while (n != null){
            if (n.GetValue() > maxValue){
                maxValue = n.GetValue();
                maxNode = n;
            }
            n = n.GetNext();    
        }
        return maxNode;
    }

    public static int GetMinValue(IntNode n){
        int minValue = int.MaxValue;
        IntNode minNode = null;

        while (n != null){
            if(n.GetValue() < minValue){
                minValue = n.GetValue();
                minNode = n;
            }
            n = n.GetNext();
        }
        return minValue;
    }

    public static int GetValueOfIndex(IntNode n, int index){
        int length = GetIndexCount(n);

        for (int i = 1; i <= length; i++)
        {
            if (i == index){
                return n.GetValue();
            }
            else{
                n = n.GetNext();
            }
        }
        return 0;
    }

    public static void GetEvenValues(IntNode n){
        while (n != null){
            if (n.GetValue() % 2 == 0)
                Console.WriteLine(n.GetValue());
            n = n.GetNext();
        }
    }

    public static bool IsExists(IntNode n, int value){
        while (n != null){
            if (n.GetValue() == value)
                return true;
            n = n.GetNext();
        }
        return false;
    }

    public static bool IsUpSorted(IntNode n){
        while (n.HasNext()){
            if (n.GetValue() > n.GetNext().GetValue())
                return false;
            n = n.GetNext();
        }
        return true;
    }

    public static int CountFours(IntNode n, int x){
        // returns the amount of sequences in the list of the given number
        int counter = 0;
        if (n.GetValue() == x && n.GetNext() != null)
            counter++;

        while (n.HasNext()){
            if(n.GetValue() == x){
                if(n.GetNext().GetValue() == x){
                    n = n.GetNext();
                }else{
                    counter++;
                }
            }
            n = n.GetNext();
        }
        return counter;
    }

    public static void InsertToSortedList(IntNode n, IntNode n1){
    // The node will change because the argument is a pointer to the original
        IntNode pos = n, prevNode = null;

        while(n1.GetValue() > pos.GetValue())
            pos = pos.GetNext();

        prevNode = GetPrev(n, pos);
        n1.SetNext(pos);
        prevNode.SetNext(n1);
    }

    public static IntNode GetPrev(IntNode start, IntNode n){
        if (start == n)
            return null;

        while (start.GetNext() != n)
            start = start.GetNext();
        return start;
    }

    public static string GetEvenOddSame(IntNode n){
        int evenCounter = 0, oddCounter = 0;

        while (n.GetNext() != null){
            if ((n.GetValue() % 2) == 0)
                evenCounter++;
            else
                oddCounter++;
            n = n.GetNext();
        }

        if (evenCounter > oddCounter)
            return "z";

        if (evenCounter < oddCounter)
            return "e";
        return "s";
    }
    
    public static void AllBiggerPrev(IntNode n){
        while (n.HasNext()){
            if(n.GetValue() > n.GetNext().GetValue())
                Console.WriteLine(n.GetValue());
            n = n.GetNext();
        }
    }

    public static bool IsBalanced(IntNode n){
        double avg = GetAvg(n);
        int biggerCounter = 0, smallerCounter = 0;

        while (n.GetNext() != null){
            if (n.GetValue() > avg)
                biggerCounter += 1;
            else if (n.GetValue() < avg)
                smallerCounter += 1;
            n = n.GetNext();
        }

        if (biggerCounter == smallerCounter)
            return true;
        return false;
    }

    public static void PrintRange(IntNode n, int num1, int num2){
        int counter = 0;

        while (n.GetNext() != null){
            if (counter > num1 && counter < num2)
                Console.WriteLine(n);
            counter ++;
            n = n.GetNext();
        }
    }

    public static IntNode AddNodesOpposite(){
        int inp = 0;
        IntNode n = null, temp = null;
        
        while (inp != -999){
            inp = int.Parse(Console.ReadLine());
            temp = new IntNode(inp);

            n.SetNext(temp);
            n = n.GetNext();
        }
        return n;
    }

    public static IntNode Random50NumbersMissing(IntNode n){
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