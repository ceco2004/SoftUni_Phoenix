using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace _02._AnalizeHighQualityMistakes
{
    public class Program
    {
        static void Main()
        {
            string investigatedClass = "Hacker";
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(AnalizeClass(investigatedClass));
            
            sb.AppendLine(GetAllPrivateMethods(investigatedClass));

            Console.WriteLine(sb.ToString());
        }

        private static string GetAllPrivateMethods(string investigatedClass)
        {
            Type type = Assembly.GetCallingAssembly()
                                .GetTypes()
                                .Where(t => t.Name == investigatedClass)
                                .FirstOrDefault();
            StringBuilder sb = new StringBuilder();
            if(type != null)
            {
                sb.AppendLine($"All Private Methods of Class: {investigatedClass}");

                var methods = type.GetMethods(BindingFlags.Instance
                                              | BindingFlags.Static
                                              | BindingFlags.NonPublic);
                string baseClass = type.BaseType.Name;
                sb.AppendLine($"Base Class: {baseClass}");
                foreach(var method in methods)
                {
                    sb.AppendLine($"  -{method.Name}");
                }

            }
            return sb.ToString();
        }

        private static string AnalizeClass(string investigatedClass)
        {
            StringBuilder sb = new StringBuilder();

            Type investigatedType = Assembly.GetCallingAssembly()
                                   .GetTypes()
                                   .Where(t => t.Name == investigatedClass)
                                   .FirstOrDefault();
            if(investigatedType != null)
            {
                var allPublicFields = investigatedType.GetFields(BindingFlags.Instance
                                                                 | BindingFlags.Static
                                                                 | BindingFlags.Public);
                sb.AppendLine("High Quality Mistakes:");
                foreach(var field in allPublicFields)
                {
                    sb.AppendLine($"  Field {field.Name} must be private!");
                }


                var allNonPublicGetters = investigatedType.GetMethods(BindingFlags.Instance
                                                                      | BindingFlags.Static
                                                                      | BindingFlags.NonPublic)
                                                            .Where(m => m.Name.StartsWith("get"))
                                                            .ToArray();
                foreach(var method in allNonPublicGetters)
                {
                    sb.AppendLine($"  Getter {method.Name} must be public!");
                }
                

                var allPublicSetters = investigatedType.GetMethods(BindingFlags.Instance
                                                                   | BindingFlags.Static
                                                                   | BindingFlags.Public)
                                                        .Where(m => m.Name.StartsWith("set"))
                                                        .ToArray();
                foreach(var method in allPublicSetters)
                {
                    sb.AppendLine($"  Setter {method.Name} must be private!");
                }

            }


            return sb.ToString();
        }
    }
}
