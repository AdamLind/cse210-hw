public class Scripture
{
    Reference _reference;
    List<Word> _words = new List<Word>();

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        foreach (string word in text.Split(' '))
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        };
    }

    public void HideRandomWords(int numberToHide)
    {
        Random rnd = new Random();
        for (int i = 0; i < numberToHide; i++)
        {
            while (true)
            {
                int rndNum = rnd.Next(_words.Count);
                if (_words[rndNum].IsHidden() == false)
                {
                    _words[rndNum].Hide();
                    break;
                }
                else if (IsCompletelyHidden() == true)
                {
                    break;   
                }
                else
                {
                    continue;
                }
            }
        }
    }
    public string GetDisplayText()
    {
        string text = "";
        string str = String.Join(" ", _words);
        foreach (Word word in _words)
        {
            text += word.GetDisplayText();
            text += " ";
        }
        return $"{_reference.GetDisplayText()} {text}";
        
    }
    public bool IsCompletelyHidden()
    {
        bool hidden = true;
        foreach (Word word in _words)
        {
            bool isHidden = word.IsHidden();
            if (isHidden == false)
            {
                hidden = false;
            }
        }
        if (hidden == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}