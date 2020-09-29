using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace race
{
    class Program
    {
        static void Main(string[] args)
        {
            string gender;
            int numOfRacers;
            double time;


            double M_World = 9.58;
            double M_europian = 9.86;
            double M_british = 9.87;

            double F_World = 10.49;
            double F_europian = 10.73;
            double F_british = 10.99;


            List<double> times = new List<double>();

            while (true)
            {
                Console.WriteLine("enter gender of the racers M/F: ");
                gender = Console.ReadLine();

                if (gender == "M")
                {
                    break;
                }
                else if (gender == "F")
                {
                    break;
                }

                else
                {
                    Console.WriteLine("you need to engter M or F");
                    Console.ReadKey();
                }
            }


            while (true)
            {
                Console.WriteLine("enter the amount of racers: ");
                numOfRacers = Convert.ToInt32(Console.ReadLine());

                if (numOfRacers < 4)
                {
                    Console.WriteLine("you can only have a number between 3 - 9");
                    Console.ReadKey();
                }
                else if (numOfRacers > 8)
                {
                    Console.WriteLine("you can only have a number between 3 - 9");
                    Console.ReadKey();
                }
                else
                {
                    break;
                }
            }





            for (int lane = 0; lane < numOfRacers; lane++)
            {
                Console.WriteLine("enter the time of racer");
                time = Convert.ToDouble(Console.ReadLine());

                times.Add(time);
            }

            times.Sort();

            for (int i = 0; i < times.Count; i++)
            {
                Console.WriteLine("{0}: {1} seconds", i + 1, times[i]);

                if (gender == "M")
                {
                    if (times[i] < M_World)
                    {
                        Console.WriteLine("World Record");
                        M_World = times[i];
                    }

                    else if (times[i] < M_british)
                    {
                        Console.WriteLine("british Record");
                        M_british = times[i];
                    }

                    else if (times[i] < M_europian)
                    {
                        Console.WriteLine("europian Record");
                        M_europian = times[i];
                    }

                    else if (gender == "F")
                    {
                        if (times[i] < F_World)
                        {
                            Console.WriteLine("World Record");
                            F_World = times[i];
                        }

                        else if (times[i] < F_british)
                        {
                            Console.WriteLine("british Record");
                            F_british = times[i];
                        }

                        else if (times[i] < F_europian)
                        {
                            Console.WriteLine("europian Record");
                            F_europian = times[i];
                        }

                    }

                }
                Console.ReadKey();


            }
        }
    }
}
