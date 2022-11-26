// See https://aka.ms/new-console-template for more information
using DailyCodingProblem;

int[] arr = { 2, 4, 6, 2, 5 };
var el = new NonAdjacentNumbers();

var sched = new JobScheduler<int>();
sched.Schedule(4000, () => el.Get(arr));

Console.WriteLine(el);
