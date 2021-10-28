using System;
namespace privateConstructorProgram
{
 class Program
 {
 public static string name;
 public static int num;
 // Creating private Constructor
 // using private keyword
 private Program()
 {
 Console.WriteLine("Welcome to Private Constructor");
 }
 // Default Constructor
 // with parameters
 public Program(string a, int b) {

 name = a;
 num = b;
 }
 public static void Main() {
 // Here, the only default
 
 Program obj2 = new Program("Ganesh", 747);
 Console.WriteLine(Program.name + ", " + Program.num);
 }

 }
} 