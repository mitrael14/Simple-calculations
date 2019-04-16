using System;

namespace Some_calculations
{
    class Program
    {
        //Основное тело программы
        static void Main()
        {
            double[] nums;
            uint lenght;
            ArrayBuilder array = new ArrayBuilder();
            lenght = array.LenghtBuild();
            nums = array.ArrayBuild(lenght);
            Calculator calculator = new Calculator(nums);
            calculator.Sorting();
            calculator.MultiCalc();
            Console.ReadKey();

        }
    }
}
