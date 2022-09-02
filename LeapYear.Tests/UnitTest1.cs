namespace LeapYear.Tests;

public class LeapYearTest
{
    [Fact]
    public void _2004isLeapYear()
    {
      //arrange
      int leapYear = 2004;

      //act
      var res = Program.isLeapYear(leapYear);

      //assert
      Assert.True(res);
    }

    [Fact]
    public void _2005isNotLeapYear()
    {
      //arrange
      int leapYear = 2005;

      //act
      var res = Program.isLeapYear(leapYear);

      //assert
      Assert.True(!res);
    }

    [Fact]
    public void _1600isLeapYear()
    {
      //arrange
      int leapYear = 1600;

      //act
      var res = Program.isLeapYear(leapYear);

      //assert
      Assert.True(res);
    }

    [Fact]
    public void _1700isNotLeapYear()
    {
      //arrange
      int leapYear = 1700;

      //act
      var res = Program.isLeapYear(leapYear);

      //assert
      Assert.True(!res);
    }
}