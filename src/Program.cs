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
                TestAlwaysStay();
                TestAlwaysSwitch();
                TestRandomStaySwitch();
                Console.WriteLine("Press S to repeat the expirement");
                if (Console.ReadKey(true).KeyChar != 's')
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
            
            Dictionary<int, Count> SuccessTimes = new Dictionary<int, Count>();
            foreach (var item in DoorsCount)
            {
                SuccessTimes[item] = new Count();
            }
             
            foreach (var entry in SuccessTimes)
            {
                var successCount = entry.Value;
                var temp = 0;
                for (int i = 0; i < Tries; i++)
                {
                    var correctDoor = RNG(1, entry.Key);
                    var pickedDoor = RNG(1, entry.Key);
                    if (correctDoor == pickedDoor)
                        temp++;
                }
                successCount.Num = temp;
                Console.WriteLine($"Success for {entry.Key} doors: {successCount.Num} ({Math.Round(100d * temp / Tries, 2)}% success rate)");
            }
            Console.WriteLine("=========================================");
        }
        public static void TestAlwaysSwitch()
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("=========== Test Awalys Switch ==========");
            Console.WriteLine("=========================================");
            //repeat 10000 times
            Dictionary<int, Count> SuccessTimes = new Dictionary<int, Count>();
            foreach (var item in DoorsCount)
            {
                SuccessTimes[item] = new Count();
            }
            foreach (var entry in SuccessTimes)
            {
             
                var successCount = entry.Value;
                var temp = 0;
                for (int i = 0; i < Tries; i++)
                {
                    var correctDoor = RNG(1, entry.Key);
                    var pickedDoor = RNG(1, entry.Key);
                    if (correctDoor != pickedDoor) //when switching, you are checking if the other door is the correct one, and the picked door is the wrong one
                        temp++;
                }
                successCount.Num = temp;
                Console.WriteLine($"Success for {entry.Key} doors: {successCount.Num} ({Math.Round(100d * temp / Tries, 2)}% success rate)");
            }
            Console.WriteLine("=========================================");
        }
        public static void TestRandomStaySwitch()
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("=============== Test Random =============");
            Console.WriteLine("=========================================");
            //repeat 10000 times
            Dictionary<int, Count> SuccessTimes = new Dictionary<int, Count>();
            foreach (var item in DoorsCount)
            {
                SuccessTimes[item] = new Count();
            }
            foreach (var entry in SuccessTimes)
            {
                var successCount = entry.Value;
                var temp = 0;
                for (int i = 0; i < Tries; i++)
                {
                    var correctDoor = RNG(1, entry.Key);
                    var pickedDoor = RNG(1, entry.Key);
                    var switchOrStay = RNG(0, 1); //0  is stay, 1 is switch
                    if ((switchOrStay == 0 && correctDoor == pickedDoor) || (switchOrStay == 1 && correctDoor != pickedDoor))
                        temp++;
                }
                successCount.Num = temp;
                Console.WriteLine($"Success for {entry.Key} doors: {successCount.Num} ({Math.Round(100d * temp / Tries, 2)}% success rate)");
            }
            Console.WriteLine("=========================================");
        }
        static readonly Random r = new Random();
        public static int RNG(int min, int max)
        {
            return r.Next(min, max);
        }
        public class Count
        {
            public int Num;
        }
    }

}
