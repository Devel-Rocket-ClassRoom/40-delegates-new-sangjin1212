using System;
//Calculator calu = new Calculator();
//Transfomer t = calu.Multiply;
//Console.WriteLine(t(5));
//class Calculator
//{
//    public int multiplier = 3;
//    public int Multiply(int x) => x * multiplier;
//}
//delegate int Transfomer(int x);

//CarDriver car = GoForward;
//car += GOLeft;
//car += GoRight;
//car();
//Console.WriteLine();

//car -= GOLeft;
//car();
//static void GoForward() => Console.WriteLine("직진");
//static void GOLeft() => Console.WriteLine("좌회전");
//static void GoRight() => Console.WriteLine("우회전");

//delegate void CarDriver();
int[] numbers = { 1, 2, 3, 4, 5 };
Transformer(numbers, Square);
PrintArray(numbers);

numbers = new int[] { 1, 2, 3, 4, 5 };
Transformer(numbers, Cube);
PrintArray(numbers);
static int Square(int x) => x * x;
static int Cube(int x) => x * x * x;
static void Transformer(int[] values, Transformer t)
{
    for (int i = 0; i < values.Length; i++)
    {
        values[i] = t(values[i]);
    }
}
static void PrintArray(int[] arr)
{
    Console.WriteLine(string.Join(",", arr));
}
delegate int Transformer(int x);