


using Sort;
using System;
using System.Collections.Generic;

public static class Program{
    public static void Main()
    {
        Random rnd = new Random();
        BubbleSortLtR<int> bubbleSort = new BubbleSortLtR<int>(100, () => rnd.Next(0, 100));
        Console.Write("Start: ");
        bubbleSort.sortArray.ForEach(x => Console.Write(x+" "));
        Console.Write('\n');
        while (bubbleSort.SortSection())
        {
/*            bubbleSort.sortArray.ForEach(x => Console.Write(x + " "));
            Console.Write('\n');*/
        }
        Console.Write("End: ");
        bubbleSort.sortArray.ForEach(x => Console.Write(x + " "));
        Console.ReadKey();
    }
}