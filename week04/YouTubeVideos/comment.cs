using System;

public class Comment
{
    public string _CommenterName { get; set; }
    public string Text { get; set; }

    public Comment(string commenterName, string text)
    {
        _CommenterName = commenterName;
        Text = text;
    }
}
