using System.IO.Compression;

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
    public static void ConvertToMmAndRoundTest()
    {
        double inches = 10.5;
        double expectedMm = Math.Round(inches * 25.4, 2);
        double actualMm = Math.Round(Convert.ConvertToMm(inches), 2);
        TestFunction(expectedMm, actualMm, "ConvertToMmAndRoundTest");
    }
    public static void ConvertToCmAndRoundTest()
    {
        double inches = 10.5;
        double expectedCm = Math.Round(inches * 2.54, 2);
        double actualCm = Math.Round(Convert.ConvertToCm(inches), 2);
        TestFunction(expectedCm, actualCm, "ConvertToCmAndRoundTest");
    }
    public static void ConvertToMAndRoundTest()
    {
        double inches = 10.5;
        double expectedM = Math.Round(inches * 0.0254, 2);
        double actualM = Math.Round(Convert.ConvertToM(inches), 2);
        TestFunction(expectedM, actualM, "ConvertToMAndRoundTest");
    }
    public static void ConvertBackTest()
    {
        double inches = 10.5;
        double mm = Convert.ConvertToMm(inches);
        double cm = Convert.ConvertToCm(inches);
        double m = Convert.ConvertToM(inches);
        TestFunction(inches, Convert.ConvertMmToInches(mm), "ConvertBackMmTest");
        TestFunction(inches, Convert.ConvertCmToInches(cm), "ConvertBackCmTest");
        TestFunction(inches, Convert.ConvertMToInches(m), "ConvertBackMTest");
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

