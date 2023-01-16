int rec(int m, int n)
{
    if (m < 0)
    {
        m = 0;
    }

    if (n < m)
    {
        return 0;
    }

    return rec(m, n - 1) + n;
}

int m = 4, n = 8;

Console.WriteLine(rec(m, n));