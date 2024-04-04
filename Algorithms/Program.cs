namespace Algorithms
{
    class Program
    {
        static int Sum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        static int Factorial(int[] array)
        {
            int sum = 1;

            foreach (var item in array)
            {
                sum *= item;
            }
            return sum;
        }

        static int Fibonacci(int index)
        {
            int first = 0;
            int second = 1;

            for (int i = 0; i < index; i++)
            {
                int temp = first;
                first = second; 
                second = temp + first;
            }
            return first;
        }

        static int[] FibonacciSeries(int length)
        {
            int[] array = new int[length];

            for (int i = 0; length > i; i++)
            {
                array[i] = Fibonacci(i);
            }

            return array;
        }

        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int summed = Sum(numbers);

            Console.WriteLine($"The sum of the array is : {summed}");


            Console.WriteLine($"The factorial of {numbers.Last()} is {Factorial(numbers)}");


            Console.WriteLine($"The fibonacci numbers are {Fibonacci(0)} {Fibonacci(1)} {Fibonacci(2)} {Fibonacci(3)} {Fibonacci(4)} {Fibonacci(5)} {Fibonacci(6)} {Fibonacci(7)} {Fibonacci(8)}");

            int[] fibonacciNos = FibonacciSeries(20);

            foreach (var item in fibonacciNos)
            {
                Console.WriteLine(item + ", ");

            }
            Console.ReadLine();
        }
    }
}