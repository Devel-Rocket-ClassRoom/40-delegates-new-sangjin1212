using Microsoft.VisualBasic;
using System;

Action<string> PrintOriginal = (msg)=> Console.WriteLine(msg);
PrintOriginal("Hello World"); 
Action<string> PrintUpper = (msg)=> Console.WriteLine(msg);
