using System;
using System.Collections.Generic;
using System.Text;

namespace ResizeArrayProgram
{
        public static class ArrayUtility
        {
            public static void Resize(ref int[] array, int newSize)
            {
                int[] newarray = new int[newSize];

                for (int i = 0; i < array.Length; i++)
                {
                    newarray[i] = array[i];
                }
                array = newarray;

            }
        }
    }
}
