namespace COMP003A.LectureActivity6_2;

/// <summary>
/// Rrepresents a base class for geometric shapes.
/// </summary>
public class Shape
{
    /// <summary>
    /// Displays the area of a shape.
    /// </summary>

    public virtual void DisplayArea()
    {
        Console.WriteLine("Calculating area of a shape.");
    }
}