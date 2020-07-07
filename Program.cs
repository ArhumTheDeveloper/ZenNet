using System;

namespace Zennet
{
    class Program
    {
        private const string V = "Ok finaly who's your best friend";
        private const string Value = V;

        static void Main(string[] args)
        {
            Console.Title = "ZenNet";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WindowHeight = 40;

            Console.WriteLine("Yo Whats your name");

            string userName = Console.ReadLine();

            Console.WriteLine("Hello " +userName + ", its nice to meet you");

            Console.WriteLine("My name is ZenNet V1.04 i was made to do what my creator arhum tells to do");

            Console.WriteLine("Ok then whats your Fav color");

            Console.ReadLine();

            Console.WriteLine("Oh you like that color your a cool fellow");

            Console.WriteLine("Ok guess my fav color");

            Console.ReadLine();

            Console.WriteLine("If you guessed any color but yellow, your wrong ");

            Console.WriteLine("I like Yellow because its the color of happiness");

            Console.WriteLine("Whats your fav food i like toast with cheese");

            Console.ReadLine();

            Console.WriteLine(Value);

            Console.ReadLine();

            Console.WriteLine("Ok bye for now");

            Console.ReadKey();
        }
    }
}
