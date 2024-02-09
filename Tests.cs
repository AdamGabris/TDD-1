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

