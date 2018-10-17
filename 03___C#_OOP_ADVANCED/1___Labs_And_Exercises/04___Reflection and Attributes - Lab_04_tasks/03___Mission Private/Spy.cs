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
    public string AnalyzeAcessModifiers(string className)
    {
        var sb = new StringBuilder();
        var targetType = Type.GetType(className);

        var wrongFields = targetType.GetFields(BindingFlags.Instance | BindingFlags.Static |
            BindingFlags.Public);

        foreach (var field in wrongFields)
        {
            sb.AppendLine($"{field.Name} must be private!");
        }

        var pulbicMethods = targetType.GetMethods(BindingFlags.Instance | BindingFlags.Public);
        var nonpulbicMethods = targetType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

        foreach (var method in nonpulbicMethods.Where(m => m.Name.StartsWith("get")))
        {
            sb.AppendLine($"{method.Name} have to be public!");
        }

        foreach (var method in pulbicMethods.Where(m => m.Name.StartsWith("set")))
        {
            sb.AppendLine($"{method.Name} have to be private!");
        }

        return sb.ToString().Trim();
    }
    public string RevealPrivateMethods(string className)
    {
        var targetType = Type.GetType(className);
        var sb = new StringBuilder();
        sb.AppendLine($"All Private Methods of Class: {targetType}");

        var baseType = targetType.BaseType;
        sb.AppendLine($"Base Class: {baseType.Name}");

        var privateMethods = targetType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
        foreach (var method in privateMethods)
        {
            sb.AppendLine(method.Name);
        }

        return sb.ToString().Trim();
    }

}

