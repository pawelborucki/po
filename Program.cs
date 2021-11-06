using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //zadanie 1
            /*int rok = int.Parse(Console.ReadLine());
            if (rok % 4 == 0 && rok % 400 == 0)
                Console.WriteLine("Przestepny");
            else if (rok % 4 == 0 && rok % 100 == 0)
                Console.WriteLine("Nie jest przestepny");
            else
                Console.WriteLine("Nie jest przestepny");
            Console.ReadKey(); */


            //zadanie 2
            /*int l1 = int.Parse(Console.ReadLine());
            int l2 = int.Parse(Console.ReadLine());
            if (l1 % l2 == 0)
                Console.WriteLine("liczba {1} jest dzielnikiem liczby {0}", l1, l2);
            else
                Console.WriteLine("liczba {1} nie jest dzielnikiem liczby {0}", l1, l2);
            Console.ReadKey();*/


            //zadanie 3
            /*int l1 = int.Parse(Console.ReadLine());
            int l2 = int.Parse(Console.ReadLine());
            int l3 = int.Parse(Console.ReadLine());
            if (l1 > l2)
            {
                if (l1 > l3)
                    Console.WriteLine("{0} jest najwieksze", l1);
                else
                    Console.WriteLine("{0} jest najwieksze", l3);
            }
            else if (l2 > l3)
                Console.WriteLine("{0} jest najwieksze", l2);
             else
                Console.WriteLine("{0} jest najwieksze", l3);
            Console.ReadKey();*/


            //zadanie 4
            /*double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double wynik = 0;
            Console.WriteLine("1 - dodawanie 2 - odejmowanie 3 - mnozenie 4 - dzielenie");
            int znak = int.Parse(Console.ReadLine());

            switch (znak)
            {
                case 1:
                    wynik = x + y;
                    Console.WriteLine("Suma wynosi {0}", wynik);
                    break;
                case 2:
                    wynik = x - y;
                    Console.WriteLine("Roznica wynosi {0}", wynik);
                    break;
                case 3:
                    wynik = x * y;
                    Console.WriteLine("Iloczyn wynosi {0}", wynik);
                    break;
                case 4:
                    wynik = x / y;
                    Console.WriteLine("Ilroaz wynosi {0}", wynik);
                    break;


            }
            Console.ReadKey();
            */


            //zadanie 5
            /*int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double delta = (b * b) - (4 * a * c);
            if (delta < 0)
                Console.WriteLine("Brak pierwiastkow");
            else if (delta == 0)
                Console.WriteLine("Jeden pierwiastek");
            else
                Console.WriteLine("Dwa pierwiastki");
            Console.ReadKey();*/

            //zadanie 6
            /*int masa = int.Parse(Console.ReadLine());
            int wzrost = int.Parse(Console.ReadLine());
            double bmi = masa / wzrost * wzrost;
            if (bmi < 16)
                Console.WriteLine("wyglodzenie");
            else if (bmi > 16 && bmi < 16.99)
                Console.WriteLine("wychudzenie");
            else if (bmi > 17 && bmi < 18.5)
                Console.WriteLine("niedowaga");
            else if (bmi > 18.5 && bmi < 24.99)
                Console.WriteLine("waga prawidlowa");
            else if (bmi > 25 && bmi < 29.99)
                Console.WriteLine("nadwaga");
            else if (bmi > 30 && bmi < 34.99)
                Console.WriteLine("otylosc 1 stopnia");
            else if(bmi > 35 && bmi < 39.99)
                Console.WriteLine("otylosc 2 stopnia");
            else
                Console.WriteLine("otylosc 3 stopnia");
            Console.ReadKey();*/


            //zadanie 7
            /*string numer = Console.ReadLine();
            switch (numer)
            {
                case "1":
                    Console.WriteLine("Poniedziałek");
                    break;
                case "2":
                    Console.WriteLine("Wtorek");
                    break;
                case "3":
                    Console.WriteLine("Środa");
                    break;
                case "4":
                    Console.WriteLine("Czwartek");
                    break;
                case "5":
                    Console.WriteLine("Piątek");
                    break;
                case "6":
                    Console.WriteLine("Sobota");
                    break;
                case "7":
                    Console.WriteLine("Niedziela");
                    break;

            }
            Console.ReadKey();*/


            //zadanie 8
            /*double sr = double.Parse(Console.ReadLine());
            if (sr > 2 && sr < 3.99)
                Console.WriteLine("0,00zl");
            else if (sr > 4 && sr < 4.79)
                Console.WriteLine("350zł");
            else if (sr > 4.8 && sr < 5)
                Console.WriteLine("550zł");
            else
                Console.WriteLine("Błąd");
            Console.ReadKey();
            */


            //zadanie 9a
            /*int lw = int.Parse(Console.ReadLine());
            for (int i = lw; i >= 1; i--)
            {

                for (int j = lw; j >= i; j--)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            */

            //zadanie 9b
            /*int lw = int.Parse(Console.ReadLine());
            for(int i = 1; i <= lw; i++)
            {

                for(int j = i; j <= lw; j++)
                {
                    Console.Write(" ");
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();*/


            //zadanie 9c
            /*int lw = int.Parse(Console.ReadLine());
            for (int i = lw; i >= 1; i--)
            {
               Console.Write(" ");
               for (int j = i; j <= lw; j++)
               {

                   Console.Write("*");
               }
               Console.WriteLine();
            }
            Console.ReadKey();*/


            //zadanie 10
            /*int n = int.Parse(Console.ReadLine());
            int silnia = 1;
            for (int i = 2; i <= n; i++)
                silnia *= i;
            Console.WriteLine("{0}", silnia);
            Console.ReadKey();*/

            //zadanie 11
            /*int a = 1;
            int i = 1;
            while(a < 100)
            {
                i++;
                a += i;
                
            }
            Console.WriteLine("{0}", i);
            Console.ReadKey();*/
            //zadanie 12
            /*int suma = 0;
            int n = 0;
            do
            {
                n = int.Parse(Console.ReadLine());
                suma += n;
            } while (n != 0);
            Console.WriteLine("{0}", suma);
            Console.ReadKey();*/


            //zadanie 13
            /*int n = int.Parse(Console.ReadLine());
            int suma = 0;
            for(int i = 1; i <=n; i++)
            {
                if (i % 2 == 0)
                    suma -= i;
                else
                    suma += i;

            }
            Console.WriteLine("{0}", suma);
            Console.ReadKey();*/

            //zadanie 14
            int n = int.Parse(Console.ReadLine());
            int suma = 0;
            for(int i = 1; i <= n; i++)
            {
                for(int j = i; j >= 1; j--)
                {
                    if (i % j == 0)
                        suma += j;
                }
                if (suma == i)
                    Console.WriteLine("{0}", suma);
            }
            Console.ReadKey();
        }





    }
}
