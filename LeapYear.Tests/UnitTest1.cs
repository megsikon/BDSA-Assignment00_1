namespace LeapYear.Tests;

public class LeapYearTest
{
    [Fact]
    public void _2004isLeapYear()
    {
      //arrange
      var sut = new LeapYear();
      int leapYear = 2004;

      //act
      var res = sut.isLeapYear(leapYear);

      //assert
    }
}