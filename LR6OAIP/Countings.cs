using System;
using System.Collections.Generic;
using System.Text;

namespace LR6OAIP
{
    class Sphere
    {
        private double R;

        public double Area()
        {
            return (4 * 3.14 * Math.Pow(R, 2));
        }

        public double Сircumference()
        {
            return ((4 / 3) * 3.14 * Math.Pow(R, 3));
        }

        public void Information()
        {
#if DEBUG
            Console.WriteLine();
#endif
            String str =
                "***************\n" +
                "*****     *****\n" +
                "***         ***\n" +
                "*     Шар     *\n" +
                "***         ***\n" +
                "*****     *****\n" +
                "***************\n";
            Console.WriteLine(str);
            Console.WriteLine("Площадь шара:");
            Console.WriteLine(string.Format("V = {0:0.000}", Area()));
            Console.WriteLine("Обьем шара:");
            Console.WriteLine(string.Format("S = {0:0.000}", Сircumference()));
        }

        public void Load()
        {
            R = Convert.ToDouble(Console.ReadLine());
        }
    }
}