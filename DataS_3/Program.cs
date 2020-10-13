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

        static void Task2()
        {
            Console.WriteLine("Write a sentence : ");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(" ");

            string longestword = "";

            foreach (string word in words)
            {
                if(longestword.Length < CleanWord(word).Length)
                {
                    longestword = word;
                }
            }


            Console.WriteLine($"The longest word is : {longestword}");

        }

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




        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            do
            {
                Console.Clear();
                Console.WriteLine("\n\n Task 1 : \n\n"
                                     + " 1 : Names and birth dates (arrays)"

                                     + "\n\n Task 2 : Longest word in a sentence"

                                     + "\n\n Please choose : ");
                int exo = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (exo)
                {
                    case 1:
                        Arrays();
                        break;

                    case 2:
                        Task2();
                        break;

                    case 3:
                        Task3();
                        break;
                }
                Console.WriteLine("\nPress any key to exit... ");
                cki = Console.ReadKey();
            } while (cki.Key != ConsoleKey.Escape);
            Console.ReadKey();
        }
    }
}
