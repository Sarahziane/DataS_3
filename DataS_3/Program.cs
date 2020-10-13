using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;


namespace DataS_3
{
    class Program
    {
            // array list : n'importe quel type d'objets, list : un seul type d'objet


        static void Arrays()
        {
            ArrayList list = new ArrayList();
            foreach (var item in list)
                Console.WriteLine(item);


          List<string> names = new List<string>();
            names.Add("Flo");
            names.Add("Paul");
            names.Add("Nico");
            names.Add("Max");
            names.Add("Pierre");
            names.Add("Sarah");
            //foreach(var item in names)
            //    Console.WriteLine(item);

            List<string> dates = new List<string>();
            dates.Add("beginning of September");
            dates.Add("middle of August");
            dates.Add("beginning of July");
            dates.Add("middle of January");
            dates.Add("end of May");
            dates.Add("middle of January");

            Console.WriteLine("Index ? (between 0 - 5)");
            int index = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 6; i++)
            {
                if (index == i)
                    Console.WriteLine(names[i] + "'s birthday is in " + dates[i]);
            }

        }

        //static void Task2()
        //{
        //    Console.WriteLine("Write a sentence : ");
        //    string sentence = Console.ReadLine();
        //    string[] words = sentence.Split(" ");

        //    string longestword = "";

        //    foreach (string word in words)
        //    {
        //        if(longestword.Length < CleanWord(word).Length)
        //        {
        //            longestword = word;
        //        }
        //    }


        //    Console.WriteLine($"The longest word is : {longestword}");

        //}

        static void Task3()
        {
            Console.WriteLine("Write a sentence : ");
            string sentence = Console.ReadLine();
            string[] list = sentence.Split(" ");

            for (int i = 0; i < list.Length; i++)
            {
                for (int j = list.Length; j <= list.Length; j--)
                {


                    list[i] = list[j];
                    Console.WriteLine(list[i]);

                }
            }
         
        }

        static void Array()
        {
          // bool result = false;
            ArrayList array = new ArrayList();
            for (int i = 0; i <= 10; i++) 
            {
                array.Add(i);
            }
            foreach (int item in array)
            {
                Console.WriteLine(item +"\n");
            }
            Console.WriteLine("Write a number to check if it's in the array : ");
            int check = int.Parse(Console.ReadLine());
            if (array.Contains(check) == true)
            {
                Console.WriteLine("\nThe number is in the array");
            }
            else
                Console.WriteLine("\nThe number is not in the array");

            //foreach (int item in array)
            //{
            //    if (check == item)
            //    {
            //        result = true;
            //    }
            //    else
            //    {
            //        result = false;
            //    }
            //}
            //Console.WriteLine($"The number is in the array : {result}"); 
            /////////// fonctionne pas jcp pk /////////////////
        }

        static void Stack()
        {
            Stack<int> mystack = new Stack<int>();
            for (int i = 0; i <=10; i++)
            {
                mystack.Push(i);
            }
            foreach(int item in mystack)
            {
                Console.WriteLine($"\n{item}");
            }
            Console.WriteLine("Write a number to check if it's in the stack : ");
            int check = int.Parse(Console.ReadLine());
            if (mystack.Contains(check) == true)
            {
                Console.WriteLine("\nThe number is in the stack");
            }
            else
                Console.WriteLine("\nThe number is not in the stack");

        }
        static void Queues()
        {
            Queue<int> myqueue = new Queue<int>();
            for (int i = 0; i <= 10; i++)
            {
                myqueue.Enqueue(i);
            }
            foreach (int item in myqueue)
            {
                Console.WriteLine($"\n{item}");
            }
            Console.WriteLine("Write a number to check if it's in the queue : ");
            int check = int.Parse(Console.ReadLine());
            if (myqueue.Contains(check) == true)
            {
                Console.WriteLine("\nThe number is in the queue");
            }
            else
                Console.WriteLine("\nThe number is not in the queue");

        }
        static void List()
        {
            List<int> mylist = new List<int>();
            for (int i = 0; i <= 10; i++)
            {
                mylist.Add(i);
            }
            foreach (int item in mylist)
            {
                Console.WriteLine($"\n{item}");
            }
            Console.WriteLine("Write a number to check if it's in the list : ");
            int check = int.Parse(Console.ReadLine());
            if (mylist.Contains(check) == true)
            {
                Console.WriteLine("\nThe number is in the list");
            }
            else
                Console.WriteLine("\nThe number is not in the list");

        }

        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            do
            {
                Console.Clear();
                Console.WriteLine("\n\n Task 1 : \n\n"
                                     + " 1 : Names and birth dates (arrays)"

                                     + "\nTask 2 : Longest word in a sentence"
                                     + "\n Task 3 : Reverse the words of a sentence"

                        + "\n\nHomework : "
                  + "\n\n 4 : Array"
                   + "\n\n 5 : Stack"
                    + "\n\n 6 : Queues"
                     + "\n\n 7 : List<T>"

                                     + "\n\n Please choose : ");
                int exo = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (exo)
                {
                    case 1:
                        Arrays();
                        break;

                    case 2:
                    //    Task2();
                        break;

                    case 3:
                        Task3();
                        break;
                    case 4:
                        Array();
                        break;
                    case 5:
                        Stack();
                        break;
                    case 6:
                        Queues();
                        break;
                    case 7:
                        List();
                        break;
                }
                Console.WriteLine("\nPress any key to exit... ");
                cki = Console.ReadKey();
            } while (cki.Key != ConsoleKey.Escape);
            Console.ReadKey();
        }
    }
}
