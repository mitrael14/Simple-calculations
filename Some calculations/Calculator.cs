using System;
using System.Collections.Generic;
using System.Text;

namespace Some_calculations
{
    class Calculator
    {
        double[] numbers;

        public Calculator (double[] numbers)
        {
            this.numbers = numbers;
        }
        public void Sorting()
        {
            double numbersQuantity = numbers.Length;
            Console.WriteLine("Вывести заданный массив на экран? Y/N");
            string answer = Console.ReadLine();
            if ((answer == "Y") || (answer == "y"))
            {
                Console.Write("Исходное расположение чисел: ");
                for (int i = 0; i < numbersQuantity; i++)
                {
                    Console.Write(numbers[i] + ", ");
                }
                Console.WriteLine();
            }
            else if ((answer == "N") || (answer == "n"))
            {

            }
            else
            {
                Console.WriteLine(
                    "Некорректный ввод.\n" +
                    "Заданный массив будет выведен");
                Console.Write("Исходное расположение чисел: ");
                for (int i = 0; i < numbersQuantity; i++)
                {
                    Console.Write(numbers[i] + ", ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Отсортировать массив? Y/N");
            answer = Console.ReadLine();
            if ((answer == "Y") || (answer == "y"))
            {
                Console.WriteLine(
                    "Чтобы отсортировать массив по убыванию введи D\n" +
                    "Чтобы отсортировать массив по возрастанию введи U");
                answer = Console.ReadLine();
                if ((answer == "D") || (answer == "d"))
                {
                    for (int i = 0; i < numbersQuantity - 1; i++)                                //Сортировка по убыванию до предпоследнего
                    {                                                                            //члена, так как последний автоматически     
                        for (int j = i + 1; j < numbersQuantity; j++)                            //будет минимальным  
                        {
                            if (numbers[j] > numbers[i])
                            {
                                Tools.Swap(ref numbers[i], ref numbers[j]);
                            }
                        }
                    }
                    Console.Write("Расположение чисел по убыванию: ");

                    for (int i = 0; i < numbersQuantity; i++)                                    //Вывод на экран отсортированной последовательности
                    {
                        Console.Write(numbers[i] + ", ");
                    }
                    Console.WriteLine();
                }
                else if ((answer == "U") || (answer == "u"))
                {
                    for (int i = 0; i < numbersQuantity - 1; i++)                                //Сортировка по возрастанию до предпоследнего
                    {                                                                            //члена, так как последний автоматически     
                        for (int j = i + 1; j < numbersQuantity; j++)                            //будет максимальным  
                        {
                            if (numbers[j] < numbers[i])
                            {
                                Tools.Swap(ref numbers[i], ref numbers[j]);
                            }
                        }
                    }
                    Console.Write("Расположение чисел по возрастанию: ");

                    for (int i = 0; i < numbersQuantity; i++)                                    //Вывод на экран отсортированной последовательности
                    {
                        Console.Write(numbers[i] + ", ");
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Некоррентный ввод, будет выполнена сортировка массива по убыванию");
                    for (int i = 0; i < numbersQuantity - 1; i++)                                //Сортировка по убыванию до предпоследнего
                    {                                                                            //члена, так как последний автоматически     
                        for (int j = i + 1; j < numbersQuantity; j++)                            //будет минимальным  
                        {
                            if (numbers[j] > numbers[i])
                            {
                                Tools.Swap(ref numbers[i], ref numbers[j]);
                            }
                        }
                    }
                    Console.Write("Расположение чисел по убыванию: ");

                    for (int i = 0; i < numbersQuantity; i++)                                    //Вывод на экран отсортированной последовательности
                    {
                        Console.Write(numbers[i] + ", ");
                    }
                    Console.WriteLine();
                }
            }
            else if ((answer == "N") || (answer == "n"))
            {

            }
            else
            {
                Console.WriteLine(
                    "Некорректный ввод.\n" +
                    "Последовательность будет отсортирована по убыванию.");
                for (int i = 0; i < numbersQuantity - 1; i++)                                //Сортировка по убыванию до предпоследнего
                {                                                                            //члена, так как последний автоматически     
                    for (int j = i + 1; j < numbersQuantity; j++)                            //будет минимальным  
                    {
                        if (numbers[j] > numbers[i])
                        {
                            Tools.Swap(ref numbers[i], ref numbers[j]);
                        }
                    }

                }
                Console.Write("Расположение чисел по убыванию: ");

                for (int i = 0; i < numbersQuantity; i++)                                    //Вывод на экран отсортированной последовательности
                {
                    Console.Write(numbers[i] + ", ");
                }
                Console.WriteLine();
            }

        }

        public void MultiCalc()
        {
            var result = (sum: 0.0, average: 0.0, rootMeanSquare: 0.0, squaresSum: 0.0); //Кортеж, в котором будут храниться данные вычислений
            int numbersQuantity = numbers.Length;                                        //Количество чисел в массиве 
            for (int i = 0; i < numbersQuantity; i++)                                    //Вывод исходного массива чисел на экран,
            {                                                                            //Подсчёт суммы и суммы квадратов
                result.sum += numbers[i];
                result.squaresSum += Math.Pow(numbers[i], 2.0);
            }

            result.rootMeanSquare = Math.Sqrt(result.squaresSum / numbersQuantity);      //Вычисление среднего арифметического 
            result.average = result.sum / numbersQuantity;                               //и квадратического     
            Console.WriteLine(                                                           //Вывод на экран результатов вычислений  
            "Сумма:                     {0}\n" +
            "Среднее арифметическое:    {1}\n" +
            "Сумма квадратов:           {2}\n" +
            "Среднее квадратическое:    {3}\n",
            result.sum, result.average, result.squaresSum, result.rootMeanSquare);
        }

    }
}
