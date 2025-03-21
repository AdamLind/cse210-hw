public class Word
{
    string _text;
    bool _isHidden;
    string _backupText;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
        _backupText = text;
    }

    public void Hide()
    {
        _isHidden = true;
        _text = new string('_', _text.Length);
    }
    public void Show()
    {
        _isHidden = false;
        _text = _backupText;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        return _text;
    }
}