using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0312
{
    public class Calculation3
    {
        public int[,] GenerateArray(int size)
        {
            var random = new Random();
            var array = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    array[i, j] = random.Next(1, 100);
                }
            }

            return array;
        }

        public int[,] ModifyArray(int[,] array)
        {
            int size = array.GetLength(0);
            var modifiedArray = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    modifiedArray[i, j] = -3 * array[i, j];
                }
            }

            return modifiedArray;
        }

        public void PrintArray(int[,] array)
        {
            int size = array.GetLength(0);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write($"{array[i, j],5}");
                }
                Console.WriteLine();
            }
        }
    }

}
