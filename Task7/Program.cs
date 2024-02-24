








public class Math
{
    public double Abs(double value)
    {
        if (value > 0)
        {
            return value * (-1);
        }
        else
        {
            return value * (-1);
        }
    }

    public Abs(float value)
    {
        if (value > 0)
        {
            return value * (-1);
        }
        else
        {
            return value * (-1);
        }
    }
    public int Abs(int value)
    {
        if (value > 0)
        {
            return value * (-1);
        }
        else
        {
            return value * (-1);
        }
    }
    public static double Pow(double x, double y)
    {
        return Math.Pow(x, y);
    }

    public double Sqrt(int d)
    {
        if (d < 0)
        {

            return 0.0;
        }

        double daraja = d / 2.0;
        const double a = 0.000001;

        while (Abs(daraja * daraja - d) > a)
        {
            daraja = 0.5 * (daraja + d / daraja);
        }

        return daraja;
    }


public int Max(int val1, int val2);
{
    if (val1 > val2)
    {
        return val1;
    }
    else
    {
        return val2;
    }

}
public int Min(int val1, int val2);
{
    if (val1 < val2)
    {
        return val1;
    }
    else
    {
        return val2;
    }

}
public const double PI = 3.14;
public const double E = 2.71;
}

