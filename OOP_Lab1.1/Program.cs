namespace OOP_Lab1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Plane pl = new Plane(2, -4, 3, -12);
            pl.Read();

            Console.WriteLine("Рівняння площини: " + pl);

            Console.WriteLine($"Коефіцієнт A через індексатор [0]: {pl[0]}");

            pl.PrintAxisIntersections();

            Points testPoint = new Points(0, 0, 4);
            bool isOnPlane = pl.IsPointOnPlane(testPoint);

            Console.WriteLine($"Точка {testPoint} лежить на площині? {(isOnPlane ? "Так" : "Ні")}");
        }
    }
}
