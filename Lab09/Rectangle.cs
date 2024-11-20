namespace Lab09;

public class Rectangle : AbstractGraphic2D
{
    public override decimal LowerBoundX => -1;

    public override decimal UpperBoundX => -1;

    public override decimal LowerBoundY => -1;

    public override decimal UpperBoundY => -1;
    public decimal Left;
    public decimal Top;
    public decimal Width;
    public decimal Height;
    public Rectangle(decimal Left, decimal Top, decimal Width, decimal Height)
    {
        this.Left = Left;
        this.Top = Top;
        this.Width = Width;
        this.Height = Height;
    }
    public override bool ContainsPoint(decimal x, decimal y)
    {
        return false;
    }
}