using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab1._1
{
    public struct Points
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public Points(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public override string ToString()
        {
            return $"({X}, {Y}, {Z})";
        }

    }
    public class Plane
    {
        private double[] coeffs = new double[4];

        public double A
        {
            get { return coeffs[0]; }
            set { coeffs[0] = value; }
        }
        public double B
        {
            get { return coeffs[1]; }
            set { coeffs[1] = value; }
        }
        public double C
        {
            get { return coeffs[2]; }
            set { coeffs[2] = value; }
        }
        public double D
        {
            get { return coeffs[3]; }
            set { coeffs[3] = value; }
        }
        public double this[int index]
        {
            get
            {
                ValidateIndex(index);
                return coeffs[index];
            }
            set
            {
                ValidateIndex(index);
                coeffs[index] = value;
            }
        }
        private void ValidateIndex(int index)
        {
            if(index < 0 || index > 3)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Індекс має бути від 0 до 3");
            }
        }
        public Plane(double a, double b, double c, double d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }
        public void Read()
        {
            Console.WriteLine("Введіть коефіцієнти рівняння площини (Ax + By + Cz + D = 0):");
            Console.Write("A = "); A = double.Parse(Console.ReadLine());
            Console.Write("B = "); B = double.Parse(Console.ReadLine());
            Console.Write("C = "); C = double.Parse(Console.ReadLine());
            Console.Write("D = "); D = double.Parse(Console.ReadLine());
        }

        public override string ToString() => $"{A}x + {B}y + {C}z + {D} = 0";

        public bool IsPointOnPlane(Points p)
        {
            double result = A * p.X + B * p.Y + C * p.Z + D;
            return Math.Abs(result) < 1e-9;
        }

        public void PrintAxisIntersections()
        {
            Console.WriteLine("Точки перетину з осями координат:");

            if (Math.Abs(A) > 1e-9) Console.WriteLine($"Вісь X: ({-D / A}, 0, 0)");
            else Console.WriteLine("З віссю X немає перетину.");

            if (Math.Abs(B) > 1e-9) Console.WriteLine($"Вісь Y: (0, {-D / B}, 0)");
            else Console.WriteLine("З віссю Y немає перетину.");

            if (Math.Abs(C) > 1e-9) Console.WriteLine($"Вісь Z: (0, 0, {-D / C})");
            else Console.WriteLine("З віссю Z немає перетину.");
        }
    }
}
