using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		
		//creating a dictionary using collection-initializer syntax
		var cities = new Dictionary<string, string>(){
			{"UK","London, Manchester, Birmingham"},
			{"USA","Chicago, New York, Washington"},
			{"India","Mumbai, New Delhi, Pune"}
		};
        foreach(var kvp in cities)
      		Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

          //SEARCHING AN ELEMENT IN A DICTIONARY

        var val="India";
            if(cities.ContainsKey(val))
            {
            Console.WriteLine(val+ "is found in cities");
            }

		cities.Add("Lucknow","BBD,1090,Kapoorthala");
        foreach(var kvp in cities)
      	Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
	       

                         // UPDATING THE VALUES IN DICTIONARY

           /*  cities["UK"] = "Liverpool, Bristol"; // update value of UK key
		    cities["USA"] = "Los Angeles, Boston"; // update value of USA key
		    cities["France"] = "Paris"; //throws run-time exception: KeyNotFoundException

		if(cities.ContainsKey("France")){
			cities["France"] = "Lucknow";
		}
		foreach(var kvp in cities)
			Console.WriteLine("Key: {0}, Value:{1}", kvp.Key, kvp.Value); */

                           //DELETING AN ELEMENT FROM DICTIONARY

            cities.Remove("USA"); // removes USA 
		      Console.WriteLine("Total Elements: {0}", cities.Count);
                foreach(var kvp in cities)
                	Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

            

            
 

	}
    }