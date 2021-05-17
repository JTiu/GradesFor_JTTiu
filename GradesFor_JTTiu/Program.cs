using System;
using System.IO;

namespace Boxing_Logic
{
    class Program
    {
        static int tableWidth = 113;

        static void Main(string[] args)
        {
            Console.WriteLine("\n\nRobots v Dinosaurs: Date Submitted: Jan 29th");
            Console.WriteLine("");

            Console.WriteLine("Rock, Paper, Lizard, Scissors, Spock: Date Submitted: March 11th");
            Console.WriteLine("");
          
            Console.WriteLine("Binary Search Tree: Date Submitted: ~Feb 12th");
            Console.WriteLine("");

            Console.WriteLine("Soda Machine: Date Submitted: Feb 20th");
            Console.WriteLine("");

            Console.WriteLine("Custom List: Date Submitted: April 22d");
            Console.WriteLine("");

            Console.WriteLine("Sweepstakes: Date Submitted: April 19th");
            Console.WriteLine("");

            Console.ReadLine();

            Console.Clear();
            
            
            {
                Console.WriteLine();
                Console.WriteLine();

                string x_1 = "Date Submitted: Jan 29th";
                string x_2 = "Date Submitted: March 11th";
                string x_3 = "Date Submitted: ~Feb 12th";
                string x_4 = "Date Submitted: Feb 20th";
                string x_5 = "Date Submitted: April 22d";
                string x_6 = "Date Submitted: Feb 20th";



                PrintLine();
                PrintRow("Robots v Dinosaurs", "RPSLS", "SodaMachine", "CustomList");
                PrintLine();
                PrintRow("" + x_1, "" + x_2, "" + x_3, "" + x_4 );
            
                PrintLine();

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                PrintSecondLine();
                PrintSecondRow("Binary Search Tree", "Sweepstakes", "", "");
                PrintSecondLine();
                PrintSecondRow("" + x_5, "" + x_6, "Thanks",   "!!!!!" );
                PrintSecondLine();

               
                Console.ReadLine();
            }

            void PrintLine()
            {
                Console.WriteLine(new string('-', tableWidth));
            }

            void PrintRow(params string[] columns)
            {
                int width = (tableWidth - columns.Length) / columns.Length;
                string row = "|";

                foreach (string column in columns)
                {
                    row += AlignCentre(column, width) + "|";
                }

                Console.WriteLine(row);
            }

            string AlignCentre(string text, int width)
            {
                text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

                if (string.IsNullOrEmpty(text))
                {
                    return new string(' ', width);
                }
                else
                {
                    return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
                }
            }


            void PrintSecondLine()
            {
                Console.WriteLine(new string('-', tableWidth));
            }

            void PrintSecondRow(params string[] columns)
            {
                int width = (tableWidth - columns.Length) / columns.Length;
                string row = "|";

                foreach (string column in columns)
                {
                    row += AlignCentre(column, width) + "|";
                }

                Console.WriteLine(row);
            }

            string AlignSecondCentre(string text, int width)
            {
                text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

                if (string.IsNullOrEmpty(text))
                {
                    return new string(' ', width);
                }
                else
                {
                    return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
                }
            }



        }
    }
}
