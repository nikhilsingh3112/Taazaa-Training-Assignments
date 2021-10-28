//A jagged array is an array whose elements are arrays, possibly of different sizes.
// A jagged array is sometimes called an "array of arrays."

//In c#, a jagged array can be initialized with two square brackets [][]. 
//The first square bracket will specify the size of an array, 
//and the second one will specify the dimension of the array, which will be stored as a value.
public class JaggedArray  
{  
    public static void Main()  
    {  
        int[][] arr = new int[2][];// Declare the array  
  
        arr[0] = new int[] { 11, 21, 56, 78 };// Initialize the array          
        arr[1] = new int[] { 42, 61, 37, 41, 59, 63 };  
  
        // Traverse array elements  
        for (int i = 0; i < arr.Length; i++)  
        {  
            for (int j = 0; j < arr[i].Length; j++)  
            {  
                System.Console.Write(arr[i][j]+" ");  
            }  
            System.Console.WriteLine();  
        }  
    }  
}  