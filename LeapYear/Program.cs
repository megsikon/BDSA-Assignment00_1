namespace LeapYear;

public class Program
{
    //int leapYear;
    static void Main(string[] args) {
        Console.WriteLine(isLeapYear(2004));
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