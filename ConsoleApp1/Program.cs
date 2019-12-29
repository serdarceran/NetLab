using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1
{
    static class HedeExtension
    {
        public static void Await(this List<Task> tasks)
        {
            Task.WaitAll(tasks.ToArray());
        }
    }

    class Name
    {
        private String firstName;

        public String FamilyName { get; set; }
        public Name(String firstName, String lastName)
        {
            this.firstName = firstName;
            FamilyName = lastName;
        }


        public override String ToString()
        {
            return this.firstName + " " + this.FamilyName;
        }

    }
    enum Direction { A, B }
    class Program
    {
        static async Task Main(string[] args)
        {
            //int a = 5;
            //int b = 7;
            //Console.WriteLine("a:" + a + ", b:" + b);
            //Swap(ref a, ref b);
            //Console.WriteLine("a:" + a + ", b:" + b);

            //List<int> numbers = new List<int>();++
            //numbers.Add(1);
            //numbers.Add(2);
            //numbers.Add(3);

            //Console.WriteLine("Average: " + numbers.Sum() / numbers.Count());

            //List<int> bignumer = numbers.Where(x => x > 2).Select(x => x).ToList();
            //Console.WriteLine("Big number" + bignumer.Sum());
            //foreach (int a in bignumer)
            //{
            //    Console.WriteLine($"{a} is a big number");
            //}

            //int addedNumber = addNumber(5,6);
            //Console.WriteLine(">> " + addedNumber);

            //int a = 4;
            //changeNumber(ref a, 6);
            //Console.WriteLine($"The new value is: {a}");

            //Boolean cont = true;
            //String ask = "";
            //String output = "";
            //int counter = 0;
            //while (cont)
            //{
            //    if (counter == 0)
            //    {
            //        ask = "Enter a name:";
            //        output = "Hello {0}!";
            //    }
            //    else if (counter == 1)
            //    {
            //        ask = "Enter another name:";
            //        output = "Hello {0}!";
            //    }
            //    else if (counter == 2)
            //    {
            //        ask = "Enter a third name:";
            //        output = "Hello {0}! How are you?";
            //        cont = false;
            //    }
            //    Console.Write(ask);
            //    String name = Console.ReadLine();
            //    Console.WriteLine(String.Format(output, name));
            //    counter++;
            //    counter %= 3;

            //}

            //while(true)
            //{
            //    Console.Write("Enter a number");
            //    String number = Console.ReadLine();
            //    int numb = Int32.Parse(number);
            //    String not = isPrimeNumber(numb) ? "" : "not";
            //    printPrime(number, not);
            //}
            //List<String> groceries = new List<String>();
            //int count = 0;
            //while (++count < 6)
            //{
            //    Console.Write($"Enter grocery item {count}: ");
            //    String grocery = Console.ReadLine();
            //    groceries.Add(grocery);
            //}
            //String[] groceryStrings = new String[3]
            //{
            //    "is no grocery","is one grocery","are groceries"
            //};
            //Func<int, String>[] groceryNumb = new Func<int, String>[3]
            //{
            //    (int a) =>
            //    {
            //        return "";
            //    },(int a) =>
            //    {
            //        return "";
            //    },(int a) =>
            //    {
            //        return a.ToString() ;
            //    }
            //};
            //Console.Write("Enter a substring to search for: ");
            //String substring = Console.ReadLine();
            //int counts = groceries.Where(g => g.Contains(substring)).Count();
            //int cc = counts % 3;
            //Console.WriteLine(
            //    String.Format("There {0} {1} which contains {2}", 
            //    groceryNumb[cc](counts), 
            //    groceryStrings[cc], 
            //    substring));


            //var directions = new Dictionary<char, char>
            //{
            //    { 'n', '^' },
            //    { 's', 'v' },
            //    { 'e', '>' },
            //    { 'w', '<' }
            //};

            //List<char> outDirs = new List<char>();
            //char command = '?';
            //while (command != '0')
            //{
            //    Console.Write("Enter directions (n,s,e,w) or 0 to finish: ");
            //    command = Console.ReadKey().KeyChar;
            //    Console.WriteLine();
            //    char output;
            //    Boolean found = directions.TryGetValue(command, out output);
            //    if(found)
            //    {
            //        outDirs.Add(output);
            //    }
            //    else 
            //    {
            //        Console.WriteLine("Invalid input!");
            //    }
            //}
            //Console.WriteLine($"You entered {outDirs.Count} valid directions. The directions are follows;");

            //foreach(char d in outDirs)
            //{
            //    Console.Write($"{d} ");
            //}

            var commands = new Dictionary<String, Action<ICar>>()
            {
                {"speedUp", (car)=> { car.speedUp(); } },
                {"slowDown", (car)=> { car.slowDown(); } },
                {"corn", (car)=> { car.corn(); } },
                {"turnLightOn", (car)=> { car.turnLightOn(); } },
                {"turnLightOff", (car)=> { car.turnLightOff(); } },
                {"turnLeft", (car)=> { car.turnLeft(); } },
                {"turnRight", (car)=> { car.turnRight(); } },
                {"stop", (car)=> { car.stop(); } },
            };

            //ClassicCar car = new ClassicCar();
            //car.subscribe((ICar theCar) =>
            //{
            //    carMonitor((ClassicCar)theCar);
            //});

            //while (true)
            //{
            //    Console.WriteLine("Enter the commands: " + string.Join(", ", commands.Keys));
            //    String command = Console.ReadLine();
            //    if(commands.ContainsKey(command))
            //    {
            //        commands.GetValueOrDefault(command)(car);
            //    } 
            //    //carMonitor(car);
            //}

            int testing = 0;

            WriteLine($"Using static imports {Testing}");
            WriteLine($"Using static imports {Testing1("aa")}");
            WriteLine($"Singers {sigc}");

            WriteLine($"The time is now {DateTime.Now:T}");
            WriteLine($" The name of {nameof(testing)}");

            var tt = new Dictionary<string, string>()
            {
                ["hede"] = "this is hede",
                ["hodo"] = "this is hodo"
            };

            string[] aa = new[] { "aa", "aaa" };
            var kk = new List<string>(new[] { "", "" })
            {
                [0] = "firsst",
                [1] = "second"
            };

            WriteLine(kk[0]);
            WriteLine($"{tt["hede"]}");
            List<Task> tasks = new List<Task>();
            DateTime startTime = DateTime.Now;
            try
            {
                int b = 0;
                int a = 1 / b;
            }
            catch (Exception ex)
            {
                WriteLine("step1");
                tasks.Add(doLogging("file1.log", "An error:", ex));
                WriteLine("step2");

            }
            finally
            {
                WriteLine("step3");
                tasks.Add(doLogging("file2.log", "Completed."));
                WriteLine("step4");
            }
            //Task.WaitAll(tasks.ToArray());
            tasks.Await();
            DateTime endTime = DateTime.Now;
            WriteLine($"The time elapsed is {endTime.Subtract(startTime)}");
        }

        

        private static async Task doLogging(String file, String details, Exception ex = null)
        {
            await Task.Delay(3000);
            using var thisFile = File.AppendText(file);
            await thisFile.WriteLineAsync($"{details} {ex}");
        }

        public static string Testing => "testing the 1";

        public static string Testing1(string a) => $"testing 2 {a}";

        public static string AAA { get; set; } = "default value";

        interface AA
        {
            string Aa { get; }
            string Bb { get; }
        }
        static List<string> singers = null;





        int? singerCount = singers?.Count;

        static int sigc = singers?.Count ?? 0;



        static void carMonitor(ClassicCar car)
        {
            Console.WriteLine($"CarDirection: {car.CarDirection}");
            Console.WriteLine($"Speed       : {car.Speed}");
            Console.WriteLine($"LightOn     : {car.LightOn}");
            Console.WriteLine($"Sound       : {car.Sound}");
            Console.WriteLine($"Abc         : {car.Abc}");

            var home = new Home
            {
                //ID = "1",
                //Name = "MyHome"
            };
        }
        static void printPrime(String number, String not = "not")
        {
            Console.WriteLine($"{number} is {not} a prime number.");
        }

        static Boolean isPrimeNumber(int number)
        {
            if (number == 0) return false;
            for (int i = 2; i < number; i++)
            {
                //Console.WriteLine($"{number % i}");
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        struct Home
        {
            public string ID { get; set; }
            public string Name { get; set; }
        }

        static void changeNumber(ref int number, int value)
        {
            number = value;
        }
        static int addNumber(int numb, int add = 1)
        {
            return numb + add;
        }

        static void Swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }
    }
}

