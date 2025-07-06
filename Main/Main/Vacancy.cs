
internal class Vacancy : Profile
{
    public int ZP {  get; set; }
    public Vacancy(string name, int zp) : base(name) 
    { 
        ZP = zp;
    }

    protected override string GetInfo()
    {
        return $"Предлагаемая зарплата: {ZP}";
    }
}

