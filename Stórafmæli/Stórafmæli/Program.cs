using System;

namespace Stórafmæli
{
    internal class Birthday
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are Jónas turning tomorrow? Specify the number: ");

            int age = int.Parse(Console.ReadLine());

            // Then checking if the input is divisible evenly by 10.

            if (age % 10 == 0)  
            {
                Console.WriteLine("Jebb");
            }
            else
            {
                Console.WriteLine("Neibb");
            }


            }
        }
    }
