// See https://aka.ms/new-console-template for more information
using BracketAlgoritm;

string line;
Console.WriteLine("Hello, World!");
line = Console.ReadLine();
ValidBracket validBracket = new ValidBracket();
Console.WriteLine(validBracket.IsValid(line));