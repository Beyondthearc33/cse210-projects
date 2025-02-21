public class MathAssignment : Assignment
{
   private string _textbookSection;
   private string _problems;

    public MathAssignment (string studentName, string topic, string textbookSection, string problems ) :base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeWorkList(string _textbookSection, string _problems)
    {
        string homework = $"Section {_textbookSection} Problems {_problems}";
        return homework;
    }
}