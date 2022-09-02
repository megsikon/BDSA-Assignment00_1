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

    [Fact]
    public void _2004isLeapYearStr()
    {
      //arrange
      int leapYear = 2004;

      //act
      var isLeap = Program.isLeapYear(leapYear);
      var isLeapStr = Program.isLeapYearStr(isLeap);

      //assert
      Assert.Equal("yay", isLeapStr);
    }

    [Fact]
    public void _2005isNotLeapYearStr()
    {
      //arrange
      int leapYear = 2005;

      //act
      var isLeap = Program.isLeapYear(leapYear);
      var isLeapStr = Program.isLeapYearStr(isLeap);

      //assert
      Assert.Equal("nay", isLeapStr);
    }

    [Fact]
    public void _1600isLeapYearStr()
    {
      //arrange
      int leapYear = 1600;

      //act
      var isLeap = Program.isLeapYear(leapYear);
      var isLeapStr = Program.isLeapYearStr(isLeap);

      //assert
      Assert.Equal("yay", isLeapStr);
    }

    [Fact]
    public void _1700isNotLeapYearStr()
    {
      //arrange
      int leapYear = 1700;

      //act
      var isLeap = Program.isLeapYear(leapYear);
      var isLeapStr = Program.isLeapYearStr(isLeap);

      //assert
      Assert.Equal("nay", isLeapStr);
    }
}