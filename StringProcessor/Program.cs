using System;
string msg = "Hello World";

Console.WriteLine("=== 문자열 가공기 ===");
Console.WriteLine();
Console.WriteLine($"원본: {msg}");
Console.WriteLine();

Console.WriteLine("[대문자 변환]");
ProcessAndPrint(msg, ToUpperCase);

Console.WriteLine("[소문자 변환]");
ProcessAndPrint(msg, ToLowerCase);

Console.WriteLine("[괄호 추가]");
ProcessAndPrint(msg, AddBrackets);

Console.WriteLine("[문자열 뒤집기]");
ProcessAndPrint(msg, Reverse);
static string ToUpperCase (string s) =>  s.ToUpper ();
static string ToLowerCase(string s) => s.ToLower();
static string AddBrackets(string s) => "[" + s + "]";
static string Reverse(string s)
{
    char[] arr = s.ToCharArray ();
    Array.Reverse(arr);
    return new string(arr);
}
static void ProcessAndPrint(string input, StringProcessor processor)
{
    string result = processor(input);
    Console.WriteLine($"결과: {result}");
    Console.WriteLine();
}
delegate string StringProcessor(string s);