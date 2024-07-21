namespace SmoothData.Class;

public class ExcelClass
{
    [CountAttribute(isNeed: true)] public string Current { get; set; }
    [CountAttribute(isNeed: false)] public string Voltage { get; set; }
}