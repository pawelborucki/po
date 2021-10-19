using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //zadanie 1 
            /*   double C = Convert.ToDouble(Console.ReadLine());
               double F = 32 + 9.0 / 5 * C;
               Console.WriteLine(F);
               Console.ReadKey(); */
            //zadanie 2
            /*double a, b, c;
            Console.WriteLine("Podaj a, b, c");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            double delta = b * b - 4 * a * c;
            Console.WriteLine(delta);
            Console.ReadKey();*/
            //zadanie 3
            /* double waga, wzrost;
            Console.WriteLine("Podaj wage w kilogramach  i wzrost w metrach");
            waga = Convert.ToDouble(Console.ReadLine());
            wzrost = Convert.ToDouble(Console.ReadLine());
            double  bmi = waga / wzrost;
            Console.WriteLine(bmi); */
            //zadanie 4 odp 202
            /*int x = 100;
            Console.WriteLine(++x * 2);
            Console.ReadKey();*/
            //zadanie 5 odp 12
            /*int x = 2, y = 3;
            x *= y * 2;
            Console.WriteLine(x);
            Console.ReadKey();*/
            //zadanie 6 odp 3
            /*int x, y = 4;
            x = (y -= 2);
            x = y++;
            x = y--;
            Console.WriteLine(x);
            Console.ReadKey(); */
            //zadanie 7 odp 7
            /*int x, y = 5;
            x = ++y * 2;
            x = y++;
            x = y--;
            Console.WriteLine(++y);
            Console.ReadKey();*/
            //zadanie 8 odp a
            /*bool x;
            int y = 1, z = 1;
            x = (y == 1 && z++ == 1);
            Console.WriteLine("x = {0), y = {1}, z = {2}", x, y, z);
            Console.ReadKey(); */
            //zadanie 9a false 2 4 2
            /*int x = 1, y = 4, z = 2;
            bool wynik = (x++ > 1 && y++ == 4 && z-- > 0); 
            Console.WriteLine("wynik={0} x={1}  y={2}  z={3}", wynik, x, y, z);
            Console.ReadKey();*/
            //zadanie 9b false 2 5 2
            /*int x = 1, y = 4, z = 2;
            bool wynik = (x++ > 1 & y++ == 4 && z-- > 0);
            Console.WriteLine("wynik={0} x={1}  y={2}  z={3}", wynik, x, y, z);
            Console.ReadKey();*/
            //zadanie 9c false 2 5 1
            /*int x = 1, y = 4, z = 2;
            bool wynik = (x++ > 1 & y++ == 4 & z-- > 0);
            Console.WriteLine("wynik={0} x={1}  y={2}  z={3}", wynik, x, y, z);
            Console.ReadKey();*/
            //zadanie 9d true 1 3 5
            /*int x = 1, y = 3, z = 4;
            bool wynik = (x == 1 || y++ > 2 || ++z > 0);
            Console.WriteLine("wynik={0} x={1}  y={2}  z={3}", wynik, x, y, z);
            Console.ReadKey();*/
            //zadanie 9e true 1 4 4
            /*int x = 1, y = 3, z = 4;
            bool wynik = (x == 1 | y++ > 2 || ++z > 0);
            Console.WriteLine("wynik={0} x={1}  y={2}  z={3}", wynik, x, y, z);
            Console.ReadKey();*/
            //zadanie 9f true 1 4 5
            /*int x = 1, y = 3, z = 4;
            bool wynik = (x == 1 | y++ > 2 | ++z > 0);
            Console.WriteLine("wynik={0} x={1}  y={2}  z={3}", wynik, x, y, z);
            Console.ReadKey();*/

            //zadanie 10
            double powierzchnia = 100, osoby = 10;
            double gestoscZaludnienia = osoby / powierzchnia;
            Console.WriteLine(gestoscZaludnienia);
            Console.ReadKey();
        }
    }
}
