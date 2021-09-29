using ExtensionMethodsForSummerSchool.Extensions;
using System;

// .NET 3.5 introduced the concept of extension methods, which allow you to add new methods or properties
// to a class or structure, without modifying the original type in any direct manner.
namespace ExtensionMethodsForSummerSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt = 12345678;
            myInt.DisplayDefiningAssembly();
            
            System.Data.DataSet d = new System.Data.DataSet();
            d.DisplayDefiningAssembly();

            Console.WriteLine($"Value of myInt: {myInt}");
            Console.WriteLine($"Reversed digits of myInt: {myInt.ReverseDigits()}");

            Console.ReadLine();
        }
    }
}
