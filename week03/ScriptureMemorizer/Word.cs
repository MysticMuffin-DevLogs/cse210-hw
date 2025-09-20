public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()  { _isHidden = true; }
    public void Show()  { _isHidden = false; }
    public bool IsHidden() => _isHidden;

    public string GetDisplayText()
    {
        if (!_isHidden) return _text;

        // Replace letters with underscores; keep length the same.
        // (Basic version: treat the whole thing as letters.)
        return new string('_', _text.Length);
    }
}