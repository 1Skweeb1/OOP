using System.Text;
namespace ClassLibrary;

public class ExpressionHandler
{
    public ExpressionHandler() { }
    
    public StringBuilder[] Parse(string input)
    {
        string[] values = input.Split('+', '-', '*', '/');
        List<char> opperands = new List<char>();
        
        foreach (char value in input)
        {
            if (value == '+' || value == '-' || value == '*' || value == '/')
            {
                opperands.Add(value);
            }
        }
        StringBuilder[] result = new StringBuilder[opperands.Count];

        for(int i = 0; i < opperands.Count; i++)
        {   
            result[i] = new StringBuilder();
            result[i].Append(" " + values[i] + opperands[i] + values[i + 1] + " ");    
        } 

        return result;
    }
    public string ConvertResult(StringBuilder[] StrBuildArr)
    {
        StringBuilder result = new StringBuilder();
        foreach (StringBuilder value in StrBuildArr)
        {
            result.Append(value);
        }
        return result.ToString();
    }
}
