using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace LR6OAIP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вариант 31

#if DEBUG
            Console.Write("Введите данные для радиуса шара. R: ");
#endif

#if !DEBUG
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_in = new StreamReader(@"sphere_input.txt");
            var new_out = new StreamWriter(@"sphere_output.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);
#endif
            Sphere s = new Sphere();
            s.Load();
            s.Information();

#if !DEBUG
            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();
#endif
            Console.ReadKey();
        }
    }
}
