using System;
using System.Collections.Generic;

namespace MontyHallProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine($"Testing {Tries:N0} Tries");
                TestAlwaysStay();
                TestAlwaysSwitch();
                TestRandomStaySwitch();
                Console.WriteLine("Press R to repeat the expirement");
                if (Console.ReadKey(true).KeyChar != 'r')
                {
                    return;
                }
            } while (true);
        }
        static int Tries = 10_000;
        static int[] DoorsCount = { 3, 10, 100, 10_000 };
        //test on sets of 3 then 10 then 1000
        public static void TestAlwaysStay()
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("============ Test Awalys Stay ===========");
            Console.WriteLine("=========================================");

            Dictionary<int, int> SuccessTimes = new Dictionary<int, int>();

            foreach (var doors in DoorsCount)
            {
                var temp = 0;
                for (int i = 0; i < Tries; i++)
                {
                    var correctDoor = RNG_Inclusive(1, doors);
                    var pickedDoor = RNG_Inclusive(1, doors);
                    if (correctDoor == pickedDoor)
                        temp++;
                }
                SuccessTimes[doors] = temp;
                Console.WriteLine($"Success for {doors:N0} doors: {temp:N0} ({Math.Round(100d * temp / Tries, 2)}% success rate)");
            }
            Console.WriteLine("=========================================");
        }
        public static void TestAlwaysSwitch()
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("=========== Test Awalys Switch ==========");
            Console.WriteLine("=========================================");
            //repeat 10000 times
            Dictionary<int, int> SuccessTimes = new Dictionary<int, int>();

            foreach (var doors in DoorsCount)
            {
                var temp = 0;
                for (int i = 0; i < Tries; i++)
                {
                    var correctDoor = RNG_Inclusive(1, doors);
                    var pickedDoor = RNG_Inclusive(1, doors);
                    if (correctDoor != pickedDoor) //when switching, you are checking if the other door is the correct one, and the picked door is the wrong one
                        temp++;
                }
                SuccessTimes[doors] = temp;
                Console.WriteLine($"Success for {doors:N0} doors: {temp:N0} ({Math.Round(100d * temp / Tries, 2)}% success rate)");
            }
            Console.WriteLine("=========================================");
        }
        public static void TestRandomStaySwitch()
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("=============== Test Random =============");
            Console.WriteLine("=========================================");
            //repeat 10000 times
            Dictionary<int, int> SuccessTimes = new Dictionary<int, int>();
            foreach (var doors in DoorsCount)
            {
                var temp = 0;
                for (int i = 0; i < Tries; i++)
                {
                    var correctDoor = RNG_Inclusive(1, doors);
                    var pickedDoor = RNG_Inclusive(1, doors);
                    var switchOrStay = RNG_Inclusive(0, 1); //0  is stay, 1 is switch
                    if ((switchOrStay == 0 && correctDoor == pickedDoor) || (switchOrStay == 1 && correctDoor != pickedDoor))
                        temp++;
                }
                SuccessTimes[doors] = temp;
                Console.WriteLine($"Success for {doors:N0} doors: {temp:N0} ({Math.Round(100d * temp / Tries, 2)}% success rate)");
            }
            Console.WriteLine("=========================================");
        }
        static readonly Random r = new Random();
        public static int RNG_Inclusive(int min, int max)
        {
            return r.Next(min, max + 1);
        }

    }

}
