using System;

class Program
{
    static void Main()
    {
        int[] myArray = { 1, 2, 3, 4, 5 };
        PrintArrayReversed(myArray, myArray.Length - 1);
    }

    static void PrintArrayReversed(int[] arr, int index)
    {
        if (index >= 0)
        {
            Console.WriteLine(arr[index]);
            PrintArrayReversed(arr, index - 1);
        }
    }
}
