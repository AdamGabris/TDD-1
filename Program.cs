
public class Converter
{
    int expected;
    int actual;

    public static double ConvertToMm(double inches)
    {
        return inches * 25.4;
    }
    public static double ConvertToCm(double inches)
    {
        return inches * 2.54;
    }
    public static double ConvertToM(double inches)
    {
        return inches * 0.0254;
    }
    public void Test()
    {
        if (expected == actual)
        {
            Console.WriteLine("Success");
        }
        else
        {
            Console.WriteLine("Failure");
        }
    }
}


class Program
{
    static void Main(string[] args)
    {
        foreach (var item in args)
        {
            if (item.Contains("mm"))
            {
                Console.WriteLine(Converter.ConvertToMm);
            }
            else if (item.Contains("cm"))
            {
                Console.WriteLine(Converter.ConvertToCm);

            }
            else if (item.Contains("m"))
            {
                Console.WriteLine(Converter.ConvertToM);

            }
        }
    }
}


