public class Assignment
{
    protected string _studentName;
    protected string _topic;
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }
    public void GetSummary()
    {
        Console.WriteLine($"{_studentName}-{_topic}");
    }
}