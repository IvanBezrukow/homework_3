double NDSpace(double arg1, double arg2)
{
    double formula = 0;
    formula = Math.Pow(arg2 - arg1, 2);
    return formula;
}




try
{
    Console.Write("Insert the numbers of domentions of your space: ");
    double spaceND = Convert.ToDouble(Console.ReadLine());
    double tempND = spaceND;
    double finalresult = 0;
    while (spaceND > 0)
    {
        Console.WriteLine("Insert two pair of coordinates to count the distance, for instance A(1,2,3,4,...) and B(5,6,7,8...)");
        Console.Write("Insert the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Insert the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        finalresult = finalresult + NDSpace(num1, num2);
        spaceND--;
    }
    Console.WriteLine($"The distance between two point is {Math.Round(Math.Sqrt(finalresult), 3)} in {tempND}-dementional space");
}
catch
{
    Console.WriteLine("You may insert only numbers");
}
