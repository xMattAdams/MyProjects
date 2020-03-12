using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca�kowanie
{

    static class Tool
    {

        public static double PoleTrapezu(double a, double b, double h)     //pole trapezu
        {
            return (a + b) * h / 2;
        }

        public static double PobierzLiczbe()                    //pobiera liczb� od u�ytkownika
        {
            double number = 0;
            string temp = " ";

            while (!double.TryParse(temp, out number))
            {
                Console.WriteLine("Podaj liczb�...");
                temp = Console.ReadLine();
                
            }
            return number;
        }

        public static double PobierzZPrzedzialu(double a, double b)     //pobiera liczb� od u�ytkownika z przedzia�u a, b
        {
            double number = 0;
            string temp = " ";

            while (!double.TryParse(temp, out number) || number <= a || number >= b)
            {
                Console.WriteLine("Podaj liczb� mi�dzy " + a + " a " + b + "...");
                temp = Console.ReadLine();
                
            }
            return number;
        }

        public static double PobierzLiczbeWiekszaOdA(double a)        //pobiera liczb� wi�ksz� od a
        {
            double number = 0;
            string temp = " ";

            while (!double.TryParse(temp, out number) || number < a)
            {
                Console.WriteLine("Podaj liczb� wi�ksz� od " + a + "...");
                temp = Console.ReadLine();
                
            }
            return number;
        }





    }




































}