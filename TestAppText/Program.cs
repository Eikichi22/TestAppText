using System;
using System.Security.Cryptography;

namespace TestAppText
{
    class Program
    {
        static void Main(string[] args)
        {
            bool finish = false;

            while (!finish)
            {

                Console.WriteLine("Input your text");

                string s = Console.ReadLine();
                Console.WriteLine("The text has been written.");

                char[] a = s.ToCharArray();

                int j = 0; int jMax = 0;
                for (int i = 0; i < a.LongLength - 1; i++)
                {


                    if (a[i] != a[i + 1])
                    {
                        j++;
                    }
                    else
                    {
                        j = 0;
                    }
                    if (j > jMax)
                    {
                        jMax = j;
                    }
                }

                jMax++;

                Console.WriteLine("Max lengt of different letters: " + jMax);

                Console.WriteLine("If you want finish press 'y', if you want continue press any other letter");
                string k = Console.ReadLine();

                if (k == "y")
                {
                    finish = true;
                }

                

            }

            


        }
    }
}