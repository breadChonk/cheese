using System;


namespace tehtävä1_cs



{

    internal class Program
	{

    private static int Neliakaks(int xluku) 

        { 

            int vom = xluku * xluku; 

             

            return vom; 

        } 
    

        static void Main(string[] args)

        {
         Console.WriteLine("Emma.Parviainen / portfolio 1");
         Console.WriteLine("");

         Console.Write("Anna luku, josta voin  laskea neliön? ");
         int luku = int.Parse(Console.ReadLine());
         int nelio = Neliakaks(luku); 

             

            Console.WriteLine(""); 

           

            Console.WriteLine("Luvun {0} neliö on {1}", luku, nelio); 


        }
    }
}