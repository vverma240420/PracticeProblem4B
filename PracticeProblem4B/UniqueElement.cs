using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem4B
{
    internal class UniqueElement
    {
        public void PrintUniqueElements(int[] array)
        {
            Dictionary<int, int> elementCount = new Dictionary<int, int>();
            foreach (int num in array) 
            {
                if(elementCount.ContainsKey(num))
                {
                    elementCount[num]++;
                }
                else
                {
                    elementCount[num] = 1;

                }
            }

            Console.WriteLine("Unique elements in the array: ");
            foreach(int num in array)
            {
                if (elementCount[num] ==1) 
                {
                    Console.WriteLine(num);
                }
             
            }

        }
    }
}
