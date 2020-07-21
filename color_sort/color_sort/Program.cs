using System;
using System.Collections.Generic;
using System.Linq;


namespace ConsoleApp4
{
    class Program
    {
        private static string SortRGB(string source)
        {
            var dict = new Dictionary<char, int>()
 {
 {
 'g', 0
 },
 {
 'b', 1
 },
 {
 'r', 2
 }
 };
            var list = source.ToList().FindAll(a => a == 'r' || a == 'b' || a == 'g');
            list.Sort((a, b) => dict[a].CompareTo(dict[b]));
            // G < B < R 
            return new string(list.ToArray());
        }

        static void Main(string[] args)
        {
            Test();

            var str = Console.ReadLine();
            Console.WriteLine(SortRGB(str));
            Console.ReadKey();
        }


        static void Test()
        {
            var str = "grbbbg";
            var result = SortRGB(str);
            var actual = "ggbbbr";
            var strscf = actual == result ? "Successful " : "not successful";
            Console.WriteLine($"Source {str}. Dest {result}. Actual {actual}. Test {strscf}");

        }
    }
}


