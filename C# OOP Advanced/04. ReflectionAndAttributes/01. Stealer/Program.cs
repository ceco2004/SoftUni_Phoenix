using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace _01._Stealer
{
    public class Program
    {
        static void Main(string[] args)
        {
            string investigationClass = "Hacker";

            
            var searched = new[] { "Hacker", "username", "password"};


            string result = InvestigateClass(investigationClass, searched);
            

            Console.WriteLine(result);
        }

        private static string InvestigateClass(string investigationClass, string[] searched)
        {
            Type typeHacker = Assembly.GetCallingAssembly().GetExportedTypes()
                .Where(t => t.Name == investigationClass)
                .FirstOrDefault();

            var instanceOfHacker = Activator.CreateInstance(typeHacker);
            var fields = typeHacker.GetFields(BindingFlags.Instance
                                              | BindingFlags.Static
                                              | BindingFlags.NonPublic
                                              | BindingFlags.Public
                                              | BindingFlags.GetField);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Class under investigation: {investigationClass}");
            foreach (var field in fields)
            {
                string name = field.Name;
                if (!searched.Contains(name))
                {
                    continue;
                }

                Type typeOfField = field.FieldType;
                string value = field.GetValue(instanceOfHacker).ToString();

                sb.AppendLine($"{name} - {value}");
            }

            return sb.ToString();
        }
    }
}
