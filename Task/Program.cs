using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите начальное число и шаг для ариф прогресии и геом прогресии");
            Console.Write("начальное значение = ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.Write("шаг/множитель = ");
            int step = Convert.ToInt32(Console.ReadLine());
            ArithProgression arithProgression = new ArithProgression();
            arithProgression.SetStart(start);
            arithProgression.SetStep(step);
            GeomProgression geomProgression = new GeomProgression();
            geomProgression.SetStart(start);
            geomProgression.SetCommRatio(step);

            Console.WriteLine($"Члены арифметической прогресии = {arithProgression.GetNext()} {arithProgression.GetNext()} {arithProgression.GetNext()} {arithProgression.GetNext()} {arithProgression.GetNext()}");
            Console.WriteLine($"Члены геометричекой прогресии = {geomProgression.GetNext()} {geomProgression.GetNext()} {geomProgression.GetNext()} {geomProgression.GetNext()} {geomProgression.GetNext()}");
            //Console.WriteLine($"start = {arithProgression.} current = {}");
            arithProgression.Reset();
            geomProgression.Reset();
            Console.WriteLine();
            Console.WriteLine($"Члены арифметической прогресии = {arithProgression.GetNext()} {arithProgression.GetNext()} {arithProgression.GetNext()} {arithProgression.GetNext()} {arithProgression.GetNext()}");
            Console.WriteLine($"Члены геометричекой прогресии = {geomProgression.GetNext()} {geomProgression.GetNext()} {geomProgression.GetNext()} {geomProgression.GetNext()} {geomProgression.GetNext()}");

            Console.ReadKey();

        }
    }
}
