using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Całkowanie
{
    class Program
    {
            double x1, x2; //obszar całkowania (przedział)
            double h; //stopień całkowania
            double result; //wynik całkowania
            double derivative;
            int n; //podział równe części - im więcej, tym większa dokładność, bo więcej prostokątów/trapezów
            
            double krok = 1;
            double f(double x) { return -x * x - x + 10; } //dana funkcja



            public void Interfejs()
            {
                int a;
                Console.WriteLine("CO CHCESZ ZROBIC?");
                Console.WriteLine("1 - OBLICZYC POCHODNA     2 - OBLICZYC CALKE METODA PROSTOKATOW     3 - OBLICZYC CALKE METODA TRAPEZOW");
                a = Convert.ToInt32(Console.ReadLine());

                switch (a)
                {
                    case 1:

                        ObliczPochodna();
                        Console.WriteLine("");
                        Interfejs();
                        break;

                    case 2:

                        ObliczCalkeProstokaty();
                        Console.WriteLine("");
                        Interfejs();
                        break;

                    case 3:

                        ObliczCalkeTrapezy();
                        Console.WriteLine("");
                        Interfejs();
                        break;
                }
            }

            //pochodna

            public void ObliczPochodna()
            {
                Console.WriteLine("Wybierz przedział");
                Console.Write("x1 =  ");
                x1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("x2 =  ");
                x2 = Convert.ToInt32(Console.ReadLine());


                h = (x2 - x1) / (double)n;

                derivative = f(x1 + h) - f(x1 - h) / 2 * h;

                Console.WriteLine("Pochodna wynosi  " + derivative);



            }



            void ObliczCalkeProstokaty()
            {

                Console.WriteLine("Wybierz przedzial calkowania: ");
                Console.Write("x1 =  ");
                x1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("x2 =  ");
                x2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Okresl dokladnosc calkowania: ");
                Console.Write("n = ");
                n = Convert.ToInt32(Console.ReadLine());

                if (n > 0 || n != 0)
                {
                    Console.WriteLine("Podana dokladnosc calkowania: ");
                }

                else
                {
                    Console.WriteLine("BLAD!!! WARTOSC  n  NIE MOZE BYC MNIEJSZA LUB ROWNA 0! " + n);
                    Interfejs();
                }


                //krok calkowania
                h = (x2 - x1) / (double)n;

                Console.WriteLine("Krok calkowania: " + h);


                //całka

                result = 0;

                for (int i = 1; i <= n; i++)
                {
                    result = result + f(x1 + i * h) * h; // i przesuwa nas do kolejnych prostokątów o odległość h i liczy ich pole
                }

                Console.WriteLine("");
                Console.WriteLine("Wynik calkowania metoda prostokatow: " + result);


            }


            void ObliczCalkeTrapezy()
            {

            Console.WriteLine("Wybierz przedzial calkowania: ");

            Console.Write("x1 =  ");
            x1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("x2 =  ");
            x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj ilość części: ");
            n = Convert.ToInt32(Console.ReadLine());

            krok = (x2 - x1) /n;


            double y = 0, y2 = 0;   // y to wartość f(x), a y2 f(x) + krok
            double i = x1;  // i to x czyli początek przedziału podanego przez użytkownika
            result = 0; //wynik końcowy 
            double licznik = 0;   // ilość iteracji
            Console.WriteLine("Podaj % dokładności...");   // 
            double roznica = Tool.PobierzZPrzedzialu(0, 1);     // bierze stopień dokładności od usera
            Console.WriteLine("Metoda mieszana: ");
            Console.WriteLine("Krok " + n + " przedział " + x1 + " " + x2);
            double NastKrok = krok;


            while (i < x2)  //lecimy az do konca przedzialu 
            {

                y = f(i);
                y2 = f(i + NastKrok);
                if (y > 0 && y2 > 0)                
                {
                    if (y < y2 * roznica || y * roznica > y2)
                    {       // sprawdzamy czy różnica między y a y2 jest większa niż 100% 
                        do
                        {
                            licznik++;    
                            y = f(i);   // liczy f(x) dla obecnej pozycji i
                            y2 =f(i + NastKrok);   //liczy następną pozycję i zwiększoną o krok NastKrok
                            Console.WriteLine("ZMNIEJSZANIE => f(x):" + y + " " + " "+ "f(x) + krok: " + y2 + "\t" + "Krok:" + NastKrok + "\t " + " " + i + " " + " " + "Wynik: " + result);
                            if (y < y2 * roznica || y * roznica > y2)
                            {
                                NastKrok /= 2;  
                            }
                        } while (y < y2 * roznica || y * roznica > y2);       // dopóki różnica jest większa, zmniejsza rozmiar x2
                    }
                    else
                    {  //jeżeli różnica nie jest większa niż 100%, zwiększa krok
                        do
                        {
                            licznik++;    
                            y = f(i);
                            y2 = f(i + NastKrok);
                            Console.WriteLine("ZWIĘKSZANIE => f(x):" + y + " " + " " + " f(x) + krok:" + y2 + "\t" + "Krok:" + NastKrok + "\t " + " "+ i + " " + " " + "Wynik: " + result); // NastKrok to rozmiar kroku, a i to obecna pozycja x
                            NastKrok *= 2;  
                        } while (y < y2 * roznica || y * roznica > y2);
                    }
                    result += Tool.PoleTrapezu(y, y2, NastKrok);  
                }

                i += NastKrok;  // przesuwam naszą pozycje x o wartość NastKrok
            }
            
            Console.WriteLine("Metoda trapezów ze zmienną liczbą kroków");
            Console.WriteLine("Wynik to " + result);
            Console.WriteLine("Liczba iteracji " + licznik);



            Console.ReadKey();
            }

    
        static void Main(string[] args)
        {
            Program Calc = new Program();
            Calc.Interfejs();
        }
    }
}
