using System;

// Задание №6 практики 2017г. 
// Задание 6.4, стр. 1: Ввести а1, а2, а3, М. Построить последовательность чисел ак = ак–1/2 + ак-2 /2+ ак–3 /2. Довести ее до аN <= М. Напечатать последовательность, N. Сообщить, выполняется ли равенство аN = М.
// Задания по учебной практике

namespace Practice_2017_6
{
    class Program
    {
        static bool IsElBiggerOrEqualsM(double el, double m)
        {
            if (el == m)
            {
                Console.Write(el + "\nКонец последовательности, аN=M\n");
                Console.ReadKey();
                return true;
            }
            if (el > m)
            {
                Console.WriteLine("\nКонец последовательности, аN не равно M");
                Console.ReadKey();
                return true;
            }
            Console.Write(el+" "); // Если элемент меньше М, то печатаем его и идём дальше
            return false;
        }                     // Проверка для начальных элементов

        static void NumericalSequence(double a1, double a2, double a3, double m)
        {
            double a4 = (a1 + a2 + a3)/2;
            if (a4 == m)
            {
                Console.Write(a4 + "\nКонец последовательности, аN=M");
                return;
            }
            if (a4 > m)
            {
                Console.Write("\nКонец последовательности, аN не равно M");
                return;
            }
            Console.Write(a4 + " "); // Если элемент меньше М, то печатаем его и идём дальше
            NumericalSequence(a2, a3, a4, m);
        } // Вычисление и вывод числовой последовательности

        static void Main(string[] args)
        {
            Console.Write("Введите а1: "); double a1 = Read.Double();
            Console.Write("Введите а2: "); double a2 = Read.Double();
            Console.Write("Введите а3: "); double a3 = Read.Double();
            Console.Write("Введите М: "); double m = Read.Double();
            
            if(IsElBiggerOrEqualsM(a1, m)) return; // Проверка первых элементов по очереди, сделано отдельно, т.к. вместе проходится по каждому условию и печатаются лишние строки
            if(IsElBiggerOrEqualsM(a2, m)) return;
            if(IsElBiggerOrEqualsM(a3, m)) return;

            NumericalSequence(a1, a2, a3, m);
            Console.ReadKey();
        }                                          // Чтение переменных, вызов их сравнения с M и после вызов вычисления и вывод последовательности
    }
}
