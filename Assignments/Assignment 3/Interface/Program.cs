using System;  
public interface Vehicle  
{  
    void accelerate();// by default methods are abstract  
}  
public class car : Vehicle  
{  
    public void accelerate()  
    {  
        Console.WriteLine("is Private property");  
    }  
}  
public class bus : Vehicle  
{  
    public void accelerate()  
    {  
        Console.WriteLine("is Public property");  
    }  
}  
public class TestInterface  
{  
    public static void Main()  
    {  
        car d = new car();   
         d.accelerate();  
        bus d1 = new bus();  
         d1.accelerate();  
    }  
}