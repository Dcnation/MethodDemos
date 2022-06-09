using System;

namespace MethodDemos
{
    class Program

    {
        //Exercise 2
        public static int Sum(int num1, int num2)
        {

            var answer = num1 + num2;
            return answer;

        }

        static void Main(string[] args)
        {

            int v = Sum(2, 6);
            var amountOfGames = v;



            //Exercise 1
            //Name: Devin
            //Favorite Color: Green
            //Favorite Animal: Tiger
            //Favorite Band:  NWA

            Console.WriteLine("Hello - whats your first name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hi, {userName}. What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"{color} is an awesome color! What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine("Great! Now, what is your favorite band?");
            var band = Console.ReadLine();
        }
    }
}

























