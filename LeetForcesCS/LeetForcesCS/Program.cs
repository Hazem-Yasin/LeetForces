class Result
{

    /*
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        string period = s.Substring(s.Length - 2); //AM or PM
        string time = s.Substring(0, s.Length - 2);
        string[] parts = time.Split(':');

        int hour = int.Parse(Parts[0]);

        if (period == "AM" && hour == 12)
        {
            hour = 0;
        }
        else if (period = "PM" && hour != 12)
        {
            hour += 12;
        }
        return $"{hour:D2}:{parts[1]}:{parts[2]}";
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
