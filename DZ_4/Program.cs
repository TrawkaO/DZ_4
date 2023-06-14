using System;

namespace DZ_4
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.Write("Введите длинну матрицы: ");
            var size1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите ширину матрицы: ");
            var size2 = Convert.ToInt32(Console.ReadLine());
            int[,] MyArray = new int[size1, size2];
            int[,] MyArray2 = new int[size1, size2];
            Console.WriteLine();
            for (int i = 0; i < size1; i++)
            {

                for (int j = 0; j < size2; j++)
                {
                    Console.Write("Элементы: ");
                    MyArray[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }

            for (int i = 0; i < size1; i++)
            {
                for (int j = 0; j < size2; j++)
                {
                    MyArray2[i,j] = MyArray[i,j];
                }
            }

            int CountPlus = 0, CountMinus = 0;

            for (int i = 0; i < size1; i++)
            {
                for (int j = 0; j < size2; j++)
                {
                    if (MyArray[i, j] < 0)
                    {
                        CountMinus++;
                    }
                    else
                    {
                        CountPlus++;
                    }

                }
            }

            Console.WriteLine();
            Console.WriteLine("Положительных чисел = " + CountPlus);
            Console.WriteLine("Отрицательных чисел = " + CountMinus);

            Console.WriteLine();
            Console.WriteLine("Исходный массив");
            PrintArray(MyArray);
             Console.WriteLine();

            Console.WriteLine("Сортировка по строкам: Возрастание ");
            int[] Temp = new int[size1];
            for (int i = 0; i < size2; i++)
            {
                for (int j = 0; j < size1; j++)
                    Temp[j] = MyArray[i, j];
                Sort1(Temp);
                Insert(true, i, Temp, MyArray);
            }
            PrintArray(MyArray);
            Console.WriteLine();
            Console.WriteLine("Сортировка по строкам: Убываение");
            int[] Temp2 = new int[size1];
            for (int i = 0; i < size2; i++)
            {
                for (int j = 0; j < size1; j++)
                    Temp[j] = MyArray[i, j];
                Sort2(Temp);
                Insert(true, i, Temp, MyArray);
            }

            PrintArray(MyArray);
            Console.WriteLine();
            Console.WriteLine("В обратном порядке (Исходный варик)");
            Reverse(MyArray2);


            PrintArray(MyArray2);


        }

        public static void Insert(bool isRow, int dim, int[] ystal, int[,] dest)
        {
            for (int k = 0; k < ystal.Length; k++)
            {
                if (isRow)
                    dest[dim, k] = ystal[k];
                else
                    dest[k, dim] = ystal[k];
            }
        }

        public static void PrintArray(int[,] array)
        {
            for (int a = 0; a < array.GetLength(0); a++)
            {
                for (int b = 0; b < array.GetLength(1); b++)
                {
                    Console.Write(array[a, b] + " ");
                }

                Console.WriteLine();
            }
        }

        static void Sort1(int[] inArray)
        {
            for (int i = 0; i < inArray.Length; i++)
            for (int j = 0; j < inArray.Length - i - 1; j++)
            {
                if (inArray[j] > inArray[j + 1])
                {
                    int temp = inArray[j];
                    inArray[j] = inArray[j + 1];
                    inArray[j + 1] = temp;
                }
            }
        }

        static void Sort2(int[] inArray)
        {
            for (int i = 0; i < inArray.Length; i++)
            for (int j = 0; j < inArray.Length - i - 1; j++)
            {
                if (inArray[j] < inArray[j + 1])
                {
                    int temp = inArray[j];
                    inArray[j] = inArray[j + 1];
                    inArray[j + 1] = temp;
                }
            }
        }

        static void Reverse(int[,] inArray)
        {
            for (int i = 0; i < inArray.GetLength(0); i++)
            {
                for (int j = 0; j < inArray.GetLength(1) / 2; j++)
                {
                    int temp = inArray[i, j];
                    inArray[i, j] = inArray[i, inArray.GetLength(1) - j - 1];
                    inArray[i, inArray.GetLength(1) - j - 1] = temp;
                }
            }
        }
    }
}