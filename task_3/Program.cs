string PowerOf3(int arg1)
{
    string result = ".";
    for (int i = 1; arg1 >= i; i++)
    {
        Console.Write($" --> {Math.Pow(i, 3)}");
    }
    return result;
}




try
{
    Console.Write("Insert any number = ");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.Write(num);
    Console.Write(PowerOf3(num));
}
catch
{
    Console.WriteLine("Ypu may insert only numbers");
}