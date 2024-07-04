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

        public int this[int index]
        {
            get
            {
                if (arr != null && index < arr.Length)
                    return arr[index];
                throw new IndexOutOfRangeException();
            }
            set
            {
                if (arr != null && index < arr.Length)
                    arr[index] = value;
                else
                    throw new IndexOutOfRangeException();
            }
        }

        public int Get(int index)
        {
            if(arr != null && index < arr.Length)
                return arr[index];
            throw new IndexOutOfRangeException();

        }
    }


    public class Matrix
    {
        int[,] arr;

        public int Row { get;}
        public int Column { get; }


        public Matrix(int row, int column)
        {
            Row = row;
            Column = column;
            arr = new int[row, column];
        }

        public void Set()
        {
            Random random = new Random();
            for (int i = 0; i < Row; i++)
                for (int j = 0; j < Column; j++)
                    arr[i, j] = random.Next(0, 100);
        }

        public void Print()
        {
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Column; j++)
                    Console.Write($"{arr[i, j]} ");
                Console.WriteLine();
            }
        }

        public int this[int row, int column]
        {
            get
            {
                if (row < Row && column < Column)
                    return arr[row, column];
                throw new IndexOutOfRangeException();
            }
            set
            {
                if (row < Row && column < Column)
                    arr[row, column] = value;
                else
                    throw new IndexOutOfRangeException();
            }
        }
    }
}
