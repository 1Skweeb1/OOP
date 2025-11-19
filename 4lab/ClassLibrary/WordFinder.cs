using System.Text;
namespace ClassLibrary;
public class WordFinder
{
    public WordFinder() { }

    public StringBuilder FindWords(string input)
    {
        StringBuilder result = new StringBuilder();
        string[] words = input.Split(' ');
        foreach (var word in words)
        {
            if (word.Length > 1 && word[0] == word[word.Length - 1])
            {
                result.Append(word + " ");
            }
        }
        return result;
    }
}