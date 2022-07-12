using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _5kyu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var text = "e e e e DDD ddd DdD: ddd ddd aa aA Aa, bb cc cC e e e";
            var regex = new Regex(@"[\/\\!@#$%^&*()., ;]");

            var splitArr = regex.Split(text).Where(d => d != string.Empty);

            var CollectTimes = splitArr.GroupBy(d => d).OrderByDescending(c => c.Count())
            .ThenBy(e => e.Key);

            Console.WriteLine("Hello World!");
        }
    }
}
