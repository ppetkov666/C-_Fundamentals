namespace _02___Black_Box_Integer
{
    using System;
    using System.Text;
    using System.Linq;
    using System.Reflection;
    

    public class BlackBoxIntegerTests
    {
        private StringBuilder testResult;

        public BlackBoxIntegerTests()
        {
            this.testResult = new StringBuilder();
        }

        public string Run(Type type)
        {
            var classInstance = Activator.CreateInstance(type, true);
            var methods = type.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
            var fields = type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            var command = Console.ReadLine().Split('_');

            while (command[0] != "END")
            {
                var num = int.Parse(command[1]);
                methods.FirstOrDefault(p => p.Name == command[0])?.Invoke(classInstance, new object[] { num });

                foreach (var field in fields)
                {
                    this.testResult.AppendLine(field.GetValue(classInstance).ToString());
                }

                command = Console.ReadLine().Split('_');
            }

            return testResult.ToString().Trim();
        }
    }
}
