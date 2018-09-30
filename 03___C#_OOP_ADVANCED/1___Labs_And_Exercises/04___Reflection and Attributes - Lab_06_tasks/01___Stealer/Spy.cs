using System;
using System.Text;
using System.Reflection;
using System.Linq;

public class Spy
{
    public string StealFieldInfo(string classToInvestigate, params string[] fieldsToInvestigate)
    {
        var stringbuilder = new StringBuilder
            ($"Class under investigation: {classToInvestigate}" + Environment.NewLine);
        var fields = Type
            .GetType(classToInvestigate)
            .GetFields(BindingFlags.Instance 
                     | BindingFlags.Static
                     | BindingFlags.NonPublic 
                     | BindingFlags.Public);
        var instance = Activator.CreateInstance(Type.GetType(classToInvestigate));
        foreach (var field in fields)
        {
            if (fieldsToInvestigate.Contains(field.Name))
            {
                stringbuilder.AppendLine($"{field.Name} = {field.GetValue(instance)}");
            }
            
        }
        return stringbuilder.ToString().Trim();
    }
}

