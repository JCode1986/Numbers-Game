using System;

namespace Numbers_Game
{
    class Program
    {
        //mthod that shows elemenents in array
        public static string GetNumbersInArray(int[] arr)
        {
            string str = "{ ";
            foreach(int num in arr) 
            {
                str += $"{Convert.ToString(num)}, ";
            }
            return $"{str}}}";
        }

        static void StartSequence()
        {
            int inputSize = 0;
            int[] inputArray = new int[inputSize];
            int sum = 0;
            int product = 0;
            int quotient = 0;
            
            try
            {
                Console.WriteLine("Welcome to my game! Let's do some math!");
                Console.WriteLine("Enter a number greater than zero");
                inputSize = Convert.ToInt32(Console.ReadLine());
                inputArray = new int[inputSize];
                
                Populate(inputArray);
                sum = GetSum(inputArray);
                product = GetProduct(inputArray, GetSum(inputArray));
                quotient = Convert.ToInt32(GetQuotient(product));
                
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Format Exception: {e.Message}");
            }
            catch (OverflowException e)
            {
                Console.WriteLine($"Overflow Exception: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Default Exception: {e.Message}");
            }
            Console.WriteLine($"Your array is size: {inputSize}");
            Console.WriteLine($"The number in the array are: {GetNumbersInArray(inputArray)}");
            Console.WriteLine($"The sum of the array is: {sum}");
            Console.WriteLine($"{sum} * = {product}");
            Console.WriteLine($"{product} / = {quotient}");
        }

        static int[] Populate(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Please enter a number {i}/{arr.Length}");
                int input = Convert.ToInt32(Console.ReadLine());
                arr[i] = input;
                Console.WriteLine(GetNumbersInArray(arr));
            }
            return arr;
        }

        static int GetSum(int[] arr)
        {
            int sum = 0;
            foreach(int num in arr)
            {
                sum += num;
            }
            if (sum < 20) 
            {
                throw (new Exception($"Value of {sum} is too low"));
            }
            return sum;
        }
        
        static int GetProduct(int [] arr, int sum)
        {
            int product = 1;
            try
            {
                Console.Write($"Select a random index number between 0 and {arr.Length - 1} ");
                Console.Write($"to multiply {sum} with value: ");
                int input = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"You chose index: {input} with value: {arr[input]}");
                product = GetSum(arr) * arr[input];
                return product; 
            }
            catch (OverflowException e)
            {
                Console.WriteLine($"Index out of range: {e.Message}");
                throw;
            }
        }

        static Decimal GetQuotient(int prod)
        {
            try
            {
                Console.WriteLine($"Enter a number to divide your product of {prod} by: ");
                int input = Convert.ToInt32(Console.ReadLine());
                return Decimal.Divide(prod, input);   
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine ($"Cannot divide by 0: {e.Message}");
                return 0;
            }
        }

        static void Main(string[] args)
        {
            try
            {
                StartSequence();
            }
            catch (Exception e)
            {
                Console.WriteLine($"I am telling you 'nicely' that you did something wrong: {e.Message}");
                throw;
            }
            finally
            {
                Console.WriteLine("Program is complete.");
            }
        }
    }
}
