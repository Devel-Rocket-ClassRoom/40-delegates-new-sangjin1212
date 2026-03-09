using Microsoft.VisualBasic;
using System;
using static System.Net.Mime.MediaTypeNames;

string msg = "Hello World";
Action<string> PrintOriginal = (msg) => Console.WriteLine(msg);
Action<string> PrintUpper = (msg) => Console.WriteLine(msg.ToUpper());
Action<string> PrintLower = (msg) => Console.WriteLine(msg.ToLower());
Action<string> PrintLength = (msg) => Console.WriteLine(msg.Length);

Action<string> text = PrintOriginal;

Console.WriteLine("=== 문자열 처리 파이프 라인 ===");
Console.WriteLine();
Console.WriteLine("--- 1: 원본 출력만 ---");
Console.Write($"원본: ");
text(msg);
Console.WriteLine();
Console.WriteLine("--- 2: 대문자 추가 ---");
text += PrintUpper;
text(msg);
Console.WriteLine();
Console.WriteLine("--- 3: 소문자,길이 추가 ---");
text += PrintLower;
text += PrintLength;

text(msg);
Console.WriteLine();
Console.WriteLine("--- 4:대문자 제거 ---");
text -= PrintUpper;
text(msg);
