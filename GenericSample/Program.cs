using System;

namespace GenericSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter String1:");
            var str1 = Console.ReadLine();
            Console.Write("Enter String2:");
            var str2 = Console.ReadLine();
            JoinWithGenerics<string> strGeneric = new JoinWithGenerics<string>();
            strGeneric.JoinMethod(str1, str2);
            Console.WriteLine("--------------------------------------------");
            JoinWithGenerics<int> intGeneric = new JoinWithGenerics<int>();
            intGeneric.JoinMethod(20, 30);
            Console.ReadLine();
        }
    }
}
