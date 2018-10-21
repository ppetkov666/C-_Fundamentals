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
            string searchedMod = Console.ReadLine();
            FieldInfo[] fields = typeof(HarvestingFields).GetFields(BindingFlags.Instance | 
                                                            BindingFlags.Public | 
                                                            BindingFlags.NonPublic);

            var accessModFilters = new Dictionary<string, Func<IEnumerable<FieldInfo>>>()
            {
                { "all", () => fields },
                { "public", () => fields.Where(p => p.IsPublic) },
                { "private", () => fields.Where(p => p.IsPrivate) },
                { "protected", () => fields.Where(p => p.IsFamily) },
            };

            while (searchedMod != "HARVEST")
            {
                this.AppendAllFields(accessModFilters[searchedMod]());
                searchedMod = Console.ReadLine();
            }

            return this.strBuilder.ToString().Trim();
        }

        private void AppendAllFields(IEnumerable<FieldInfo> fieldsCollection)
        {
            foreach (var field in fieldsCollection)
            {
                var accessmodifier = field.Attributes.ToString().ToLower();
                if (accessmodifier.Equals("family"))
                {
                    accessmodifier = "protected";
                }

                this.strBuilder.AppendLine($"{accessmodifier} {field.FieldType.Name} {field.Name}");
            }
        }
    }
}
