namespace GradeBook;

public class statistics
{
    public statistics(double Average, double Highest, double Lowest)
    {
        this.Average = Average;
        this.Highest = Highest;
        this.Lowest = Lowest;
    }
    public double getAverage()
    {
        return Average;
    }
    public double getHighest()
    {
        return Highest;
    }
    public double getLowest()
    {
        return Lowest;
    }
    private double Average;
    private double Highest;
    private double Lowest;
}