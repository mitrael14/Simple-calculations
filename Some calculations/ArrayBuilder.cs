using System;
using System.Collections.Generic;
using System.Text;

namespace Some_calculations
{
    public class ArrayBuilder
    {
        public uint LenghtBuild()
        {
            Random rnd = new Random();
            uint arrayLenght;
            string letter;
            Console.WriteLine(
                "Требуется указать длину массива.\n" +
                "Введи R,чтобы сгенерировать длину случайно\n" +
                "Введи M, чтобы задать длину вручную");
            letter = Console.ReadLine();
            while (
                !(letter == "R") && !(letter == "r") && 
                !(letter == "M") && !(letter == "m"))
            {
                Console.WriteLine(
                    "Некорректный ввод\n" +
                    "Введи R,чтобы сгенерировать длину случайно\n" +
                    "Введи M, чтобы задать длину вручную");
                letter = Console.ReadLine();
            }
            switch (letter)
            {
                case "R":
                    arrayLenght = (uint)rnd.Next(3, 30);
                    return arrayLenght;

                case "r":
                    goto case "R";

                case "M":
                    Console.WriteLine("Введи длину массива");
                    while (!UInt32.TryParse(Console.ReadLine(), out arrayLenght))
                    {
                        Console.WriteLine(
                            "Некорректный ввод\n" +
                            "Введи длину массива(целое, неотрицательное число)");
                    }
                    return arrayLenght;
                case "m":
                    goto case "M";

                default:
                    Console.WriteLine(
                        "Некорректный ввод.\n" +
                        "Длина массива будет автоматически приравнена к 5");
                    return 5;
            }
        }

        public double[] ArrayBuild(uint lenght)
        {
            Random rnd = new Random();
            string letter;
            double[] nums = new double[lenght];
            Console.WriteLine(
                "Требуется указать значения для элементов массива.\n" +
                "Введи R1,чтобы сгенерировать случайные целочисленные значения элементов\n" +
                "Введи R2,чтобы сгенерировать случайные вещественные значения элементов\n" +
                "Введи M, чтобы задать значения элементов вручную");
            letter = Console.ReadLine();
            while (
                !(letter == "R1") && !(letter == "r1") &&
                !(letter == "R2") && !(letter == "r2") && 
                !(letter == "M") && !(letter == "m"))
            {
                Console.WriteLine(
                    "Некорректный ввод\n" +
                    "Введи R1,чтобы сгенерировать случайные целочисленные значения элементов\n" +
                    "Введи R2,чтобы сгенерировать случайные вещественные значения элементов\n" +
                    "Введи M, чтобы задать значения элементов вручную");
                letter = Console.ReadLine();
            }
            switch (letter)
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
                        while (!Double.TryParse(Console.ReadLine(), out nums[i]))
                        {
                            Console.WriteLine(
                                 "Некорректный ввод.\n" +
                                 "Введи число заново");
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
