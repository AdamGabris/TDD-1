namespace Converter;

public class Test 
{
public static void ConvertToMmTest()
    {
        double inches = 10;
        double expectedMm = inches * 25.4;
        double actualMm = Convert.ConvertToMm(inches);
        TestFunction(expectedMm, actualMm, "ConvertToMmTest");
    }

    public static void ConvertToCmTest()
    {
        double inches = 10;
        double expectedCm = inches * 2.54;
        double actualCm = Convert.ConvertToCm(inches);
        TestFunction(expectedCm, actualCm, "ConvertToCmTest");
    }

    public static void ConvertToMTest()
    {
        double inches = 10;
        double expectedM = inches * 0.0254;
        double actualM = Convert.ConvertToM(inches);
        TestFunction(expectedM, actualM, "ConvertToMTest");
    }
        public static void ConvertToMMNegativeTest()
    {
        double inches = -10;
        double expectedMm = inches * 25.4;
        double actualMm = Convert.ConvertToMm(inches);
        TestFunction(expectedMm, actualMm, "ConvertToMmNegativeTest");
    }
    public static void ConvertToCMNegativeTest()
    {
        double inches = -10;
        double expectedCm = inches * 2.54;
        double actualCm = Convert.ConvertToCm(inches);
        TestFunction(expectedCm, actualCm, "ConvertToCmNegativeTest");
    }
    public static void ConvertToMNegativeTest()
    {
        double inches = -10;
        double expectedM = inches * 0.0254;
        double actualM = Convert.ConvertToM(inches);
        TestFunction(expectedM, actualM, "ConvertToMNegativeTest");
    }
    public static void ConvertToMmZeroTest()
    {
        double inches = 0;
        double expectedMm = inches * 25.4;
        double actualMm = Convert.ConvertToMm(inches);
        TestFunction(expectedMm, actualMm, "ConvertToMmZeroTest");
    }
    public static void ConvertToCmZeroTest()
    {
        double inches = 0;
        double expectedCm = inches * 2.54;
        double actualCm = Convert.ConvertToCm(inches);
        TestFunction(expectedCm, actualCm, "ConvertToCmZeroTest");
    }
    public static void ConvertToMZeroTest()
    {
        double inches = 0;
        double expectedM = inches * 0.0254;
        double actualM = Convert.ConvertToM(inches);
        TestFunction(expectedM, actualM, "ConvertToMZeroTest");
    }
    public static void ConvertToMmDecimalTest()
    {
        double inches = 10.5;
        double expectedMm = inches * 25.4;
        double actualMm = Convert.ConvertToMm(inches);
        TestFunction(expectedMm, actualMm, "ConvertToMmDecimalTest");
    }
    public static void ConvertToCmDecimalTest()
    {
        double inches = 10.5;
        double expectedCm = inches * 2.54;
        double actualCm = Convert.ConvertToCm(inches);
        TestFunction(expectedCm, actualCm, "ConvertToCmDecimalTest");
    }
    public static void ConvertToMDecimalTest()
    {
        double inches = 10.5;
        double expectedM = inches * 0.0254;
        double actualM = Convert.ConvertToM(inches);
        TestFunction(expectedM, actualM, "ConvertToMDecimalTest");
    }

    public static void TestFunction<T>(T expected, T actual, string description = "Test")
    {
        if (expected.Equals(actual))
        {
            Console.WriteLine($"🟢 {description}, expected {expected}, received {actual}");
        }
        else
        {
            Console.WriteLine($"🔴 {description}, expected {expected}, received {actual}");
        }
    }

    public static void TestFunction(int expected, int actual, string description)
    {
        TestFunction<int>(expected, actual, description);
    }
}

