using System;
using System.Linq;

namespace Numbers_Game
{
    class Program
    {
        //mthod that shows elemenents in array
        public static string GetNumbersInArray(int[] arr)
        {
            string str = "{ ";
            for (int i = 0; i < arr.Length; i++) 
            {
                str += $"{Convert.ToString(arr[i])}, ";
            }
            return $"{str}}}";
        }

        static void StartSequence()
        {
            int sum, product, quotient = 0;
            string input;

            try
            {
                Console.WriteLine("Welcome to my game! Let's do some math!");
                Console.WriteLine("Enter a number greater than zero");
                input = Console.ReadLine();
                int inputSize = Convert.ToInt32(input);
                int[] inputArray = new int[inputSize];
                
                //Call methods
                Populate(inputArray);
                sum = GetSum(inputArray);
                product = GetProduct(inputArray, GetSum(inputArray));
                quotient = Convert.ToInt32(GetQuotient(product));

                //Summary
                Console.WriteLine($"Your array is size: {inputSize}");
                Console.WriteLine($"The number in the array are: {GetNumbersInArray(inputArray)}");
                Console.WriteLine($"The sum of the array is: {sum}");
                Console.WriteLine($"{sum} * {product / sum} = {product}");
                Console.WriteLine($"{product} / {product / quotient} = {quotient}");
                
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Format Exception: {e.Message}");
            }
            catch (OverflowException e)
            {
                Console.WriteLine($"Overflow Exception: {e.Message}");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine($"Index out of range: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Default Exception: {e.Message}");
            }
        }

        static int[] Populate(int[] arr)
        {
            string input;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Please enter a number {i} of {arr.Length}");
                input = Console.ReadLine();
                int convertedInput = Convert.ToInt32(input);
                arr[i] = convertedInput;
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
            int product;

            Console.Write($"Select a random index number between 1 and {arr.Length} ");
            Console.Write($"to multiply {sum} with value: ");

            string inputString = Console.ReadLine();
            int randomNumber = Convert.ToInt32(inputString);

            Console.WriteLine($"You chose index: {randomNumber} with value: {arr[randomNumber]}");

            try
            {
                product = sum * arr[randomNumber];

            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            return product; 
        }

        static Decimal GetQuotient(int prod)
        {
            try
            {
                Console.WriteLine($"Enter a number to divide your product of {prod}: ");

                string input = Console.ReadLine();
                int convertedInput = Convert.ToInt32(input);
                
                return Decimal.Divide(prod, convertedInput);   
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
                Console.WriteLine($"Uh oh! Something went wrong. {e.Message}");
                throw;
            }
            finally
            {
                Console.WriteLine("Program is complete.");
            }
        }
    }
}
