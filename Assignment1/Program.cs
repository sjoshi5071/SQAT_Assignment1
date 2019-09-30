using System;

namespace Assignment1
{
    class Program
    {
      

        static void Main(string[] args)
        {

            Console.WriteLine("Enter the dimensions as follows: ");
            Console.ReadLine();
            {
                
                string dim;
                int idim;
                int len1, len2, len3;
                do
                {
                        //For length 1
                        
                        Console.WriteLine("Enter the dimesion for Length 1: ");
                        int.TryParse(Console.ReadLine(), out len1);

                        //For length 2
                        
                        Console.WriteLine("Enter the dimesion for Length 2: ");
                        int.TryParse(Console.ReadLine(), out len2);

                        //For length 3
                        
                        Console.WriteLine("Enter the dimesion for Length 3: ");
                        int.TryParse(Console.ReadLine(), out len3);

                    //calling function
                    Console.WriteLine(TriangleSolver.TriangleType(len1, len2, len3));

                    //If wants to continue or wants to exit
                    Console.WriteLine("Enter 1 for entering the dimensions and 2 to exit.");
                        dim = Console.ReadLine();
                        int.TryParse(dim, out idim);
                    
                } while (idim == 1);

                //calling function
                //Console.WriteLine(TriangleSolver.TriangleType(len1, len2, len3));

            }
   
        }
    }
}
