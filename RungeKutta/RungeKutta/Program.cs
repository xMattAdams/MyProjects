using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RungeKutta
{
    class Program
    {

       class RungeKutta
        {
            static double PoleTrapezu;
            static double Dokladnosc=0.0001;
            

                static double Funkcja(double x, double y)
            {
                return (5 * Math.Pow(x, 2) - y) / Math.Pow(Math.E, (x + y));
            }
            public static double Algorytm(double x0, double y0, double x, double h)
            {


                
                double R1, R2, R3, R4;

                double y = y0;



                //pętla
                
                for (x0=0; x0 < x; x0 += h )
                {
                    double yPrzed;
                    //liczenie kolejnych wartości y zgodnie z krokiem h
                    do
                    {
                         yPrzed = y;

                        R1 = h * (Funkcja(x0, y));

                        R2 = h * (Funkcja(x0 + 0.5 * h, y + 0.5 * R1));


                        R3 = h * (Funkcja(x0 + 0.5 * h, y + 0.5 * R2));


                        R4 = h * (Funkcja(x0 + h, y + R3));



                        //aktualizacja kolejnych wartości y
                        y = y + (1.0 / 6.0) * (R1 + 2 * R2 + 2 * R3 + R4);
                        
                        //zmienny krok
                        if (yPrzed - y > Dokladnosc || y-yPrzed>Dokladnosc)
                        {
                            h = h / 2;
                        }
                        else if (yPrzed - y < Dokladnosc - Dokladnosc / 10 || y - yPrzed < Dokladnosc- Dokladnosc / 10)
                        {
                            h = 2 * h;
                        }

                        // całka metoda trapezów
                        if (yPrzed != 0)
                        {
                            double RungePole = ((yPrzed + y) * h) / 2;
                            PoleTrapezu += RungePole;
                        }

                    } while (yPrzed - y >= Dokladnosc & yPrzed - y <= Dokladnosc - Dokladnosc / 10 || y - yPrzed >= Dokladnosc & y - yPrzed <= Dokladnosc - Dokladnosc / 10);
                        Console.WriteLine("Wartość kolejnego y:" + y);
                    


                    
                }

                return y;
            }
            
            public void Wynik()
            {
                double x0 = 0, y = 1, x = 1, h = 0.1;  //można edytować dla uzyskania innych wartości

                Console.WriteLine("\n Wartość y" + " w punkcie x wynosi : " + Algorytm(x0, y, x, h));
                Console.WriteLine("Całka metoda trapezów z Runge-Kuttą: " + PoleTrapezu);
                Console.ReadLine();

            }
            
        }
       



        static void Main(string[] args)
        {
            RungeKutta Result = new RungeKutta();
            Result.Wynik();
        }
                                 
                    
    }
}
