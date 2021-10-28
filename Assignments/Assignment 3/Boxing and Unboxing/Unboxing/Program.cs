class TestUnboxing
{
    static void Main()
    {
        int i = 100;

        
        object o = i;//converting a value type into reference type is boxing
        int j=(int)o;// Unboxing

       

        
        System.Console.WriteLine("The value-type value = {0}", i);
        System.Console.WriteLine("The object-type value = {0}", j);
    }
}