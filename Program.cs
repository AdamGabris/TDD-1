using C = Converter.Convert;
using T = Converter.Test;
public class Program
{
   public static void Main(string[] args)
    {
        if (args.Length < 2 || args.Length > 3 || !double.TryParse(args[0], out _) || !args[1].StartsWith("-") || (args.Length == 3 && !args[2].Equals("-t")))
        {
            Console.WriteLine("Please provide a number of inches to convert and use the correct input style (number -unit -t).");
            return;
        }
        double inches = double.Parse(args[0]);
        string unit = args[1];
        bool runTests = args.Length > 2 && args[2] == "-t";

        if (runTests)
        {
            T.ConvertToMmTest();
            T.ConvertToCmTest();
            T.ConvertToMTest();
            T.ConvertToMMNegativeTest();
            T.ConvertToCMNegativeTest();
            T.ConvertToMNegativeTest();
            T.ConvertToMmZeroTest();
            T.ConvertToCmZeroTest();
            T.ConvertToMZeroTest();
            T.ConvertToMmDecimalTest();
            T.ConvertToCmDecimalTest();
            T.ConvertToMDecimalTest();
            return;
        }
        else 
        {
        if (unit == "-mm")
        {
            Console.WriteLine(C.ConvertToMm(inches));
        }
        else if (unit == "-cm")
        {
            Console.WriteLine(C.ConvertToCm(inches));
        }
        else if (unit == "-m")
        {
            Console.WriteLine(C.ConvertToM(inches));
        }
        else
        {
            Console.WriteLine("Please provide a valid unit of measurement (mm, cm, m).");
        }
        }
    }
}
 

