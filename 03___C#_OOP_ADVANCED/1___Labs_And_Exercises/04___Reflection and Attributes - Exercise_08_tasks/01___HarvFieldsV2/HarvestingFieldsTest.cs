namespace _01___Harvesting_Fields
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Text;

    public class HarvestingFieldsTest
    {
        private StringBuilder strBuilder;

        public HarvestingFieldsTest()
        {
            this.strBuilder = new StringBuilder();
        }

        internal string Run()
        {
            var inputCommand = Console.ReadLine();
            var fields = typeof(HarvestingFields).GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            while (inputCommand != "HARVEST")
            {
                switch (inputCommand)
                {
                    case "private":
                        this.AppendFields(fields.Where(f => f.IsPrivate));
                        break;
                    case "protected":
                        this.AppendFields(fields.Where(f => f.IsFamily));
                        break;
                    case "public":
                        this.AppendFields(fields.Where(f => f.IsPublic));
                        break;
                    case "all":
                        this.AppendFields(fields);
                        break;
                    default:
                        break;
                }

                inputCommand = Console.ReadLine();
            }

            return this.strBuilder.ToString().Trim();
        }

        private void AppendFields(IEnumerable<FieldInfo> fieldsCollection)
        {
            foreach (var field in fieldsCollection)
            {
                var accessMod = field.Attributes.ToString().ToLower();
                if (accessMod.Equals("family"))
                {
                    accessMod = "protected";
                }

                this.strBuilder.AppendLine($"{accessMod} {field.FieldType.Name} {field.Name}");
            }
        }
    }
}
