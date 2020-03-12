using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTVandAGD
{
    class Program
    {
       
        class Hoover
        {
            private static bool Is_plugged_in = false;
            private static bool Is_turned_on = false;
            private static bool Is_fast_mode_on = false;

            public bool IS_PLUG_IN
            {
                get
                {
                    return Is_plugged_in;
                }

                set
                {
                    Is_plugged_in = false;
                }
            }

            public bool IS_TURN_ON
            {
                get
                {
                    return Is_turned_on;
                }

                set
                {
                    Is_turned_on = false;
                }
            }

            public bool FAST_MOD_ON
            {
                get
                {
                    return Is_fast_mode_on;
                }

                set
                {
                    Is_fast_mode_on = false;
                }
            }

            
            public string Brand { get;set; }
            public string Type { get; set; }
            public int PipeLength { get; set; }
            public int BagsNumber { get; set; }

            public int Power1;
            
            public Hoover( string Brand, string Type, int PipeLength, int BagsNumber, int Power1)
            {
                this.Brand = Brand;
                this.Type = Type;
                this.PipeLength = PipeLength;
                this.BagsNumber = BagsNumber;
                this.Power1 = Power1;
            }


            



            public static void Change(ref bool variable)
            {
                variable = !variable;
            }

            public void PlugIn()
            {
                if (Is_plugged_in == true)
                {
                    Console.WriteLine("It's already plugged in!");

                }

                else
                {
                    Console.WriteLine("Connected!");
                    Change(ref Is_plugged_in);

                }
            }

            public  void PlugOff()
            {
                if (Is_plugged_in == true)
                {
                    Console.WriteLine("Disconnected!");
                    Change(ref Is_plugged_in);
                }

                else
                {
                    Console.WriteLine("It's already plugged off");
                  

                }
            }


            public  void TurnOn()
            {
                if (Is_turned_on == true)
                {
                    Console.WriteLine("It's already turned on!");

                }

                 if (Is_turned_on == false || Is_plugged_in==false)
                {
                    Console.WriteLine("First plug in the hoover!");

                }

                if (Is_turned_on == false || Is_plugged_in == true)
                {
                    Console.WriteLine("bzz!");
                    Change(ref Is_turned_on);

                }
            }

            public  void TurnOff()
            {
                if (Is_turned_on == false)
                {
                    Console.WriteLine("It's already turned off!");

                }

                if(Is_turned_on==true)
                {
                    Console.WriteLine("bzzz...bzz...bz... ...");
                    Change(ref Is_turned_on);

                }

                if(Is_turned_on==true || Is_fast_mode_on == true)
                {
                    Console.WriteLine("BZZZ...BZZ...BZ... ...");
                    Change(ref Is_turned_on);
                }
            }

            public  void FastModeOn()
            {
                if (Is_fast_mode_on == true)
                {
                    Console.WriteLine("Fast mode is already on!");

                }

                if(Is_fast_mode_on==false || Is_turned_on ==false)
                {
                    Console.WriteLine("Please turn on the hoover first!");
                }

                if (Is_fast_mode_on == false || Is_turned_on == true)
                {
                    Console.WriteLine("BZZ!!!");
                    Change(ref Is_fast_mode_on);
         
                }
            }

            public  void FastModeOff()
            {
                if(Is_fast_mode_on == false)
                {
                    Console.WriteLine("Fast mode is already off!");
                }

                else
                {
                    Console.WriteLine("bzz!");
                    Change(ref Is_fast_mode_on);
                }

            }

          

        }

        

       class Flashlight
        {
            private static bool Is_turned_on=false;
            private static bool Is_battery_in=false;
            private static bool Better_light_on=false;

            public static FlashHoover operator +(Hoover Hoover1, Flashlight Flashlight1)
            {
                FlashHoover F = new FlashHoover();
                F.Power = Flashlight1.Power2 + Hoover1.Power1;
                return F;
            }
             public  void Add()
            {
                FlashHoover F = new FlashHoover();
                Hoover Hoover1 = new Hoover("BenQ", "With cable", 4, 4, 100);
                Flashlight Flashlight1 = new Flashlight("Luna", 20, 1, 50);
                 
                F = Hoover1 + Flashlight1;
                Console.WriteLine("Power sum: " + F);
            }

            
            public static bool operator >(Hoover Hoover1, Flashlight Flashlight1)
            {
                bool status = false;
                
                FlashHoover F = new FlashHoover();
                if (Hoover1.Power1 > Flashlight1.Power2)
                {

                    status = true;
                }
                return status;
            }

            public void More()
            {
                FlashHoover F = new FlashHoover();
                Hoover Hoover1 = new Hoover("BenQ", "With cable", 4, 4, 100);
                Flashlight Flashlight1 = new Flashlight("Luna", 20, 1, 50);
                
                if ( Hoover1>Flashlight1)
                {
                    Console.WriteLine("Hoover consumes more power");
                }
            }

            public static bool operator <(Hoover Hoover1, Flashlight Flashlight1)
            {
                FlashHoover F = new FlashHoover();

                bool status = false;

                if (Flashlight1.Power2 < Hoover1.Power1) 
                {

                    status = true;
                }
                return status;
            }

            public void Less()
            {
                FlashHoover F = new FlashHoover();
                Hoover Hoover1 = new Hoover("BenQ", "With cable", 4, 4, 100);
                Flashlight Flashlight1 = new Flashlight("Luna", 20, 1, 50);
                
                if (Hoover1<Flashlight1)
                {
                    Console.WriteLine("Flaslight consumes less power");
                }
            }


            public bool IS_TURN_ON
            {
                get
                {
                    return Is_turned_on;
                }

                set
                {
                    Is_turned_on = false;
                }
            }

            public bool IS_BATT_IN
            {
                get
                {
                    return Is_battery_in;
                }

                set
                {
                    Is_battery_in = false;
                }
            }

            public bool BETT_LIGHT_ON
            {
                get
                {
                    return Better_light_on;
                }

                set
                {
                    Better_light_on = false;
                }
            }

            public string Brand { get; set; }
            public int Length { get; set; }
            public int BatteriesNumber { get; set; }

            public int Power2 = 50;
            public Flashlight(string Brand, int Length, int BatteriesNumber, int Power2)
            {
                this.Brand = Brand;
                this.Length = Length;
                this.BatteriesNumber = BatteriesNumber;
                this.Power2 = Power2;
            }

            public void Change1( out bool variable)
            {
                variable = false;
            }
            public void Change2(out bool variable2)
            {
                variable2 = true;
            }

            public void PutBatteryIn()
            {
                if (Is_battery_in == true)
                {
                    Console.WriteLine("Battery is already inside!");
                }

                else
                {
                    Console.WriteLine("Battery has been put inside");
                    Change2(out Is_battery_in);
                }
            }


            public void TurnOn()
            {
                if (Is_turned_on == true)
                {
                    Console.WriteLine("The flashlight is already turned on!");
                }

                if(Is_turned_on==false || Is_battery_in==true)
                {
                    Console.WriteLine("======C| < |||||||||||||||||| ");
                    Change2(out Is_turned_on);

                }

                else
                {
                    Console.WriteLine("You need a battery!");
                }
            }
                
            public void TurnOff()
            {
                if (Is_turned_on == false)
                {
                    Console.WriteLine("The flashlight is already turned off");
                }

                if (Is_turned_on == true)
                {
                    Console.WriteLine("======C|");
                    Change1(out Is_turned_on);
                }
            }

            public void BetterLightOn()
            {
                if (Is_turned_on == true)
                {
                    Console.WriteLine("======C| <@@@@@@@@@@@@@@@@@@@@ ");
                    Change2(out Better_light_on);
                }

                else
                {
                    Console.WriteLine("Turn on the flashlight!!!");
                }
            }

            public void BetterLightOff()
            {
                if (Better_light_on == true)
                {
                    Console.WriteLine("======C| < |||||||||||||||||| ");
                    Change1(out Better_light_on);
                }

                else
                {
                    Console.WriteLine("Better light is already off!!! ");
                }
            }
        }

        public static void ActionMenu()
        {
            int x;
            int z;
            int y;

            Console.WriteLine("WHAT DO YOU WANT TO DO?");
            Console.WriteLine("1 - ACTION WITH HOOVER      2 - ACTION WITH FLASHLIGHT    3 - ADD    4 - MORE POWER     5 - LESS POWER");
            x = Convert.ToInt32(Console.ReadLine());

            if (x == 1)
            {
                Console.WriteLine("The Hoover:");
                Console.WriteLine("1 - PLUG IN   2 - PLUG OFF   3 - TURN ON   4 - TURN OFF   5 - FAST MODE ON   6 - FAST MODE OFF");
                z = Convert.ToInt32(Console.ReadLine());

                if (z == 1)
                {
                    Hoover Hoover1 = new Hoover("BenQ", "With cable", 4, 4,100);
                    Hoover1.PlugIn();
                    ActionMenu();
                }

                if (z == 2)
                {
                    Hoover Hoover1 = new Hoover("BenQ", "With cable", 4, 4,100);
                    Hoover1.PlugOff();
                    ActionMenu();
                }

                if (z == 3)
                {
                    Hoover Hoover1 = new Hoover("BenQ", "With cable", 4, 4,100);
                    Hoover1.TurnOn();
                    ActionMenu();
                }

                if (z == 4)
                {
                    Hoover Hoover1 = new Hoover("BenQ", "With cable", 4, 4,100);
                    Hoover1.TurnOff();
                    ActionMenu();
                }

                if (z == 5)
                {
                    Hoover Hoover1 = new Hoover("BenQ", "With cable", 4, 4,100);
                    Hoover1.FastModeOn();
                    ActionMenu();
                }

                if (z == 6)
                {
                    Hoover Hoover1 = new Hoover("BenQ", "With cable", 4, 4,100);
                    Hoover1.FastModeOff();
                    ActionMenu();
                }



            }

            if (x == 2)
            {
                Console.WriteLine("The Flashlight:");
                Console.WriteLine("1 - PUT BATTERY IN   2 - TURN ON   3 - TURN OFF   4 - BETTER LIGHT ON   5 - BETTER LIGHT OFF");
                y = Convert.ToInt32(Console.ReadLine());

                if (y == 1)
                {
                    Flashlight Flashlight1 = new Flashlight("Luna", 20, 1,50);
                    Flashlight1.PutBatteryIn();
                    ActionMenu();
                }

                if (y == 2)
                {
                    Flashlight Flashlight1 = new Flashlight("Luna", 20, 1,50);
                    Flashlight1.TurnOn();
                    ActionMenu();
                }

                if (y == 3)
                {
                    Flashlight Flashlight1 = new Flashlight("Luna", 20, 1,50);
                    Flashlight1.TurnOff();
                    ActionMenu();
                }

                if (y == 4)
                {
                    Flashlight Flashlight1 = new Flashlight("Luna", 20, 1,50);
                    Flashlight1.BetterLightOn();
                    ActionMenu();
                }

                if (y == 5)
                {
                    Flashlight Flashlight1 = new Flashlight("Luna", 20, 1,50);
                    Flashlight1.BetterLightOff();
                    ActionMenu();
                }
            }

            if (x == 3)
            {
                Hoover Hoover1 = new Hoover("BenQ", "With cable", 4, 4, 100);
                Flashlight Flashlight1 = new Flashlight("Luna", 20, 1, 50);
                FlashHoover F = new FlashHoover();
                Flashlight1.Add(); 
                ActionMenu();
            }

            if (x == 4)
            {
                Hoover Hoover1 = new Hoover("BenQ", "With cable", 4, 4, 100);
                Flashlight Flashlight1 = new Flashlight("Luna", 20, 1, 50);
                FlashHoover F = new FlashHoover();
                Flashlight1.More();
                ActionMenu();
            }

            if (x == 5)
            {
                Hoover Hoover1 = new Hoover("BenQ", "With cable", 4, 4, 100);
                Flashlight Flashlight1 = new Flashlight("Luna", 20, 1, 50);
                FlashHoover F = new FlashHoover();
                Flashlight1.Less();
                ActionMenu();
            }

            Console.ReadKey();
        }

         class FlashHoover
        {
            public int Power;
            
            

            


        }

        


        static void Main(string[] args)
        {
           
            
            ActionMenu();

        }
    }
}
