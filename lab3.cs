using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //zadanie 1
            /*int n = int.Parse(Console.ReadLine());
            int[] tab = new int[n];
            int i = 0;
            do
            {
                tab[i] = int.Parse(Console.ReadLine());
                i++;
            } while (i < n);
            foreach(int x in tab)
            {
                Console.WriteLine("{0}, ",x);
            }
            Console.ReadKey();*/


            //zadanie 2
            /* int[] tab1 = { -1, -2, 1, 3, -5, 7, 8, 6, -9, 4 };
             int[] tab2 = new int[10];
             int i = 0;
             foreach(int x in tab1)
             {
                 if(x > 0)
                 {
                     tab2[i] = x;
                 }
                 i++;
             }
             foreach(int y in tab2)
             {
                 Console.WriteLine("{0}", y);
             }
             Console.ReadKey();*/
            //zadanie 3
            /* int n = int.Parse(Console.ReadLine());
            int[] tab = new int[n];
            
            for(int i = 0; i < n; i++)
            {
                tab[i] = int.Parse(Console.ReadLine());

            }
            int max = tab[0];
            int min = tab[0];
            for(int i = 1; i < tab.Length; i++)
            {
                if (tab[i] > max)
                    max = tab[i];
                
            }
            foreach(int x in tab)
            {
                if (x == max)
                {
                    Console.WriteLine(Array.IndexOf(tab,max));
                    Console.WriteLine("najwieksza wartosc {0}", x);
                }
            }
            for (int i = 1; i < tab.Length; i++)
            {
                if (tab[i] < min)
                    min = tab[i];

            }
            foreach (int y in tab)
            {
                if (y == min)
                {
                    Console.WriteLine(Array.IndexOf(tab, min));
                    Console.WriteLine("Najmniejsza wartosc {0}", y);
                }
            }
            int suma = 0;
            int sr = 0;
            int dodatnie = 0;
            for(int i = 0; i < tab.Length; i++)
            {
                suma += tab[i];
                if (tab[i] > 0)
                    dodatnie++;
            }
            sr = suma / tab.Length;
            Console.WriteLine("srednia: {0}", sr);
            Console.WriteLine("Ilosc dodatnich {0}", dodatnie);
             */


            //zadanie 4
            /*int[] tab = new int[100];
            Random rand = new Random();
            for(int i = 0; i < 99; i++)
            {
                tab[i] = rand.Next(1, 1000);
            }
            int ileP = 0;
            int x = 0;
            for(int i = 0; i < 100; i++)
            {
                for(int j = 2; j < tab[i]; j++)
                {
                    if (tab[i] % j == 0)
                        x++;

                }
                if(x == 0)
                    ileP++;
                x = 0;
            }
            Console.WriteLine("{0}", ileP); */



            //zadanie 5
            /*int[] tab1 = { 1, 2, 3, 4, 5 };
            int[] tab2 = new int[5];
            Array.Copy(tab1, 0, tab2, 1, 4);
            tab2[0] = tab1[4];
            foreach(int x in tab2)
            {
                Console.WriteLine("{0}", x);
            }
                */

            //zadanie 6

            
            /*int[,] tab = { { 1,1,1,1,1}, {1,1,1,1,1}, { 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1 }  };
            int suma = 0;

            for (int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    Console.Write("{0,6}", tab[i, j]);
                    if( i == j)
                        suma += tab[i, j];
                }
                Console.WriteLine();
            }
            Console.WriteLine("Suma przekatnej: {0}", suma);
            */

            //zadanie 7











            Console.ReadKey();

        }
    }
}
