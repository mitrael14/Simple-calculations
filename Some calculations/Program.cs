using System;

namespace Some_calculations
{
    class Program
    {
        static (double sum, double sub, double div, double mul) MultiCalc(double[] numbers)
        {
            var result = (sum: 0.0, sub: 0.0, div: 1.0, mul: 1.0);
            for (int i = 0; i < numbers.Length; i++)
            {
                result.sum += numbers[i];
                result.sub -= numbers[i];
                result.div /= numbers[i];
                result.mul *= numbers[i];
            }
            Console.WriteLine("Сложение: {0}", result.sum);
            Console.WriteLine("Вычитание: {0}", result.sub);
            Console.WriteLine("Деление: {0}", result.div);
            Console.WriteLine("Произвдение: {0}", result.mul);
            return result;
        }
        static void Main(string[] args)
        {
            double[] nums = new double[10];
            Console.WriteLine("Введи последовательность 10-и чисел для комлексного вычисления");//чтотоннапишу
            for (int i = 0; i < 10; i++)
            {
                nums[i] = double.Parse(Console.ReadLine());
            }
            MultiCalc(nums);
            Console.ReadKey();

        }
    }
}
