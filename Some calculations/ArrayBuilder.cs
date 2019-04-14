using System;
using System.Collections.Generic;
using System.Text;

namespace Some_calculations
{
    public class ArrayBuilder
    {
        public int LenghtBuild()
        {
            Random rnd = new Random();
            int arrayLenght;
            Console.WriteLine(
                "Требуется указать длину массива.\n" +
                "Введи R,чтобы сгенерировать длину случайно\n" +
                "Введи M, чтобы задать длину вручную");

            switch (Console.ReadLine())
            {
                case "R":
                    arrayLenght = rnd.Next(3, 30);
                    return arrayLenght;

                case "r":
                    goto case "R";

                case "M":
                    Console.WriteLine("Введи длину массива");
                    if (Int32.TryParse(Console.ReadLine(), out arrayLenght))
                    {
                        return arrayLenght;
                    }
                    else
                    {
                        Console.WriteLine(
                            "Некорректный ввод\n" +
                            "Длина массива будет автоматически приравнена 5");
                        return 5;
                    }
                case "m":
                    goto case "M";

                default:
                    Console.WriteLine(
                        "Некорректный ввод.\n" +
                        "Длина массива будет автоматически приравнена к 5");
                    return 5;
            }
        }

        public double[] ArrayBuild(int lenght)
        {
            Random rnd = new Random();
            double[] nums = new double[lenght];
            Console.WriteLine(
                "Требуется указать члены массива.\n" +
                "Введи R1,чтобы сгенерировать случайные целочисленные значения элементов\n" +
                "Введи R2,чтобы сгенерировать случайные вещественные значения элементов\n" +
                "Введи M, чтобы задать значения элементов вручную");

                switch (Console.ReadLine())
                {
                    case "R1":
                        for (int i = 0; i < lenght; i++)
                        {
                            nums[i] = rnd.Next(1, 9000);
                        }
                        return nums;

                    case "r1":
                        goto case "R1";

                    case "R2":
                        for (int i = 0; i < lenght; i++)
                        {
                            nums[i] = Math.Round(rnd.NextDouble() * rnd.Next(1, 9000), 2);
                        }
                        return nums;

                    case "r2":
                        goto case "R2";

                    case "M":
                        for (int i = 0; i < lenght; i++)
                        {
                        Console.WriteLine($"Введи значение {i + 1}-го элемента");
                        if (Double.TryParse(Console.ReadLine(), out nums[i]))
                            {
                            }
                            else
                            {
                            Console.WriteLine(
                                 "Некорректный ввод.\n" +
                                $"Элементу с номером {i} будет присвоено случайное вещественное число");
                            nums[i] = Math.Round(rnd.NextDouble() * rnd.Next(1, 9000), 2);
                            }

                        }
                        return nums;

                    case "m":
                        goto case "M";
                default:
                    Console.WriteLine(
                        "Некорректный ввод.\n" +
                        "Массив будет автоматически создан их случайных целых чисел");
                    goto case "R1";
                }
        }
    }
}
