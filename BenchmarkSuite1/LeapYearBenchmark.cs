using BenchmarkDotNet.Attributes;

[MemoryDiagnoser]
public class LeapYearBenchmark
{
    private int[] testYears = new int[1000];
    [GlobalSetup]
    public void Setup()
    {
        // Create a diverse set of test years
        for (int i = 0; i < testYears.Length; i++)
        {
            testYears[i] = 1900 + (i * 97) % 400;
        }
    }

    [Benchmark]
    public int CheckLeapYears()
    {
        int leapYearCount = 0;
        foreach (var year in testYears)
        {
            if (IsLeapYear(year))
            {
                leapYearCount++;
            }
        }

        return leapYearCount;
    }

    private bool IsLeapYear(int year)
    {
        return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
    }
}