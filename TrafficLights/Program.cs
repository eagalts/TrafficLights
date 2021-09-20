using System;
using System.Threading;

namespace TrafficLights
{ 
    class Program
    {
        public interface Itrafficl
        {
            const sbyte green = 30;
            const sbyte yellow = 4;
            const sbyte red = 30;

            const bool working = true;
        }

        public class trafficl : Itrafficl
        {
            const sbyte green = 30, red = 30, yellow = 4;
            const bool working = true;

            public void _yellow(int i)
            {
                Console.Clear();
                Console.WriteLine("Жёлтый: ");
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }

            public void toyellow()
            { 
                Console.ForegroundColor = ConsoleColor.Yellow;
                for (int i = yellow; i > 0; i--)
                    _yellow(i);
                Console.ResetColor();
            }

            public void _green(int i)
            {
                Console.Clear();
                Console.WriteLine("Зелёный: ");
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }

            public void togreen()
            {
                Console.ForegroundColor = ConsoleColor.Green;
                for (int i = green; i > 0; i--)
                    _green(i);
                Console.ResetColor();
            }

            public void _red(int i)
            {
                Console.Clear();
                Console.WriteLine("Красный: ");
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }

            public void tored()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                for (int i = red; i > 0; i--)
                    _red(i);
                Console.ResetColor();
            }

            public void notworking()
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Clear();
                for (; ; )
                {
                    Console.WriteLine("Жёлтый");
                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.WriteLine();
                    Thread.Sleep(1000);
                    Console.Clear();
                }
                Console.ResetColor();
            }


            public void start()
            {
                if (working)
                {
                    for (; ; )
                    {
                        togreen();
                        toyellow();
                        tored();
                        toyellow();
                    }
                }

                else
                    notworking();
            }
        }

        static void Main(string[] args)
        {
            trafficl l = new trafficl();
            l.start();
        }
    }
}
