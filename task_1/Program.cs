string Palindrome(int arg1)
{
    int temp = arg1;
    string result = "The number ";
    int remainder1 = 0;
    int remainder2 = 0;
    int remainder3 = 0;
    int remainder4 = 0;
    int remainder5 = 0;
    remainder1 = arg1 % 10;
    arg1 = arg1 / 10;
    remainder2 = arg1 % 10;
    arg1 = arg1 / 10;
    remainder3 = arg1 % 10;
    arg1 = arg1 / 10;
    remainder4 = arg1 % 10;
    arg1 = arg1 / 10;
    remainder5 = arg1 % 10;
    if (remainder1 == remainder5 && remainder2 == remainder4)
        return $"{result}{temp} is a palindrome";
    else
        return $"{result}{temp} is not a palindorme";
}




try
{
    Console.WriteLine("Insert a 5-digit number");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num > 9999 && num < 100000)
    {
        Console.WriteLine($"{Palindrome(num)}");
    }
    else
        Console.WriteLine("That's not a 5-digit number");
}
catch
{
    Console.WriteLine("You may insert only numbers");
}