using System;

namespace APPforSearchSumMinimalandMaximumElements // Программа для поиска суммы минимального и максимального элементов
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int sizeArray;
            while (true) // Ввод размерности массива
            {
                Console.WriteLine("Введите размерность массива: ");
                while (!int.TryParse(Console.ReadLine(), out sizeArray))
                {
                    Console.WriteLine("Введено не верное значение, попробуйте повторить ввод!");
                }
                if (sizeArray <= 1 || sizeArray >= 2147483645)
                    Console.WriteLine("Введено не верное значение, попробуйте повторить ввод!");
                else break;
            }
            int[] array = new int[sizeArray]; // Создание массива с введеной размерностью
            for (int i = 0; i < sizeArray; i++) // Ввод значений элементов массива
            {
                int tNum;
                Console.WriteLine($"Введите элемент массива с индексом [{i}]");
                while (true)
                {
                    while (!int.TryParse(Console.ReadLine(), out tNum))
                    {
                        Console.WriteLine("Введено не верное значение попробуйте повторить ввод");
                    }
                    if (!(tNum <= 2147483645) && !(tNum >= -2147483645))
                        Console.WriteLine("Введено не верное значение попробуйте повторить ввод");
                    else break;
                }
                array[i] = tNum;
            }
            Console.WriteLine("Сумма минимального и максимального элементов равна: " + (MinElement(array) + MaxElement(array)));
            Console.ReadKey();
        }
        /// <summary>
        /// Класс "MinElement"
        /// Служит для поиска минимального элемента в массиве
        /// </summary>
        static int MinElement(int[] array)
        {
            int minElement = array[0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (minElement > array[i])
                    minElement = array[i];
            }
            return minElement;
        }
        /// <summary>
        /// Класс "MaxElement"
        /// Служит для поиска максимального элемента в массиве
        /// </summary>
        static int MaxElement(int[] array)
        {
            int maxElement = array[0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (maxElement < array[i])
                    maxElement = array[i];
            }
            return maxElement;
        }
    }
}