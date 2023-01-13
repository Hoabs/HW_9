double Akkerman(double m, double n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return Akkerman(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
    else
    {
        Console.WriteLine("Error! Enter a positive arguments");
        return 0;
    }
    
}

Console.WriteLine(Akkerman(3, 2));