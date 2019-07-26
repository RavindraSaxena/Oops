using System;

namespace HashDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Hello";
            string str2 = "Hello";

            Console.WriteLine($"String: {str1} -> Hashcode ({str1.GetHashCode()})");
            Console.WriteLine($"String: {str2} -> Hashcode ({str2.GetHashCode()})");

            Console.ReadLine();
        }
    }
}
