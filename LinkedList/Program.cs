using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Link LinkedList = new Link();
            string input;
            int options;
            int exitVar = 0;

            while (exitVar == 0)
            {
                try
                {
                    Console.WriteLine(" \nChoose your options:");
                    Console.WriteLine("1. Insert element\n2. Delete oldest element\n3. Print out all elements\n4. Exit");
                    options = Convert.ToInt32(Console.ReadLine());


                    switch (options)
                    {
                        case 1:
                            Console.Write("Element: ");
                            input = Convert.ToString(Console.ReadLine());
                            LinkedList.AddAtLast(input);
                            break;
                        case 2:
                            LinkedList.RemoveFromStart();
                            break;
                        case 3:
                            LinkedList.PrintAll();
                            break;
                        case 4:
                            Console.WriteLine("Goodbye");
                            exitVar++;
                            break;
                        default:
                            Console.WriteLine("Error 101, please try again");
                            Console.WriteLine();
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Error 101, please try again");
                    Console.WriteLine();
                }
            }
        }

    }
}
