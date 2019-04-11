using System;
using System.Collections.Generic;
using System.Text;

namespace Some_calculations
{
    class Tools
    {
        // Вспомогательный метод, меняющий значения переменных местами
        public static void Swap(ref double itemToSwap1, ref double itemToSwap2)
        {
            double temp;
            temp = itemToSwap2;
            itemToSwap2 = itemToSwap1;
            itemToSwap1 = temp;
        }

    }
}
