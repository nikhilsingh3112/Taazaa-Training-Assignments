
using System;
namespace StringApplication
{
class StringProg
{
static void Main(string[] args)
{
string[] starray = new string[]{"Hello i am Ganesh",
"And i am from gorakhpur",
"I completed my graduation from bbdec",
"in year 2021",
"in Cse"};
string str = String.Join("\n", starray);
Console.WriteLine(str);
}
}
}