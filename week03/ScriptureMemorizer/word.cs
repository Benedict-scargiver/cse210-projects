public class Word
{
    private string _text;
    private bool _isHidden = true;

    public bool Value { get; private set; }

    // Constructor
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

     
    // Method to hide the word
    public void Hide()
    {
        _isHidden = true;
    }

    // Method to show the word
    public void Show()
    {
        _isHidden = false;
    }

    // Method to check if the word is hidden
    public bool IsHidden()
    {
        return _isHidden;
    }

    public bool GetIsHidden(){
        return _isHidden;
    }
    public void SetIsHidden(){
        _isHidden = true;
    }

    public string GetText(){
        return _text;

    }

    public void setText(string fuck){
        _text = fuck;
    }

    // Method to get the display text of the word
    public string GetDisplayText()
    {
        return _isHidden ? "___" : _text;
    }
}