using System;

namespace CollectionDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictonary<int, string> keyValue = new MyDictonary<int, string>();
            bool isContinue = true;


            while (isContinue)
            {
                int process = Menu();
                switch (process)
                {
                    case 1:
                        Console.WriteLine("Please enter key");
                        int key = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Please enter value");
                        string value = Console.ReadLine();

                        keyValue.AddKeyValuePair(key, value);
                        break;

                    case 2:
                        Console.WriteLine("Please enter the key whose value you want to see");
                        key = Convert.ToInt32(Console.ReadLine());

                        keyValue.GetValue(key);
                        Console.WriteLine(key + " " + keyValue.GetValue(key));
                        Console.WriteLine("");
                        break;

                    case 3:
                        Console.WriteLine("Please enter the key whose value you want to delete");
                        key = Convert.ToInt32(Console.ReadLine());

                        keyValue.RemoveKeyValuePair(key);
                        break;

                    case 4:
                        isContinue = false;
                        break;
                }

            }
        }
        static int Menu()
        {
            Console.WriteLine("Which of them do you want process");
            Console.WriteLine("1: Add to dictonary");
            Console.WriteLine("2: List dictonary");
            Console.WriteLine("3: Delete from dictonary");
            Console.WriteLine("4: Exit");
            Console.WriteLine("");
            int process = Convert.ToInt32(Console.ReadLine());

            return process;
        }
    }
}
