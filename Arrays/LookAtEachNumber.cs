using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class LookAtEachNumber
    {
        int?[] numbers = {1, 2, 3, null, 4, 5 };
        int[] bowlingScores = { 22, 13, 28, 7, 23, 16, 20, 19, 26, 3 };
        double[] grades = { 86, 97, 82, 91, 97, 82, 96, 81, 86, 97, 75, 99 };


        public void TotalSales()
        {
            double[] sales = { 428.14, 635.15, 923.60, 400.95, 823.50, 434.65, 911.34, 759.36 };
            double total = 0.00;
            double high = 0.00;
            foreach( double sale in sales)
            {
                total += sale;
                if (sale > high)
                {
                    high = sale;
                }
            }
            Console.WriteLine($"Total sales =   {total}; Highest sale =   { high}");
        }
        public void Squares()
        {
            int[] squares = { 12, 9, 2, 3, 13, 6, 10, 12, 14 };
            var total = 0;
            foreach (int sq in squares)
            {

                total += (sq * sq);  //square each number from the "Squares" array and then add that number into "Total"
            }
            Console.WriteLine("Total =" + total);
                
        
        }
        public void RandomNumbers()
        {
            int[] rndNbrs = { 77, 85, 43, 69, 99, 50, 24, 23, 76, 62, 58, 70, 47, 87, 22, 20, 52, 6, 34, 92 };
            var total = 0;
            foreach (int rnd in rndNbrs)
            {
                if (rnd % 3 == 0)
                    total += rnd;
            }
            Console.WriteLine("Total = " +total);
        }

        public void Grades()
        {
            var total = 0;
            var counter = 0;
            foreach( int scores in grades)
            {
                total += scores;  //takes each number in grades and adds them together
                counter ++;  //counts each value to be used for average
                
                
            }
            Console.WriteLine(total / counter);
        } 


        public void BowlingGameScore()
        {
            var total = 0;
            foreach(int scores in bowlingScores)
            {
                total += scores;
            }
            Console.WriteLine($"Total bowling score = " + total);
        }

        public void CheckNumbers()
        {
            foreach(int? andInt in numbers) //"anInt" defines one of the values in the array in "numbers"
            {
                if (andInt == null)
                {
                    Console.WriteLine("NULL");
                }
                else
                {
                    var msg = (andInt % 2 == 0) ? "even" : "odd";
                    Console.WriteLine(msg);
                }
            }
        }
    }
}
