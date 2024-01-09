using System;

namespace yesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Emma Parviainen / tehtävä 9");
            Console.WriteLine("");

            Console.WriteLine("tehtävä 9");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("");
           
                //esim1
                int maara = 1;
            
            int luku = 0;
            Console.WriteLine("Anna viisi lukua niin lasken niiden keskiarvon ");

            int[] luvut = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("");
               
                Console.Write("Anna luku {0}. ", maara);
                int luvu = int.Parse(Console.ReadLine());
                maara = maara + 1;
                
                luvut[i] = luvu;
            }
            int wam = 0;
            foreach(int wan in luvut)
            {
                wam += wan;

            }
            wam = wam / 5;
            string wab = string.Format("{0,10:0.00}", wam);
            Console.WriteLine("Keskiarvo on {0}", wab);


        }

    }
}