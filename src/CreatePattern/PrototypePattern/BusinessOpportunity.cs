namespace CreatePattern.PrototypePattern;

public class BusinessOpportunity : ICloneable
{
    public string Zone { get; set; }

    public string Owner { get; set; }

    public object Clone()
    {
        // 浅拷贝
        return MemberwiseClone();
    }
}