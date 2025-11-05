namespace ClassLibrary;
public class Unit
{
    public char operand { get; set; }
    public string valueLeft { get; set; }
    public string valueRight { get; set; }

    public Unit()
    {

    }
    public void EnterUnit(char operand, string valueLeft, string valueRight)
    {
        this.operand = operand;
        this.valueLeft = valueLeft;
        this.valueRight = valueRight;
    }
}