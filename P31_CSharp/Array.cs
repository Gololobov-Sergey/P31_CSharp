using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P31_CSharp
{
    public class Array
    {
        int[] arr;
        public Array()
        {
            arr = null;
        }

        public Array(int size)
        {
            arr = new int[size];
        }

        public Array(Array obj)
        {
            
        }

        public Array(int[] arr)
        {
                
        }

        public int Get(int index)
        {
            if(arr != null && index < arr.Length)
                return arr[index];
            throw new IndexOutOfRangeException();

        }
    }
}
