namespace Tests;
using GradeBook;
public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var book = new Book("Zeyad's GradeBook");
        book.addGrade(50);
        book.addGrade(65);
        book.addGrade(89);
        book.addGrade(92);
        book.addGrade(100);
        book.addGrade(78);
        var result = book.getStatistics();
        Assert.Equal(79,result.getAverage());
        Assert.Equal(100,result.getHighest());
        Assert.Equal(50,result.getLowest());
    }
}