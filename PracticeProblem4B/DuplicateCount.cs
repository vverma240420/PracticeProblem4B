using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem4B
{
    internal class DuplicateCount
    {
        public int CountDuplicate(int[] array)
        {
            Dictionary<int, int> elementCount = new Dictionary<int, int>();
            foreach (int num in array)
            {
                if (elementCount.ContainsKey(num))
                {
                    elementCount[num]++;
                }
                else
                {
                    elementCount[num] = 1;
                }
            }
            int duplicateCount = 0;


            foreach ( int count in elementCount.Values) 
            {
                if(count >1) 
                {
                    duplicateCount++;
                }
            }
            return duplicateCount;
        }        
    }
}
