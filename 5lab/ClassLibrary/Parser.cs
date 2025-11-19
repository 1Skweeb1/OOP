namespace ClassLibrary;

using System.Text;
using System.Text.RegularExpressions;

public class Parser
{
    public Parser(){}

    public StringBuilder Parse(string input)
    {
        StringBuilder result = new StringBuilder();
        Regex bracketRegex = new Regex(@"\(([^()]+)\)");
        string current = input;
        
        while (bracketRegex.IsMatch(current))
        {
            Match match = bracketRegex.Match(current);
            result.Append(match.Groups[0].Value + " = " + Evaluate(match.Groups[1].Value) + "\n");
            current = current.Remove(match.Index, match.Length).Insert(match.Index, Evaluate(match.Groups[1].Value).ToString());
        }
        
        result.Append(current + " = " + Evaluate(current) + "\n");

        return result;
    } 
    
    private int Evaluate(string input)
    {
        int result = 0;
        string[] values = input.Split('+', '-');
        List<char> opperands = new List<char>();
        if(values.Length == 1)
        {
            return int.Parse(values[0]);
        }
        foreach (char value in input)
        {
            if (value == '+' || value == '-')
            {
                opperands.Add(value);
            }
        }

        result+= int.Parse(values[0]);
        for(int i = 0; i < opperands.Count; i++)
        {
            switch (opperands[i])
            {
                case '+':
                    result += int.Parse(values[i+1]);
                    break;
                case '-':
                    result -= int.Parse(values[i+1]);
                    break;
            }
        }
        
        return result;
    }
}
