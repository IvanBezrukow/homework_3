string Distance3D
(double arg1, double arg2, double arg3,
double arg4, double arg5, double arg6)
{
    double result = 0;
    result = Math.Sqrt((Math.Pow(arg4 - arg1, 2)) + (Math.Pow(arg5 - arg2, 2)) + (Math.Pow(arg6 - arg3, 2)));
    return $"The distance between two points is {Math.Round(result, 2)}";
}



try
{
    Console.Write("Insert x1 = ");
    double x1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Insert y1 = ");
    double y1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Insert z1 = ");
    double z1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Insert x2 = ");
    double x2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Insert y2 = ");
    double y2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Insert z2 = ");
    double z2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"The distance between two points is {Distance3D(x1, y1, z1, x2, y2, z2)}");
}
catch
{
    Console.WriteLine("You may insert only numbers");
}