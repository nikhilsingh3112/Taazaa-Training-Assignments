using System;
namespace MyApplication
{
  class Program   
  {
    enum Week   //An enum is a special "class" that represents a group of constants (unchangeable/read-only variables).
    {
      Monday,    
      Tuesday,   
      Wednesday,      
      Thursday,      
      Friday,        
      Saturday,       
      Sunday        
    }
    static void Main(string[] args)
    {
      int myNum = (int) Week.Friday;  //You can access enum items with the dot syntax
      Console.WriteLine(myNum);  //To get the integer value from an item, you must explicitly convert the item to an int
    }
  }
}
