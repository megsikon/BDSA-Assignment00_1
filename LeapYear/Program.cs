namespace LeapYear;

public class Program
{
    //int leapYear;
    static void Main(string[] args) {
      int year;
      Console.Write("Enter possible leap year: ");
      string yearStr = Console.ReadLine();
      try
      {
        year = Convert.ToInt32(yearStr);
        Console.WriteLine(isLeapYearStr(isLeapYear(year), year));
      }
      catch (FormatException)
      {
        throw new FormatException(yearStr + " is not an integer");
      }
    }

    public static string isLeapYearStr(bool isLeap, int year) {
      if (year >= 1582) {
        if (isLeap) {
          return "yay";
        } else {
          return "nay";
        }
      } else {
        return "can only test years from 1582 to today";
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