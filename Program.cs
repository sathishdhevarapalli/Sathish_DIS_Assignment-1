using System;
using System.Collections.Generic;
using System.Linq;


namespace Sathish_DIS_Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 1:
            
            Console.WriteLine(" Q1 : Enter the number of rows for the triangle: ");
            int n = Convert.ToInt32(Console.ReadLine());
            printTriangle(n);
            Console.WriteLine();
            

            //Question 2:
            
            Console.WriteLine("Q2 : Enter the number of terms in the Pell Series:");
            int n2 = Convert.ToInt32(Console.ReadLine());
            printPellSeries(n2);
            Console.WriteLine();
            

            //Question 3:
            
            Console.WriteLine("Q3 : Enter the number to check if squareSums exist:");
            int n3 = Convert.ToInt32(Console.ReadLine());
            bool flag = squareSums(n3);
            if (flag)
            {
                Console.WriteLine("Yes, the number can be expressed as a sum of  squares of 2 integers");
            }
            else
            {
                Console.WriteLine("No, the number cannot be expressed as a sum of squares of 2 integers");
            }

            Console.WriteLine();

            //Question 4:
            
            int[] arr = { 3, 1, 4, 1, 5 };
            Console.WriteLine("Q4: Enter the absolute difference to check");
            int k = Convert.ToInt32(Console.ReadLine());
            int n4 = diffPairs(arr, k);
            Console.WriteLine("There exists {0} pairs with the given difference", n4);

            Console.WriteLine();

            //Question 5:

            List<string> emails = new List<string>();
            emails.Add("dis.email+bull@usf.com");
            emails.Add("dis.e.mail+bob.cathy@usf.com");
            emails.Add("disemail+david@us.f.com");
            int ans5 = UniqueEmails(emails);
            Console.WriteLine("Q5");
            Console.WriteLine("The number of unique emails is " + ans5);

            Console.WriteLine();

            //Quesiton 6:

            string[,] paths = new string[,] { { "London", "New York" }, { "New York", "Tampa" },
                                        { "Delhi", "London" } };
            string destination = DestCity(paths);
            Console.WriteLine("Q6");
            Console.WriteLine("Destination city is " + destination);
            


        }
        private static void printTriangle(int n)
        {
            try
            {
                int i, x, y, z;

                for (i = 1; i <= n; i++)
                {
                    for (x = 1; x <= n - i; x++)
                    {
                        Console.Write(" ");
                    }
                    for (y = 1; y <= i; y++)
                    {
                        Console.Write("*");
                    }
                    for (z = i - 1; z >= 1; z--)
                    {
                        Console.Write("*");
                    }

                    Console.Write("\n");
                }
            }
            catch (Exception)
            {
                throw;
            }

        }
        private static void printPellSeries(int n2)
        {
            try
            {
                int x = 0;
                int y = 1;
                int z;

                for (int i = 0; i < n2; i++)
                {
                    z = 2 * y + x;
                    Console.WriteLine(z);
                    x = y;
                    y = z;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        private static bool squareSums(int n3)
        {
            try
            {
                for (int i = 0; i * i <= n3; i++)
                {
                    for (int j = 0; j * j <= n3; j++)
                    {
                        if (i * i + j * j == n3)
                        {
                            return true;
                        }
                    }
                }
                return false;

            }
            catch (Exception)
            {

                throw;
            }
        }
        private static int diffPairs(int[] nums, int k)
        {
            try
            {
                Dictionary<int, int> pairs = new Dictionary<int, int>();
                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = 0; j < nums.Length; j++)
                    {
                        if ((nums[i] - nums[j] == k) && (j != i))
                        {
                            try
                            {
                                pairs.Add(nums[i], nums[j]);

                            }
                            catch (Exception)
                            {
                                continue;
                            }
                        }
                    }
                }
                return pairs.Count();
            }
            catch (Exception e)
            {

                Console.WriteLine("An error occured: " + e.Message);
                throw;
            }

        }

        private static int UniqueEmails(List<string> emails)
        {
            int count = 0;
            try
            {

                for (int y = 0; y < emails.Count; y++)
                {
                    int i = emails[y].IndexOf("@");
                    String local = emails[y].Substring(0, i);
                    String domain = emails[y].Substring(i);
                    if (local.Contains("+"))
                    {
                        local = local.Substring(0, local.IndexOf('+'));
                    }

                    local = local.Replace(".", "");
                    emails[y] = local + domain;
                    count = emails.Distinct().Count();

                }

                return count;
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }
        private static string DestCity(string[,] paths)
        {
            string d = "";
            try
            {

                string[] src = new string[paths.Length];
                string[] dest = new string[paths.Length];
                for (int i = 0; i < 3; i++)
                {
                    src[i] = paths[i, 0];
                    dest[i] = paths[i, 1];
                }
                for (int i = 0; i < 3; i++)
                {
                    int j;
                    for (j = 0; j < 3; j++)
                    {
                        if (dest[i] == src[j])
                            break;
                    }

                    if (j == 3)
                    {
                        d = dest[i];
                    }


                }
                return d;



            }
            catch (Exception)
            {

                throw;
            }


        }
    }
}
