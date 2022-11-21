using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCodingProblem
{//TODO: Optimize and think how implement
    public class Pair
    {
        public Func<int,int,int> cons(int a, int b)
        {
            int pair(int a, int b) => a + b;

            return (a, b) => pair(a, b);
        }

        public int car(Func<int, int, int> func) 
        {
            var val = func.Method.GetParameters()[0];
            return (int)val.DefaultValue;
        }

        public int cdr(Func<int, int, int> func) 
        {
            var val = func.Method.GetParameters()[1];
            return (int)val.DefaultValue;
        }
    }

    public class Test
    {
        public Pair pair;
        public Test()
        {
            pair = new Pair();
            pair.car(pair.cons(1, 4));
        }
    }
}

//cons(a, b) constructs a pair, and car(pair) and cdr(pair)
//    returns the first and last element of that pair. For example, car(cons(3, 4)) returns 3, and cdr(cons(3, 4)) returns 4.

//Given this implementation of cons:

//def cons(a, b):
//    def pair(f):
//        return f(a, b)
//    return pair