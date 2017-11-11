﻿using System;
using System.Threading;

namespace calc
{
    class Program
    {

        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.Write("do you want to do a calculation ? [y/N]: ");
                if (Console.ReadLine().ToLower().Equals("y"))
                {
                    Console.Write("enter mode\n1 = OpenCircuitVoltage\n");
                    string mode = Console.ReadLine();
                    switch (mode)
                    {
                        case "1":
                            
                            double? highTemp = GetNumber("enter T high: ");
                            if(highTemp == null) break;
                            double? lowTemp = GetNumber("enter T low: ");
                            if(lowTemp == null) break;

                            Tcalc tc = new Tcalc();

                            Console.WriteLine(tc.OpenCircuitVoltage((double)highTemp, (double)lowTemp));
                            break;
                        default:
                            break;





                    }
                   
                    /*Calc c = new Calc();
                    Console.Write($"Multiplying {Number1} and {Number1}\n");
                    double mult = c.MultiplyNumbers(Number1, Number1);
                    Console.WriteLine(mult);*/
                    Thread.Sleep(8000);



                }
                else break;
                end: Console.Clear();
            }


            /* while (true)
             {
                 Console.Write("do you want to da a calculation ? [y/N]: ");
                 if (Console.ReadLine().ToLower().Equals("y"))
                 {
                     Console.WriteLine("start");
                     Console.Write("enter the first number: ");
                     string input = Console.ReadLine();
                     Console.Write("enter the second number: ");
                     if (!double.TryParse(input, out double Number1))
                     {
                         Console.WriteLine("\n invalid input1 needs number");
                         System.Threading.Thread.Sleep(800);
                         goto end;
                     }
                     input = Console.ReadLine();
                     if (!double.TryParse(input, out double Number2))
                     {
                         Console.WriteLine("\n invalid input2 needs number");
                         System.Threading.Thread.Sleep(800);
                         goto end;
                     }
                     //double mal = Number1 * Number2;
                     double dev = Number1 / Number2;
                     double paw = Math.Pow(Number1, Number2);
                     double sub = Number1 - Number2;
                     double add = Number1 + Number2;
                     double rem = Number1 % Number2;
                     Console.WriteLine(Number1);
                     Console.WriteLine(Number2);
                     //Console.WriteLine($"{Number1} * {Number2} = {Number1 * Number2}");
                     Console.WriteLine(MultiplyNumbers(Number1, Number2));
                     Console.WriteLine($"{Number1} / {Number2} = {Number1 / Number2}");
                     Console.WriteLine($"{Number1} + {Number2} = {add}");
                     Console.WriteLine($"{Number1} - {Number2} = {sub}");
                     Console.WriteLine($"{Number1} ^ {Number2} = {Math.Pow(Number1, Number2)}");
                     Console.WriteLine($"{Number2} % {Number2} = {Number1 % Number2}");
                     Console.Write("press enter to continue...");
                     Console.ReadLine();

                 }
                 else break;
                 end: Console.Clear();       }*/
        }

        private static double? GetNumber(string prompt){
            Console.Write(prompt);
            string input = Console.ReadLine();
            if (double.TryParse(input, out double number))
            {
                
                return number;
            }else{
                Console.WriteLine("\n input invalid ");
                Thread.Sleep(800);
                return null;
            }


            
        }


    }
}
