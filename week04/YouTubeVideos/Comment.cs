public class Comment
{
    string _commenter;
    string _content;

    public Comment(string commenter, string content)
    {
        _commenter = commenter;
        _content = content;
    }

    public string GetCommenter()
    {
        return _commenter;
    }    
    public string GetContent()
    {
        return _content;
    }
}