using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task20
{
    class Program
    {
        delegate double MyDelegate(double R);
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус");
            double r= Convert.ToDouble(Console.ReadLine());
            MyDelegate length = new MyDelegate(Length);
            length?.Invoke(r);
            MyDelegate area = new MyDelegate(Area);
            area?.Invoke(r);
            MyDelegate volume = new MyDelegate(Volume);
            volume?.Invoke(r);

            Console.ReadKey();

        }
        static double Length(double R)
        {
            double l=2 * Math.PI * R;
            Console.WriteLine("Длина окружности={0}",l);
            return l ;
        }

        static double Area(double R)
        {
            double s = Math.PI * R*R;
            Console.WriteLine("Площадь круга={0}", s);
            return s;
        }

        static double Volume(double R)
        {
            double v = 4 / 3 * Math.PI * R * R * R;
            Console.WriteLine("Объем шара={0}", v);
            return v;
        }

    }
}
