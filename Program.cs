using System;

namespace Numbers_Game
{
    class Program
    {
        //mthod that shows elemenents in array
        public static string GetNumbersInArray(int[] arr)
        {
            string str = "Array: { ";
            foreach(int num in arr) 
            {
                str += $"{Convert.ToString(num)}, ";
            }
            return $"{str}}}";
        }

        /*-------Prompt user to "Enter a number greater than zero"
        -----------Utilize the Convert.ToInt32() method to convert the user’s input to an integer.
        ------------Instantiate a new integer array that is the size the user just inputted.
        ---------Call the Populate method.
        ------arguments: integer array
        Capture the sum by calling the GetSum method.
        arguments: integer array
        Capture the product by calling the GetProduct method.
        integer array and integer sum
        Capture the quotient by calling the GetQuotient method.
        arguments: integer product
        To complete the method, output to the console the details of all these values. Make sure that your output contains the same information presented in the example below. Pay attention to line breaks!
        */
        static void StartSequence()
        {
            try
            {
                Console.WriteLine("Welcome to my game! Let's do some math!");
                Console.WriteLine("Enter a number greater than zero");
                int sizeInput = Convert.ToInt32(Console.ReadLine());
                int [] inputArray = new int[sizeInput];
                Populate(inputArray);
                Console.WriteLine(GetSum(inputArray));
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        static int[] Populate(int[] arr)
        {
            try
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine($"Please enter a number {i}/{arr.Length}");
                    int input = Convert.ToInt32(Console.ReadLine());
                    arr[i] = input;
                    Console.WriteLine(GetNumbersInArray(arr));
                }
            }
            catch (Exception)
            {
                
                throw;
            }
            return arr;
        }

        /*the logic within the method should:
        ------Declare an integer variable named sum
        ------Iterate through the array and populate the sum variable with the sum of all the numbers together.
        Add the capability to throw a custom exception if the sum is less than 20, with the message “Value of {sum} is too low”. (replace {sum} with the actual sum of the variable).
        return the sum.
        Expected Exceptions:
        No Try/Catch required since no expected exceptions will be caught. We will have our custom exception be caught in lower levels of the callstack.
        */
        static int GetSum(int[] arr)
        {
            int sum = 0;
            try
            {
                foreach(int num in arr)
                {
                    sum += num;
                }
            }
            catch (Exception)
            {
                
                throw;
            }
            return sum;
        }

        /*The logic within the method should:
        Ask the user the select a random number between 1 and the length of the integer array.
        Declare a new variable named product
        Multiply sum by the random number index that the user selected from the array (example: array[randomNumber]). Set this value to the product variable.
        Return the product variable.
        Expected Exceptions:
        IndexOutOfRange
        Output the message to the console.
        throw it back down the callstack so that it displays within Main
        */
        static int GetProduct(int [] arr)
        {
            try
            {
                
            }
            catch (Exception)
            {
                
                throw;
            }
            return 0;
        }

        /*The logic within the method should:
        Prompt the user to enter a number to divide the product by. Display the current product to the user during this prompt.
        Retrieve the input and divide the inputted number by the product.
        Utilize the decimal.Divide() method to divide the product by the dividend to receive the quotient.
        Return the quotient
        Expected Exceptions:
        Divide by Zero Exception
        Output the message to the console
        Do not throw it back to Main
        Return 0 if the catch gets called
        */
        static int GetQuotient(int[] arr)
        {
            try
            {
                
            }
            catch (Exception)
            {
                
            throw;
            }
            return 0;
        }
        static void Main(string[] args)
        {
            StartSequence();
        }
    }
}
