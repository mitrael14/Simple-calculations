﻿using System;
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
            Console.Write("Исходное расположение чисел: ");
            for (int i = 0; i< numbersQuantity; i++)
            {
                Console.Write(numbers[i] + ", ");
            }
            Console.WriteLine();
            Console.Write("Расположение чисел по убыванию: ");
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
            for (int i = 0; i < numbersQuantity; i++)                                    //Вывод на экран отсортированной последовательности
            {
                Console.Write(numbers[i] + ", ");
            }
            Console.WriteLine();
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