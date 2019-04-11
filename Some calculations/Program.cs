using System;

namespace Some_calculations
{
    class Program
    {
        //Основное тело программы
        static void Main()
        {
            double[] nums = new double[10];
            Console.WriteLine("Введи последовательность 10-и чисел для комлексного вычисления");
            for (int i = 0; i < 10; i++)
            {
                nums[i] = double.Parse(Console.ReadLine());
            }
            Calculator calculator = new Calculator(nums);
            calculator.Sorting();
            calculator.MultiCalc();
            Console.ReadKey();

        }
    }
}
