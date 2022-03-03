using System;

namespace singleton
{
    public class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Singleton - Start\n");

            Console.WriteLine(Singleton.instance.Value);
            Singleton.instance.Value++;
            Console.WriteLine(Singleton.instance.Value);

            Console.WriteLine("\nSingleton - End");

        }
    }
}
