public class Video
{
    string _title;
    string _author;
    int _length;
    List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        // _comments = comments;
    }
    Comment comment1 = new Comment("billy", "I love videos like this!");
    Comment comment2 = new Comment("bobby", "We need more vids like this!");
    Comment comment3 = new Comment("jean", "I am grateful for videos like this!");
    Comment comment4 = new Comment("jill", "That cat is so cute!");
    public void addComments() {
        _comments.Add(comment1);
        _comments.Add(comment2);
        _comments.Add(comment3);
        _comments.Add(comment4);

    }

    public void DisplayContent()
    {
        Console.WriteLine($"{_title}, {_author}, Length: {_length} seconds");
        DisplayNumberOfComments();
        foreach (Comment a in _comments)
        {
            Console.WriteLine($"{a.GetCommenter()}: {a.GetContent()}");
        }
    }
    public void DisplayNumberOfComments()
    {
        Console.WriteLine($"Number of comments: {_comments.Count}");
    }
}