using System;
using System.Collections.Generic;
using System.Linq;


namespace Sathish_DIS_Assignment_1
{
    class Program
    {
        /* The Main method is where program starts execution. 
         * It is the main entry point of program that executes all the objects and invokes method to execute. 
         * There can be only one Main method in C#
         */
        static void Main(string[] args)
        {
            // Question 1:
            
            Console.WriteLine(" Q1 : Enter the number of rows for the triangle: ");  
            int n = Convert.ToInt32(Console.ReadLine()); // we use toint32 to convert the input data type which is in string format to int format
            printTriangle(n); // we are calling printtriangle method to display triangles for input n
            Console.WriteLine();
            

            //Question 2:
            
            Console.WriteLine("Q2 : Enter the number of terms in the Pell Series:");
            int n2 = Convert.ToInt32(Console.ReadLine());
            printPellSeries(n2); // we are calling printPellSeries method to display pellseries numbers upto n2
            Console.WriteLine();
            

            //Question 3:
            
            Console.WriteLine("Q3 : Enter the number to check if squareSums exist:");
            int n3 = Convert.ToInt32(Console.ReadLine()); 
            bool flag = squareSums(n3); // we are calling squareSums function to check wheather input n3 can be written as sum of squares of two non-negative integers
            if (flag) // we are using if condition to print as per if n3 can be written as sum of two integers or not
            {
                Console.WriteLine("Yes, the number can be expressed as a sum of  squares of 2 integers");
            }
            else
            {
                Console.WriteLine("No, the number cannot be expressed as a sum of squares of 2 integers");
            }

            Console.WriteLine();

            //Question 4:
            
            int[] arr = { 3, 1, 4, 1, 5 }; // we are delcaring an array and assigning values to it
            Console.WriteLine("Q4: Enter the absolute difference to check");
            int k = Convert.ToInt32(Console.ReadLine()); // converting input string to int format
            int n4 = diffPairs(arr, k); //  calling arr function and providing the absolute difference value
            Console.WriteLine("There exists {0} pairs with the given difference", n4);

            Console.WriteLine();

            //Question 5:

            List<string> emails = new List<string>(); // initiating new list data structure to store emails.
            emails.Add("dis.email+bull@usf.com"); // adding individual email to the emails list
            emails.Add("dis.e.mail+bob.cathy@usf.com");
            emails.Add("disemail+david@us.f.com");
            int ans5 = UniqueEmails(emails); // calling emails method
            Console.WriteLine("Q5");
            Console.WriteLine("The number of unique emails is " + ans5);

            Console.WriteLine();

            //Quesiton 6:

            string[,] paths = new string[,] { { "London", "New York" }, { "New York", "Tampa" },
                                        { "Delhi", "London" } }; // creating a string and giving the values
            string destination = DestCity(paths); // calling destcity function
            Console.WriteLine("Q6");
            Console.WriteLine("Destination city is " + destination);
            


        }
        private static void printTriangle(int n) // creating a method with no return type 
        {
            //The try statement allows you to define a block of code to be tested for errors while it is being executed. 
            try
            {
                int i, x, y, z; // initiating three integer variables 

                for (i = 1; i <= n; i++) // creating a for loop to create a triangle of size n
                {
                    for (x = 1; x <= n - i; x++) // inorder to make the triangle center we are creating the empty spaces 
                    {
                        Console.Write(" ");
                    }
                    for (y = 1; y <= i; y++) // this is the actual place the triangle starts printing and its symmetrical at this point
                    {
                        Console.Write("*"); // triangle visual design type as in this case it is *
                    }
                    for (z = i - 1; z >= 1; z--) // here we are creating * to be symmetrical
                    {
                        Console.Write("*"); 
                    }

                    Console.Write("\n");
                }
            }
            // The catch statement allows you to define a block of code to be executed, if an error occurs in the try block.

            catch (Exception)
            {
                throw;
            }

        }
        private static void printPellSeries(int n2)
        {
            try
            {
                int x = 0; // as the first two numbers of pellseries are 0,1 we are assinging these values to x and y
                int y = 1;
                int z; // we are initiating int z to create logic for pellseries number

                for (int i = 0; i < n2; i++) // in this loop we are iterating through all the numbers starting 0 to the number provided by user.
                {
                    z = 2 * y + x; // logical statement of pellseries
                    Console.WriteLine(z);
                    x = y; // here to move to next number we always store first number in x and second number in y
                    y = z;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        private static bool squareSums(int n3) // here we are creating a true or false return type because we are just checking wheather a number can be expressed as sum of two numbers or not
        {
            try
            {
                for (int i = 0; i * i <= n3; i++) // this loop is for the first number of two numbers
                {
                    for (int j = 0; j * j <= n3; j++) // this loop is for the second number of the two numbers
                    {
                        if (i * i + j * j == n3) // through this if statement we are saying if sum of squares of two can be equal to input num then return true
                        {
                            return true;
                        }
                    }
                }
                return false; // through this we are saying if sum of squares of two not equal to input num then return false

            }
            catch (Exception)
            {

                throw;
            }
        }
        private static int diffPairs(int[] nums, int k) // now we are creating a integer return type method
        {
            try
            {
                Dictionary<int, int> pairs = new Dictionary<int, int>(); // we initiated a dictionary data structure to store key value pair
                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = 0; j < nums.Length; j++)
                    {
                        if ((nums[i] - nums[j] == k) && (j != i)) // here we are looking if the absolute difference is equal to input difference or not.
                        {
                            try
                            {
                                pairs.Add(nums[i], nums[j]); // if there is such a pair whos difference is equal to input num value then we will add this pair to the dictionary

                            }
                            catch (Exception)
                            {
                                continue;
                            }
                        }
                    }
                }
                return pairs.Count(); // finally we are counting and returning all the pairs in the dictionary
            }
            catch (Exception e)
            {

                Console.WriteLine("An error occured: " + e.Message); // we use .message to display what the error message is
                throw;
            }

        }

        private static int UniqueEmails(List<string> emails) // we are creating a int return type method
        {
            int count = 0;
            try
            {

                for (int y = 0; y < emails.Count; y++) //this loop will iterate through o to total number of emails in the list
                {
                    int i = emails[y].IndexOf("@"); // here we are creating a index number at which @ is present so that we can split our email into two parts for local name and domain name
                    String local = emails[y].Substring(0, i); // this is the local name from index position 0 to i which is till @
                    String domain = emails[y].Substring(i); // this  is domain name which is form @ to last index value
                    if (local.Contains("+")) // we are creating this condition to remove which ever is present after + sign will not be taken into account of local name
                    {
                        local = local.Substring(0, local.IndexOf('+')); // we are tell local name is substring till +
                    }

                    local = local.Replace(".", ""); // as we want to neglet . sign we are replacing it with nothing
                    emails[y] = local + domain; // here we are adding our cleaned local name with domain name
                    count = emails.Distinct().Count(); // counting the total number of unique emails
                }

                return count;
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }
        private static string DestCity(string[,] paths) // we are creating a string return type method
        {
            string d = ""; // initiating a string data type
            try
            {

                string[] source = new string[paths.Length]; // as our input contains a soure and a destination we are creating two stings to store those values.
                string[] destination = new string[paths.Length];
                for (int i = 0; i < 3; i++) // initially we are splitting the given input data into soure and destination string arrays
                {
                    source[i] = paths[i, 0];
                    destination[i] = paths[i, 1];
                }
                for (int i = 0; i < 3; i++)
                {
                    int j; // we are declaring this loop initiater variable outside of loop because we want use this variable to see destination city in the destination array
                    for (j = 0; j < 3; j++)
                    {
                        if (destination[i] == source[j]) // if there a city is in both destination and source then it will not be a final destination city so the inner loop will break 
                            break;
                    }
                    if (j == 3) // finally only one city will be left in destination which is destination city.
                    {
                        d = destination[i];
                    }
                }
                return d; // returning destination city name.
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
