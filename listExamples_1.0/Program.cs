using System;
using System.Collections.Generic;
using System.Linq;

namespace listExamples_1._0
{
    class Program
    {
        static int getInt(string message)
        {
            //get an integer with checks
            int n;
            Console.WriteLine(message);
            while (true)
            {
                try
                {
                    n = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("You need to provide an Integer");
                }
            }
            return (n);
        }

       
        static int menu(string message, int numOptions)
        {
            int n;
            while (true)
            {
                n = getInt(message);
                if (n < 0 || n > numOptions)
                {
                    Console.WriteLine("not a valid menu option.");
                    continue;
                }
                else
                {
                    break;
                }
            }
            return n;
        }
        static void endCode()
        {
            Console.WriteLine("Have a day");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            //int pass = 0, fail = 0;
            //int[] input = { 34, 35, 56, 89, 54, 67, 78, 9 };
            //List<int> marks = new List<int>(input);
            //Console.WriteLine("Please enter another mark: ");
            //marks.Add(Convert.ToInt32(Console.ReadLine()));


            //foreach (int mark in marks)
            //{
            //    Console.Write(mark + ", ");
            //    if (mark > 50)
            //    {
            //        pass++;
            //    }
            //    else
            //    {
            //        fail++;
            //    }

            //}
            //Console.WriteLine();
            //Console.WriteLine($"There are {pass} passes, and {fail} fails");
            //endCode();



            //string menuMessage = "0. quit\n1. to print colors\n2. add a color \n3. find a color\n4. remove a color";
            //int menuOption;
            //string[] input = { "red", "green", "blue", "pink" };
            //List<string> colors = new List<string>(input); // use the array input to initialize the values in the list
            //while (true)
            //{
            //    menuOption = menu(menuMessage, 4);
            //    if (menuOption == 0)
            //    {
            //        break;

            //    }
            //    else if (menuOption == 1)//print
            //    {
            //        for (int i = 0; i < colors.Count; i++)
            //        {
            //            //set them all to be capitalized and print
            //            colors[i] = char.ToUpper(colors[i].First()) + colors[i].Substring(1).ToLower();
            //            Console.Write(colors[i] + ", ");

            //        }
            //        Console.WriteLine();
            //    }
            //    else if (menuOption == 2)//add a name
            //    {
            //        Console.WriteLine("enter the color");
            //        string n = Console.ReadLine();
            //        n = char.ToUpper(n.First()) + n.Substring(1).ToLower();
            //        //names.Add(n);
            //        colors.Insert(0, n);
            //

            //    }
            //    else if (menuOption == 3)//find names
            //    {
            //        Console.WriteLine("enter the color you are looking for");
            //        string n = Console.ReadLine();
            //        n = char.ToUpper(n.First()) + n.Substring(1).ToLower();
            //        //find first occurance
            //        int loc = colors.IndexOf(n);
            //        if (loc > -1)
            //        {
            //            Console.WriteLine($"{n} can be found in position {loc}");

            //        }
            //        //second occurance if it exists

            //        if (colors.IndexOf(n, loc + 1) > -1)
            //        {
            //            Console.WriteLine($"{n} can be found in position {colors.IndexOf(n, loc + 1)}");
            //        }
            //    }

            //    else
            //    {
            //        Console.WriteLine("enter the color you want to delete");
            //        string n = Console.ReadLine();
            //        n = char.ToUpper(n.First()) + n.Substring(1).ToLower();
            //        if (colors.IndexOf(n) > -1)
            //        {
            //            colors.RemoveAt(colors.IndexOf(n));
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{n} is not found in the list");
            //        }

            //    }

            //}

            //endCode
        }
    }
}

