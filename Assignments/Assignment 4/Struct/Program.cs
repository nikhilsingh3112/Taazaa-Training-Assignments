using System;
namespace ConsoleApplication {
 
// Defining structure
public struct Person
{
    // Declaring different data types
    public string Name;
    public int Age;
    public int Weight;
 
}
 
class Ganesh {
     
    // Main Method
    static void Main(string[] args)
    {
 
        // Declare P1 of type Person
        Person P1;
 
        // P1's data
        P1.Name = "Ganesh Pandey";
        P1.Age = 21;
        P1.Weight = 80;
 
        // Displaying the values
        Console.WriteLine("Data Stored in P1 is " +
                           P1.Name + ", age is " +
                           P1.Age + " and weight is " +
                           P1.Weight);
 
    }
}
}