public class Entry
{
    public string _date;
    public string _prompt;
    public string _response;
    public string _feeling;
    public void Display(List<Entry> entries)
    {
        foreach (Entry item in entries)
        {
            Console.WriteLine($"Date: {item._date} - Feeling at time of writing: {item._feeling}");
            Console.WriteLine($"Prompt: {item._prompt}");
            Console.WriteLine($"{item._response}\n");
        }
    }
}