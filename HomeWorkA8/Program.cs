using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Библиотека для упрощения работы с консолью.
// https://github.com/MaxMaxoff/SupportLibrary
using SupportLibrary;

// Библиотека сортировок
// Часть кода с 3 урока, остальная часть дописана под текущий урок
using SortArray;

/// <summary>
/// Максим Торопов
/// Ярославль
/// https://github.com/MaxMaxoff
/// 
/// Домашняя работа "Алгоритмы и структуры данных"
/// 8 урок
/// </summary>
namespace HomeWorkA8
{
    class Program
    {
        /// <summary>
        /// 1. Реализовать сортировку подсчетом.
        /// </summary>
        static void Task1()
        {
            SupportMethods.PrepareConsoleForHomeTask("1. Реализовать сортировку подсчетом.\n");

            //int arrsize = SupportMethods.RequestIntValue("Please type size of array: ");
            //int min = SupportMethods.RequestIntValue("Please type min value of element: ");
            //int max = SupportMethods.RequestIntValue("Please type max value of element: ");

            int arrsize = 100000000; // max 500000000
            int min = 0;
            int max = 100;

            MyArray arr = new MyArray(arrsize, min, max);

            // Print out array
            // SupportMethods.Pause($"Array:\n{arr.ToString()}\nPress any key to continue...\n");

            // ********************************
            // Counting Sort
            int rounds = 0;
            int steps = 0;

            Console.WriteLine("Counting Sort");
            DateTime dtStart = DateTime.Now;
            Console.WriteLine($"Started at: {dtStart}");

            arr.CountingSort(ref rounds, ref steps);

            DateTime dtEnd = DateTime.Now;
            Console.WriteLine($"Finished at: {dtEnd}");

            // Print out result
            // SupportMethods.Pause($"Sorted array using Counting Sort:\n{arr.ToString()}\nSorted in {dtEnd - dtStart} at {rounds} rounds with {steps} steps\nPress any key to continue...\n");            
            SupportMethods.Pause($"Sorted: {arr.isSorted}, in {dtEnd - dtStart} at {rounds} rounds with {steps} steps\nPress any key to continue...\n");

        }

        /// <summary>
        /// 2. Реализовать быструю сортировку.
        /// </summary>
        static void Task2()
        {
            SupportMethods.PrepareConsoleForHomeTask("2. Реализовать быструю сортировку.\n");

            //int arrsize = SupportMethods.RequestIntValue("Please type size of array: ");
            //int min = SupportMethods.RequestIntValue("Please type min value of element: ");
            //int max = SupportMethods.RequestIntValue("Please type max value of element: ");

            int arrsize = 1000000; // max 500000000
            int min = 0;
            int max = 100;

            MyArray arr = new MyArray(arrsize, min, max);

            // Print out array
            // SupportMethods.Pause($"Array:\n{arr.ToString()}\nPress any key to continue...\n");

            // ********************************
            // Quick Sort
            int rounds = 0;
            int steps = 0;

            Console.WriteLine("Quick Sort");
            DateTime dtStart = DateTime.Now;
            Console.WriteLine($"Started at: {dtStart}");

            arr.QuickSort(ref rounds, ref steps);

            DateTime dtEnd = DateTime.Now;
            Console.WriteLine($"Finished at: {dtEnd}");

            // Print out result
            // SupportMethods.Pause($"Sorted array using Quick Sort:\n{arr.ToString()}\nSorted in {dtEnd - dtStart} at {rounds} rounds with {steps} steps\nPress any key to continue...\n");            
            SupportMethods.Pause($"Sorted: {arr.isSorted}, in {dtEnd - dtStart} at {rounds} rounds with {steps} steps\nPress any key to continue...\n");

        }

        /// <summary>
        /// 3. *Реализовать сортировку слиянием.
        /// </summary>
        static void Task3()
        {

        }

        /// <summary>
        /// 4. **Реализовать алгоритм сортировки со списком
        /// </summary>
        static void Task4()
        {

        }

        /// <summary>
        /// 5. Проанализировать время работы каждого из вида сортировок для 100, 10000, 1000000 элементов.Заполнить таблицу(см.методичку)
        /// </summary>
        static void Task5()
        {

            int arrsize = 1;
            //int arrsize10K = 10000;
            //int arrsize1KK = 1000000;
            //int arrsize100KK = 100000000; // max 500000000
            int min = 0;
            int max = 100;
            int rounds;
            int steps;

            MyArray arr; 
            MyArray arrS;
            DateTime dtStart;
            DateTime dtEnd;

            for (int i = 0; i < 5; i++)
            {
                arrsize *= 100;
                Console.WriteLine($"Elements: {arrsize}");
                arr = new MyArray(arrsize, min, max);
                arrS = new MyArray(arrsize);

                // ********************************
                // BubbleSort
                Array.Copy(arr.GetArray, arrS.GetArray, arrsize);

                rounds = 0;
                steps = 0;

                Console.WriteLine("***Bubble Sort***");
                dtStart = DateTime.Now;                
                Console.WriteLine($"Started at: {dtStart}");
                arrS.BubbleSort(ref rounds, ref steps);
                dtEnd = DateTime.Now;
                Console.WriteLine($"Finished at: {dtEnd}");                
                Console.WriteLine($"Sorted: {arrS.isSorted}, in {dtEnd - dtStart}. Rounds: {rounds} | Steps: {steps}");

                // ********************************
                // ShakerSorrt
                Array.Copy(arr.GetArray, arrS.GetArray, arrsize);

                rounds = 0;
                steps = 0;

                Console.WriteLine("***Shaker Sort***");
                dtStart = DateTime.Now;
                Console.WriteLine($"Started at: {dtStart}");
                arrS.ShakerSort(ref rounds, ref steps);
                dtEnd = DateTime.Now;
                Console.WriteLine($"Finished at: {dtEnd}");                
                Console.WriteLine($"Sorted: {arrS.isSorted}, in {dtEnd - dtStart}. Rounds: {rounds} | Steps: {steps}");

                // ********************************
                // Counting Sort
                Array.Copy(arr.GetArray, arrS.GetArray, arrsize);

                rounds = 0;
                steps = 0;

                Console.WriteLine("***Counting Sort***");
                dtStart = DateTime.Now;
                Console.WriteLine($"Started at: {dtStart}");
                arrS.CountingSort(ref rounds, ref steps);
                dtEnd = DateTime.Now;
                Console.WriteLine($"Finished at: {dtEnd}");                
                Console.WriteLine($"Sorted: {arrS.isSorted}, in {dtEnd - dtStart}. Rounds: {rounds} | Steps: {steps}");

                // ********************************
                // Quick Sort
                Array.Copy(arr.GetArray, arrS.GetArray, arrsize);

                rounds = 0;
                steps = 0;

                Console.WriteLine("***Quick Sort***");
                dtStart = DateTime.Now;
                Console.WriteLine($"Started at: {dtStart}");
                arrS.QuickSort(ref rounds, ref steps);
                dtEnd = DateTime.Now;
                Console.WriteLine($"Finished at: {dtEnd}");                
                Console.WriteLine($"Sorted: {arrS.isSorted}, in {dtEnd - dtStart}. Rounds: {rounds} | Steps: {steps}");

                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            do
            {
                SupportMethods.PrepareConsoleForHomeTask("1 - Task 1\n" +
                  "2 - Task 2\n" +
                  "3 - Task 3\n" +
                  "4 - Task 4\n" +
                  "5 - Task 5\n" +
                  "0 (Esc) - Exit\n");
                ConsoleKeyInfo key = Console.ReadKey();
                Console.WriteLine();
                switch (key.Key)
                {
                    case ConsoleKey.D1:
                        Task1();
                        break;
                    case ConsoleKey.D2:
                        Task2();
                        break;
                    case ConsoleKey.D3:
                        Task3();
                        break;
                    case ConsoleKey.D4:
                        Task4();
                        break;
                    case ConsoleKey.D5:
                        Task5();
                        break;
                    case ConsoleKey.D0:
                    case ConsoleKey.Escape:
                        return;
                    default:
                        break;
                }
            } while (true);
        }
    }
}
