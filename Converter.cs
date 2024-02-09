namespace Converter;
public class Convert
{
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
}

