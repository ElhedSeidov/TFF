using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp4
{
    public class Program
    {
        static void Main(string[] args)
        {
           
                int x = Convert.ToInt32(Console.ReadLine()) ;
               
                Console.WriteLine((Months)x);
               
            
            
        }  
            
    }



    enum Months
    {
        January, February, March, April, May, June, July, August, September, October, November,  December
    }
} 