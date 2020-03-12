using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca³kowanie
{

    static class Tool
    {

        public static double PoleTrapezu(double a, double b, double h)     //pole trapezu
        {
            return (a + b) * h / 2;
        }

        public static double PobierzLiczbe()                    //pobiera liczbê od u¿ytkownika
        {
            double number = 0;
            string temp = " ";

            while (!double.TryParse(temp, out number))
            {
                Console.WriteLine("Podaj liczbê...");
                temp = Console.ReadLine();
                
            }
            return number;
        }

        public static double PobierzZPrzedzialu(double a, double b)     //pobiera liczbê od u¿ytkownika z przedzia³u a, b
        {
            double number = 0;
            string temp = " ";

            while (!double.TryParse(temp, out number) || number <= a || number >= b)
            {
                Console.WriteLine("Podaj liczbê miêdzy " + a + " a " + b + "...");
                temp = Console.ReadLine();
                
            }
            return number;
        }

        public static double PobierzLiczbeWiekszaOdA(double a)        //pobiera liczbê wiêksz¹ od a
        {
            double number = 0;
            string temp = " ";

            while (!double.TryParse(temp, out number) || number < a)
            {
                Console.WriteLine("Podaj liczbê wiêksz¹ od " + a + "...");
                temp = Console.ReadLine();
                
            }
            return number;
        }





    }




































}