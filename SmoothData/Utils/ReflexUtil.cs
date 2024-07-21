using System.Reflection;

namespace SmoothData.Utils;

public static class ReflexUtil<AttrClass, CaseClass> where AttrClass : Attribute
{
    public static Dictionary<string, bool> ReflexAttrIsNeed(CaseClass obj)
    {
        Dictionary<string, bool> bs = new Dictionary<string, bool>();
        try
        {
            Type type = typeof(CaseClass);
            PropertyInfo[] properties = type.GetProperties();
            foreach (var item in properties)
            {
                if (Attribute.IsDefined(item, typeof(AttrClass)))
                {
                    AttrClass? attr = (AttrClass)Attribute.GetCustomAttribute(item, typeof(AttrClass));
                    if (attr != null)
                    {
                        var result = (attr as CountAttribute)?.IsNeed ?? false;
                        bs.Add(item.Name, result);
                    }
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Reflex Error:{e.Message}");
        }

        return bs;
    }
}