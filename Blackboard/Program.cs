using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackboard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bb = new Blackboard<object>();

            bb.Add("Int", 1);
            bb.Add("Float", 2.1f);
            bb.Add("String", "Hello");
            bb.Add("Class", new Numbers() { First = 100, Second = 10.2f });

            Console.WriteLine(bb.ToString());

            Console.WriteLine($"Int: {bb["Int"]} ({bb["Int"].GetType()})");
            Console.WriteLine($"Float: {bb["Float"]} ({bb["Float"].GetType()})");
            Console.WriteLine($"String: {bb["String"]} ({bb["String"].GetType()})");
            Console.WriteLine($"Class: {bb["Class"]} ({bb["Class"].GetType()})");

            Console.ReadLine();

        }

    }

    public class Numbers
    {
        public int First { get; set; }
        public float Second { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.Append($"First: {First}, Second: {Second}");

            return sb.ToString();
        }
    }
}
