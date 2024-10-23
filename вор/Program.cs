using System.Diagnostics;
using static System.Collections.Specialized.BitVector32;

class Program
{
    static void Main()
    {

        int[] numbers = new int[100000];
        Random rand = new Random(10);
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rand.Next();
        }
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        Cocktailsort(numbers);
        stopwatch.Stop();
        TimeSpan timespan = stopwatch.Elapsed;
        Console.WriteLine("отсортированный массив:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine(timespan);
    }
    static void Swap(ref int e1, ref int e2)
    {
        var temp = e1;
        e1 = e2;
        e2 = temp;
    }
    static int[] Cocktailsort(int[] array)
    {
        for (var i = 0; i < array.Length / 2; i++)
        {
            var swapFlag = false;
           
            for (var j = i; j < array.Length - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    Swap(ref array[j], ref array[j + 1]);
                    swapFlag = true;
                }
            }

           
            for (var j = array.Length - 2 - i; j > i; j--)
            {
                if (array[j - 1] > array[j])
                {
                    Swap(ref array[j - 1], ref array[j]);
                    swapFlag = true;
                }
            }

            
            if (!swapFlag)
            {
                break;
            }
        }

        return array;
    }
}