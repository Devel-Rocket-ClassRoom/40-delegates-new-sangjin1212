using System;
Action greet = () => Console.WriteLine("안녕하세요!");
greet();
Action<string> print = (msg) => Console.WriteLine(msg);
print("Hello, Action!");

Action<string, int> printRepeat = (msg, count) =>
{
    for (int i = 0; i < 3; i++)
    {
        Console.WriteLine(msg);
    }
};
printRepeat("반복", 3);
Func<int> getNumber = () => 42;
Console.WriteLine(getNumber());

Func<int, int> square = (x) => x * x;
Console.WriteLine(square(5));

Func<int, int, int> add = (x, y) => x + y;
Console.WriteLine(add(3, 7));

Func<int, int, string> addToString = (x, y) => (x + y).ToString();
Console.WriteLine(addToString(3, 5));

Predicate<int> isEven = (x)  => x % 2 == 0;
Predicate<int> isPositive = (x) => x > 0;

Console.WriteLine(isEven(4));
Console.WriteLine(isEven(7));

Console.WriteLine(isPositive(5));
Console.WriteLine(isPositive(-5));

SayDelegate say = delegate ()
{
    Console.WriteLine("반갑습니다.");
};

say();

delegate void SayDelegate();