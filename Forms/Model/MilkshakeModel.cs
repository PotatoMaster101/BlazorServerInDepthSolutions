using System.ComponentModel.DataAnnotations;

namespace Forms.Model;

public enum MilkshakeSize
{
    Small,
    Medium,
    Large
}

public enum MilkshakeType
{
    Chocolate,
    Vanilla,
    Strawberry
}

public class MilkshakeModel
{
    [Required]
    [EnumDataType(typeof(MilkshakeSize), ErrorMessage = "Invalid size")]
    public MilkshakeSize Size { get; set; }

    [Required]
    [EnumDataType(typeof(MilkshakeType), ErrorMessage = "Invalid type")]
    public MilkshakeType Type { get; set; }

    [Required]
    [StringLength(999, MinimumLength = 3, ErrorMessage = "Invalid name: too long or too short")]
    public string Name { get; set; } = "Milkshake";

    [Required]
    [Range(1, 999, ErrorMessage = "Invalid count: too big or too small")]
    public int Count { get; set; } = 1;

    public bool Cream { get; set; }
}
