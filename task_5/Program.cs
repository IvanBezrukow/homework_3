string IfPalindrome(double arg1)
{
    string result = "This number ";
    double temp = arg1;
    double remainder = 0;
    double remainder1 = 0;
    double tempremainder = 0;
    double tempremainder1 = 0;
    double count = 0;
    double tempcount = 1;
    while (arg1 > 10)
    {
        arg1 = arg1 / 10;
        count++;
    }
    arg1 = Math.Round(arg1 * Math.Pow(10, count));
    while (count > 0)
    {
        tempremainder = Math.Round(arg1 % Math.Pow(10, tempcount));
        remainder = Math.Floor(arg1 / Math.Pow(10, count));
        if (tempremainder == remainder)
        {
            arg1 = arg1 - (Math.Pow(10, count) * tempremainder);
            arg1 = Math.Floor(arg1 / 10);
            tempcount = tempcount++;
            count = count - 2;
            tempremainder1 = Math.Round(arg1 % Math.Pow(10, tempcount));
            remainder1 = Math.Floor(arg1 / Math.Pow(10, count));
            if (tempremainder1 == remainder1 && arg1 > 10)
                continue;
            else
                return result + $"({temp}) is a palindrome";
        }
        else
            return result + $"({temp}) is not a palindrome";
    }
    return result + $"({temp}) is not a palindrome";
}




try
{
    Console.Write("Insert any number = ");
    double num = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine(IfPalindrome(num));
}
catch
{
    Console.WriteLine("You may insert only numbers");
}