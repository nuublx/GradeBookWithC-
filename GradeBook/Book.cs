namespace GradeBook;

public class Book
{
    public Book(string name)
    {
        grades = new List<double>();
        this.name = name;
        highestGrade = double.MinValue;
        lowestGrade = double.MaxValue;
    }

    public bool addGrade(double grade)
    {
        if (grade < 0 || grade > 100)
            return false;
        lowestGrade = Math.Min(lowestGrade, grade);
        highestGrade = Math.Max(highestGrade, grade);
        grades.Add(grade);
        return true;
    }

    public void showStatistics()
    {
        double averageGrade = 0,sumOfGrades=0;
        foreach (var grade in grades)
        {
            sumOfGrades += grade;
        }
        averageGrade = sumOfGrades / grades.Count;
        Console.WriteLine($"Highest Grade: {highestGrade}");
        Console.WriteLine($"Lowest Grade: {lowestGrade}");
        Console.WriteLine($"Average Grade: {averageGrade}");
    }
    private List<double> grades;
    private string name;
    private double highestGrade;
    private double lowestGrade;
}