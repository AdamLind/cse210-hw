public class MathAssignment : Assignment
{
    string _textbookSection;
    string _problems;

    public MathAssignment(string name, string topic, string section, string problems) : base(name, topic)
    {
        _textbookSection = section;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }

}