using System;
Action driver = GoForward;
driver += GoLeft;
//driver += GoRight;
static void GoForward() => Console.WriteLine("직진");
static void GoLeft() => Console.WriteLine("좌회전");
//static void GoRight() => Console.WriteLine("우회전");
driver += delegate ()
{
    Console.WriteLine("우회전");
};
driver();
