namespace SmoothData;

/// <summary>
/// Property指定特性可以应用于属性
/// Inherited = false指定特性不会被继承到派生类
/// AllowMultiple = false指定特性无法在同一个成员上多次使用
/// </summary>
[AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
public class CountAttribute : Attribute
{
    public bool IsNeed { get; }

    public CountAttribute(bool isNeed)
    {
        IsNeed = isNeed;
    }
}