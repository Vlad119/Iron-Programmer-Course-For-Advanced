public class Figure
{
    public int Layer { get; set; }

    public string EdgeColor { get; set; } 

    public double EdgeThickness { get; set; }

    public string FillColor { get; set; }

    public Figure()
    {
        Layer = 0;
        EdgeColor = "чёрный";
        EdgeThickness = 1;
        FillColor = "белый";
    }
}