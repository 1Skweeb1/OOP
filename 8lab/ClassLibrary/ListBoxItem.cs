public class ListBoxItem
{
    public string Text { get; set; }
    public string ColorName { get; set; }

    public ListBoxItem(string text, string colorName = null)
    {
        Text = text;
        ColorName = colorName;
    }

    public override string ToString()
    {
        return Text; 
    }
}
