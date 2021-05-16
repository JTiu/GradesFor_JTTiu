using System;
using System.IO;

namespace Boxing_Logic
{
    class Program
    {
        static int tableWidth = 113;

        static void Main(string[] args)
        {
            Console.WriteLine("Robots v Dinosaurs: Date Submitted: Jan 29th");
            Console.WriteLine("");
            //Round 1
            Console.WriteLine("Binary Search Tree: Date Submitted: ~Feb 12th");
            Console.WriteLine("");

            Console.WriteLine("Round#1: Boxer2 score: 10 or 9?");
            Console.WriteLine("");

            int scoreBoxer2_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Boxer1 score: " +  "; Boxer2 score: " + scoreBoxer2_1 + "\n");
            Console.WriteLine("");

            {
               
            }
            Console.Clear();
            //Round 2
            Console.WriteLine("Round #2: Boxer1 score: 10 or 9?");
            Console.WriteLine("");

            int scoreBoxer1_2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Round#2: Boxer2 score: 10 or 9?");
            Console.WriteLine("");

            int scoreBoxer2_2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Boxer1 score: " + scoreBoxer1_2 + "; Boxer2 score " + scoreBoxer2_1);
            Console.WriteLine("");

            {
                bool Boxer1Wins = true;
                if (scoreBoxer1_2 > scoreBoxer2_2)
                {
                    Console.WriteLine("Boxer1 won Round#2!");
                }
                else
                {
                    Console.WriteLine("Player2 won Round#2");
                }
            }
            Console.Clear();
            //Round 3
            Console.WriteLine("Round #3: Boxer1 score: 10 or 9?");
            Console.WriteLine("");

            int scoreBoxer1_3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Round#2: Boxer2 score: 10 or 9?");
            Console.WriteLine("");

            int scoreBoxer2_3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Boxer1 score: " + scoreBoxer1_3 + "; Boxer2 score " + scoreBoxer2_3);
            Console.WriteLine("");

            {
                bool Boxer1Wins = true;
                if (scoreBoxer1_3 > scoreBoxer2_3)
                {
                    Console.WriteLine("Boxer1 won Round#3!");
                }
                else
                {
                    Console.WriteLine("Player2 won Round#3");
                }

            }
            Console.Clear();
            
            
            {

                string x_1 ="Date Submitted: Jan 29th";
                string x_2 = "Date Submitted: ~Feb 12th";
                int x_3 = scoreBoxer1_3;
                int x_4 = scoreBoxer2_1;
                int x_5 = scoreBoxer2_2;
                int x_6 = scoreBoxer2_3;
               
                int x_8 = scoreBoxer2_1 + scoreBoxer2_2 + scoreBoxer2_3;


                PrintLine();
                PrintRow("Robots v Dinosaurs", "RPSLS", "SodaMachine", "CustomList");
                PrintLine();
                PrintRow("" + x_1, "" + x_2, "" + x_3, "" );
                PrintRow("" + x_4, "" + x_5, "" + x_6, "" + x_8);
                PrintLine();
              
                PrintSecondLine();
                PrintSecondRow("Binary Search Tree", "Sweepstakes", "Round 3", "Total");
                PrintSecondLine();
                PrintSecondRow("" + x_1, "" + x_2, "" + x_3, "" );
                PrintSecondRow("" + x_4, "" + x_5, "" + x_6, "" + x_8);
                PrintSecondLine();

                //Generate();
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
