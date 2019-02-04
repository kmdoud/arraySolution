using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class ArrayOfIntegers 
    {
        private int[] integers = new int[10];
        private int Sum() 
        {
            var total = 0;
            for(var idx = 0; idx < 10; idx++)
            {
                total += integers[idx];

            }
            return total;
        }
        public void Add(int index, int value)
        {
            integers[index] = value;
        }
        public int Get(int index)
        {
            return integers[index];
        }
       
        public void Print() 
      
        {
            var total = 0;
            var comma = "";
           foreach(var i in integers)
            {
                total += i;
                Console.Write($"{comma}{i}");
                comma = ", ";
             
            }
            Console.WriteLine(" = " + total);
        }
        
        
        
    }
}
