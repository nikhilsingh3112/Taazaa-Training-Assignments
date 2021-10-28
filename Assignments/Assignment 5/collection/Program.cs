using System;
using collection.Models2;
namespace collection
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj=new galaxyInfo();
            var arrayList=obj.galaxayAdd();
            int count=arrayList.Count;
            for(int i=0;i<count;i++)
            {
                Console.WriteLine(arrayList[i]);
            }  
            var objlist=new  galaxyInfo();
            var List=objlist.galaxyDetails();
            int count1=List.Count;
            for(int i=0;i<count1;i++)
            {
                Console.WriteLine(List[i].Name+"  " +List[i].MegaLightYears);
            }  

        }
    }
}
