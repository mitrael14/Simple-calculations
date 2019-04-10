using System;

namespace Some_calculations
{
    class Program
    {
        static void MultiCalc(double[] numbers)
        {
            var result = (sum: 0.0, average:0.0, rootMeanSquare: 0.0, squaresSum: 0.0);
            int numbersQuantity = numbers.Length;
            for (int i = 0; i < numbersQuantity; i++)
            {
                result.sum += numbers[i];
                result.squaresSum += Math.Pow(numbers[i], 2.0);
            }
            result.rootMeanSquare = Math.Sqrt(result.squaresSum / numbersQuantity);
            result.average = result.sum / numbersQuantity;
            Console.WriteLine(
            "Сложение:                  {0}\n" +
            "Среднее арифметическое:    {1}\n" +
            "Сумма квадратов:           {2}\n" +
            "Среднее квадратическое:    {3}\n",
            result.sum, result.average, result.squaresSum, result.rootMeanSquare);
        }
        static void Main(string[] args)
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
