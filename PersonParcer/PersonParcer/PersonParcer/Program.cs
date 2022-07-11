// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic.FileIO;
using PersonParcer;

Console.WriteLine("Hello, World!");

TextFieldParser textFileReader = new TextFieldParser(@"..\..\..\Data\person0.csv");
Parser parserEnumerator = new Parser(textFileReader);
foreach (var i in parserEnumerator)
{
    Console.WriteLine(i);
}