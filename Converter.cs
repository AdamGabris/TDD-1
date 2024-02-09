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

    // Reverse conversion methods for backwards compatibility

    public static double ConvertMmToInches(double mm)
    {
        return mm / 25.4;
    }
    public static double ConvertCmToInches(double cm)
    {
        return cm / 2.54;
    }
    public static double ConvertMToInches(double m)
    {
        return m / 0.0254;
    }
}

