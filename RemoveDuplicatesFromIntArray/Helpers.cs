using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicatesFromIntArray
{
    internal static class Helpers
    {
        public static int[] RemoveDuplicates(this int[] ints)
        {
            int arrayLength = 1;
            for (int i = 1, currentNumber = ints[0]; i < ints.Length; i++)
            {
                if (ints[i] != currentNumber)
                {
                    currentNumber = ints[i];
                    arrayLength++;
                }
            }

            int[] result = new int[arrayLength];
            result[0] = ints[0];

            for (int i = 1, j = 0; i < ints.Length; i++)
            {
                if (ints[i] > result[j])
                {
                    j++;
                    result[j] = ints[i];
                }
            }

            return result;
        }

        public static IEnumerable<int> RemoveDuplicatesEnumerable(this int[] ints)
        {
            int? number = null;
            foreach (int i in ints)
            {
                if (number.HasValue && number.Value == i)
                {
                    continue;
                }

                number = i;
                yield return i;
            }
        }
    }
}
