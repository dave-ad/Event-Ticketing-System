class Program
{

    static bool HasValueAboveTen(int[] collection)
    {
        for (int i = 0; i < collection.Length; i++)
        {
            if (collection[i] > 10)
                return true;
        }
        return false;
    }

    static bool HasValueAbove(int[] collection, int value = 0)
    {
        for (int i = 0; i < collection.Length; i++)
        {
            if (collection[i] > value)
                return true;
        }

        return false;
    }

    static bool Decide(int[] collection, Func<int, bool> condition)
    {
        for (int i = 0; i < collection.Length; i++)
        {
            if (condition(collection[i]))
                return true;
        }
        return false;
    }

    static bool IsNegative(int number)
    {
        if (number < 0)
            return true;
        else
            return false;
    }

    static void Main(string[] args)
    {
        // Making Decisions 
        // Checking if our collection has a certian type of element
        // We need: collection, condition

        int[] arrays = { 0, 1, 2, 3, 4, 5, 6, 7, 8, -9, 10};

        Console.WriteLine($"The collection has an element that is higher than ten : {HasValueAboveTen(arrays)}");

        //int index = 3;
        //bool hasValueOverThree = HasValueAbove(arrays, index);
        //Console.WriteLine($"The collection has value above {index} ; {hasValueOverThree}");
        Console.WriteLine($"The only number above 0 ; {HasValueAbove(arrays)}");

        bool hasNegative = Decide(arrays, IsNegative);
        Console.WriteLine($"The collection has a negative number {hasNegative}");

        Console.ReadLine();
    }
}