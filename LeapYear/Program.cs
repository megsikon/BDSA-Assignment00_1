namespace LeapYear;

public class Program
{
    //int leapYear;
    static void Main(string[] args) {
        Console.Write("Enter possible leap year: ");
        string yearStr = Console.ReadLine();
        int year = Convert.ToInt32(yearStr);
        Console.WriteLine(isLeapYearStr(isLeapYear(year)));
    }

    public static string isLeapYearStr(bool isLeap) {
      if (isLeap) {
        return "yay";
      } else {
        return "nay";
      }
    }
    public static bool isLeapYear(int year)
    {
        if ((year % 4 == 0) && ((year % 100 != 0) || (year % 400 == 0))) {
          return true;
        } else {
          return false;
        }
    }
}