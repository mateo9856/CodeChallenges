using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4kyu
{
    public class JohnAndAnnSignUpForCodewars
    {
        public static List<long> John(long n)
        {
            return GenerateList("john", n);
        }

        public static List<long> GenerateList(string person, long n)
        {
            var john = new List<long>() { 0, 0 };
            var ann = new List<long>() { 1, 1 };

            for (int dayAnn = 1, dayJohn = 1; dayAnn < n || dayJohn < n;)
            {
                if (john.Count() > ann[dayAnn - 1])
                {
                    ann.Add(dayAnn - john[(int)ann[dayAnn - 1]]);
                    dayAnn++;
                }

                if ((long)ann.Count() > john[dayJohn - 1])
                {
                    john.Add(dayJohn - ann[(int)john[dayJohn - 1]]);
                    dayJohn++;
                }
            }

            return person == "john" ? john : ann;
        }

        public static List<long> Ann(long n)
        {
            return GenerateList("add", n);
        }
        public static long SumJohn(long n)
        {
            return John(n).Sum();
        }
        public static long SumAnn(long n)
        {
            return Ann(n).Sum();
        }
    }
}
