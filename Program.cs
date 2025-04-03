using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp03012.MyTask2Classes;
using ConsoleApp0305;
using ConsoleApp0305.Utils;
using ConsoleApp0312;
using ConsoleApp0312.MyTask1Classes;
using ConsoleApp0312.MyTask2Classes;

namespace ConsoleApp0312
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Практическая работа номер 12");
            Console.WriteLine("1 - 30");
            int input = Convert.ToInt32(Console.ReadLine());


            switch (input)
            {
                case 1:

                    var points = new List<Point>
                    {
                        new Point(0, 0),
                        new Point(1, 1),
                        new Point(2, 2),
                        new Point(1, 0),
                        new Point(0, 1),
                        new Point(1, 2),
                        new Point(2, 1)

                    };

                    var result = Calculation1.FindBestCircle(points);
                    Console.WriteLine($"Центр окружности: ({result.Center.X}, {result.Center.Y}), Радиус: {result.Radius}, Количест точек: {result.PointCount}");

                    break;

                case 2:

                    {
                        
                        Students[] students = {
                            new Students("Терехов", 12.5),
                            new Students("Орехов", 11.8),
                            new Students("Потапов", 15.2),
                            new Students("Касиков", 9.5),
                            new Students("Гараев", 12.0),
                            new Students("Болтов", 9.7)
                        };

                        var relayTeam = Calculation2.GetBestRunners(students);

                        relayTeam.PrintTeam();
                    }


                    break;

                case 3:

                    var processor = new Calculation3();
                    var array = processor.GenerateArray(5);

                    Console.WriteLine("Исходный массив:");
                    processor.PrintArray(array);

                    var modifiedArray = processor.ModifyArray(array);

                    Console.WriteLine("Измененный массив:");
                    processor.PrintArray(modifiedArray);

                    break;

                case 4:

                    {
                        int[,] matrix = {
                            { 1, 2, 3 },
                            { 4, 5, 6 },
                            { 7, 8, 9 }
                        };

                        var processo = new Calculation4();
                        var belowDiagonal = processo.GetElementsBelowDiagonal(matrix);

                        Console.WriteLine("Одномерный массив до сортировки:");
                        processo.PrintArray(belowDiagonal);

                        Array.Sort(belowDiagonal);

                        Console.WriteLine("Одномерный массив после сортировки:");
                        processo.PrintArray(belowDiagonal);
                    }

                    break;

                case 5:

                    {
                        int[,] matrix = {
                            { 5, 3, 8 },
                            { 1, 7, 2 },
                            { 4, 6, 9 }
                        };

                        var sorter = new MatrixSorter();

                        Console.WriteLine("Исходная матрица:");
                        sorter.PrintMatrix(matrix);

                        sorter.BubbleSort(matrix);

                        Console.WriteLine("Матрица после сортировки пузырьком:");
                        sorter.PrintMatrix(matrix);
                    }

                    break;

                case 6:

                    {
                        int[,] matrix = {
                               { 1, 2, 3 },
                               { 2, 3, 1 },
                               { 4, 5, 6 },
                               { 3, 2, 1 }
                        };

                        var analyzer = new MatrixAnalyzerryr();
                        int count = analyzer.CountSimilarRows(matrix);

                        Console.WriteLine($"Количество строк, похожих на первую строку: {count}");
                    }

                    break;

                case 7:
                    {
                        int[,] matrix = {
                            { 1, 2, 3 },
                            { 4, 5, 6 },
                            { 7, 8, 9 }
                        };

                        int k = 5;
                        var searcher = new MatrixSearcher();
                        searcher.FindElement(matrix, k);
                    }
                    break;

                case 8:

                    {
                        int[,] matrix = {
                            { 1, 2, 3 },
                            { 4, 5, 6 },
                            { 7, 8, 9 }
                        };

                        var processorr = new MatrixProcessorr();
                        int minSumRow = processorr.FindMinSumRow(matrix);
                        int minSum = processorr.GetRowSum(matrix, minSumRow);

                        Console.WriteLine($"Строка с минимальной суммой: {minSumRow}, сумма: {minSum}");

                        processorr.MultiplyMatrixByValue(matrix, minSum);

                        Console.WriteLine("Матрица после умножения:");
                        processorr.PrintMatrix(matrix);
                    }

                    break;

                case 9:

                    {
                        int[,] matrix = {
                            { 1, 2, 3 },
                            { 4, 5, 6 },
                            { 7, 8, 9 }
                        };

                        var sorter = new MatrixSorterr();
                        sorter.SortRowsByLastElement(matrix);

                        Console.WriteLine("Матрица после перестановки строк:");
                        sorter.PrintMatrix(matrix);
                    }

                    break;

                case 10:

                    {
                        int[,] matrix = {
                            { 5, 4, 3 },
                            { 4, 3, 2 },
                            { 3, 2, 1 },
                            { 2, 1, 0 },
                            { 1, 0, -1 }
                        };

                        var analyzer = new MatrixAnalyzer();
                        int count = analyzer.CountMonotonicColumns(matrix);

                        Console.WriteLine($"Количество монотонно убывающих столбцов: {count}");
                    }


                    break;


                case 11:

                    {
                        int[,] matrix = {
                            { 5, 3, 8 },
                            { 1, 7, 2 },
                            { 4, 6, 9 }
                        };

                        var analyzer = new MatrixAnalyzers();
                        var (row, col) = analyzer.FindElement(matrix);

                        Console.WriteLine($"Элемент с наибольшим значением среди минимальных в строках: [{row}, {col}] = {matrix[row, col]}");
                    }
                    break;

                case 12:

                    {
                        int[,] matrix = {
                            { 1, 4, 7 },
                            { 2, 5, 8 },
                            { 3, 6, 9 }
                        };

                        var analyzer = new MatrixAnalyzerу();
                        int maxElement = analyzer.FindMaxInOrderedColumns(matrix);

                        Console.WriteLine($"Максимальный элемент в упорядоченных столбцах: {maxElement}");
                    }

                    break;

                case 13:

                    {
                        int[,] matrix = {
                            { 1, 2, 3 },
                            { 4, 5, 6 },
                            { 7, 8, 9 }
                        };

                        var processore = new MatrixProcessored();
                        processore.ReflectOverSecondaryDiagonal(matrix);

                        Console.WriteLine("Матрица после отражения:");
                        processore.PrintMatrix(matrix);
                    }

                    break;

                case 14:

                    {
                        int[,] matrix = {
                            { 3, 1, 4 },
                            { 2, 5, 9 },
                            { 6, 7, 8 }
                        };

                        var processo = new MatrixProcesso();
                        processo.MoveMinElementsToFirstColumn(matrix);

                        Console.WriteLine("Матрица после перемещения минимальных элементов в первый столбец:");
                        processo.PrintMatrix(matrix);
                    }

                    break;

                case 15:

                    {
                        int n = 4;
                        var filler = new ArrayFiller();
                        var array1 = filler.FillArray(n);

                        Console.WriteLine("Массив, заполненный по диагонали:");
                        filler.PrintArray(array1);
                    }

                    break;

                case 16:

                    {
                        int[,] matrix = {
                            { 0, 1, 2 },
                            { 1, 2, 3 },
                            { 2, 3, 4 }
                        };

                        var checker = new MatrixChecker();
                        bool isSymmetric = checker.IsSymmetric(matrix);

                        Console.WriteLine($"Матрица симметрична относительно главной диагонали: {isSymmetric}");
                    }

                    break;

                case 17:

                    {
                        int n = 4, m = 6;
                        var filler = new ArrayFillerr();
                        var array2 = filler.FillArray(n, m);

                        Console.WriteLine("Массив, заполненный по правилу суммы:");
                        filler.PrintArray(array2);
                    }

                    break;

                case 18:

                    {
                        int n = 4, m = 6;
                        var filler = new ArrayFillere();
                        var array3 = filler.FillArraySnake(n, m);

                        Console.WriteLine("Массив, заполненный змейкой:");
                        filler.PrintArray(array3);
                    }

                    break;

                case 19:
                    {
                        int n = 4, m = 6;
                        var filler = new ArrayFilleryd();
                        var array4 = filler.FillArrayDiagonal(n, m);

                        Console.WriteLine("Массив, заполненный по диагоналям:");
                        filler.PrintArraye(array4);
                    }
                    break;

                case 20:
                    {
                        int n = 2;
                        var filler = new ArrayFille();
                        var array5 = filler.FillArraySpiral(n);

                        Console.WriteLine("Массив, заполненный по спирали:");
                        filler.PrintArray(array5);
                    }
                    break;

                case 21:

                    {
                        int[,] matrix = {
                            { 5, 3, 8 },
                            { 1, 7, 2 },
                            { 4, 6, 9 }
                        };

                        var sorter = new MatrixSortere();
                        sorter.SortBySecondaryDiagonal(matrix);

                        Console.WriteLine("Матрица после сортировки по побочной диагонали:");
                        sorter.PrintMatrix(matrix);
                    }
                    break;

                case 22:
                    {
                        int n = 4;
                        var filler = new ArrayFill();
                        var array6 = filler.FillArray(n);

                        Console.WriteLine("Массив, заполненный по главной диагонали:");
                        filler.PrintArray(array6);
                    }
                    break;

                case 23:
                    {
                        var filler = new ArrayFilled();
                        var array7 = filler.CreateCrossArray();

                        Console.WriteLine("Массив с крестом:");
                        filler.PrintArray(array7);
                    }
                    break;

                case 24:
                    {
                        var filler = new ArrayFillee();
                        var array8 = filler.CreatePatternArray();

                        Console.WriteLine("Массив с узором:");
                        filler.PrintArray(array8);
                    }
                    break;

                case 25:
                    {
                        var filler = new ArrayFillerd();
                        var array9 = filler.CreateFrameArray();

                        Console.WriteLine("Массив с рамкой:");
                        filler.PrintArray(array9);
                    }

                    break;

                case 26:
                    {
                        int[,] matrix = {
                            { 0, 1, 0 },
                            { 1, 0, 1 },
                            { 0, 1, 0 }
                        };

                        var processorr = new MatrixProcessor();
                        processorr.RearrangeColumns(matrix);

                        Console.WriteLine("Матрица после перестановки столбцов:");
                        processorr.PrintMatrixx(matrix);
                    }
                    break;

                case 27:
                    {
                        int[,] matrix = {
                            { 1, 2, 3 },
                            { 2, 3, 1 },
                            { 4, 5, 6 },
                            { 3, 2, 1 }
                        };

                        var analyzer = new MatrixAnalyze();
                        int count = analyzer.CountSimilarRows(matrix);

                        Console.WriteLine($"Количество строк, похожих на первую: {count}");
                    }
                    break;

                case 28:
                    {
                        int[,] matrix = {
                            { 1, 2, 3 },
                            { 2, 3, 1 },
                            { 4, 5, 6 },
                            { 3, 2, 1 }
                        };

                        var analyzer = new MatrixAnalyzerry();
                        int count = analyzer.CountSimilarColumns(matrix);

                        Console.WriteLine($"Количество столбцов, похожих на последний: {count}");
                    }
                    break;

                case 29:
                    {
                        int[,] matrix = {
                            { 1, 2, 3 },
                            { 2, 3, 1 },
                            { 4, 5, 6 },
                            { 3, 2, 1 }
                        };

                        var analyzer = new MatrixAnalyzerryy();
                        int count = analyzer.CountSimilarColumns(matrix);

                        Console.WriteLine($"Количество столбцов, похожих на последний: {count}");
                    }
                    break;

                case 30:
                    {
                        var filler = new ArrayFil();
                        var arra = filler.CreatePatternArray();

                        Console.WriteLine("Массив с узором:");
                        filler.PrintArray(arra);
                    }
                    break;





            }
        }
    }
}