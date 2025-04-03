using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0305
{
    public class MatrixSearcher
    {
        public void FindElement(int[,] matrix, int k)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                bool found = false;
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] == k)
                    {
                        Console.WriteLine($"Элемент {k} найден в строке {i}, столбец {j}");
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    Console.WriteLine($"Элемент {k} не найден в строке {i}");
                }
            }
        }
    }
}
