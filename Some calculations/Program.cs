using System;

namespace Some_calculations
{
    class Program
    {
        //Вспомогательный метод, меняющий значения переменных местами
        public static void Swap(ref double itemToSwap1, ref double itemToSwap2)
        {
            double temp;
            temp = itemToSwap2;
            itemToSwap2 = itemToSwap1;
            itemToSwap1 = temp;
        }

        public static void MultiCalc(double[] numbers)
        {
            var result = (sum: 0.0, average:0.0, rootMeanSquare: 0.0, squaresSum: 0.0); //Кортеж, в котором будут харниться данные вычислений
            int numbersQuantity = numbers.Length;                                       //Количество чисел в массиве 
            Console.Write("Исходное расположение чисел: ");                             
            for (int i = 0; i < numbersQuantity; i++)                                   //Вывод исходного массива чисел на экран,
            {                                                                           //а так же посчёт суммы и суммы квадратов
                Console.Write(numbers[i] + ", ");                                       //членов массива
                result.sum += numbers[i];                        
                result.squaresSum += Math.Pow(numbers[i], 2.0);  
            }
            Console.WriteLine();                                                        //Переход на новую строку
            Console.Write("Расположение чисел по убыванию: ");
            for (int i = 0; i < numbersQuantity-1; i++)                                 //Сортировка по убыванию до предпоследнего
            {                                                                           //члена, так как последний автоматически     
                for (int j = i + 1; j < numbersQuantity; j++)                           //будет минимальным  
                {
                    if (numbers[j] > numbers[i])
                    {
                        Swap(ref numbers[i], ref numbers[j]);
                    }
                }
            }
            for (int i = 0; i < numbersQuantity; i++)                                   //Вывод на экран отсортированной последовательности
            {
                Console.Write(numbers[i] + ", ");
            }
            Console.WriteLine();                                                        //Переход на новую строку
            result.rootMeanSquare = Math.Sqrt(result.squaresSum / numbersQuantity);     //Вычисление среднего арифметического 
            result.average = result.sum / numbersQuantity;                              //и квадратического     
            Console.WriteLine(                                                          //Вывод на экран результатов вычислений  
            "Сумма:                     {0}\n" +
            "Среднее арифметическое:    {1}\n" +
            "Сумма квадратов:           {2}\n" +
            "Среднее квадратическое:    {3}\n",
            result.sum, result.average, result.squaresSum, result.rootMeanSquare);
        }
        //Основное тело программы
        static void Main()
        {
            double[] nums = new double[10];
            Console.WriteLine("Введи последовательность 10-и чисел для комлексного вычисления");
            for (int i = 0; i < 10; i++)
            {
                nums[i] = double.Parse(Console.ReadLine());
            }
            MultiCalc(nums);
            Console.ReadKey();

        }
    }
}
