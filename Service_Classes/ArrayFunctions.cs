using System;

public class ArrayFunctions{
    public static void BuildArray(int[] arr){
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("[!] Insert a number >>> ");
            arr[i] = int.Parse(Console.ReadLine());
        }
    }

    public static void BuildArrayRandom(int[] arr){
        Random rnd = new Random();

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(1,101);
        }
    }

    public static void ArrayReset(int[] arr){
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = 0;
        }
    }

    public static int MaxValue(int[] arr){
        int max = int.MinValue;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > max)
                max = arr[i];
        }

        return max;
    }

    public static int MinValue(int[] arr){
        int min = int.MaxValue;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < min)
                min = arr[i];
        }

        return min;
    }
    public static double Average(int[] arr){
        int sum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }

        return (sum / (double)arr.Length);
    }

    public static int AboveAverage(int[] arr){
        int counter = 0;
        double avg = ArrayFunctions.Average(arr);

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > avg)
                counter ++;
        }

        return counter;
    }

    public static int FindNull(int[] arr){
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == null)
            {
                return i;
            }
        }
        return -1;
    }
}