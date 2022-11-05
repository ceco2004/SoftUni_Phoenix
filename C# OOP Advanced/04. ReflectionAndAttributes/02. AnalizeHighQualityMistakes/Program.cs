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

            sb.AppendLine(Collector(investigatedClass));

            sb.AppendLine(GetGustomAttribute(investigatedClass));

            sb.AppendLine(GetMethodsAndAuthors(investigatedClass));

            Console.WriteLine(sb.ToString());
        }

        private static string GetMethodsAndAuthors(string investigatedClass)
        {
            Type type = GetMyType(investigatedClass);
            var methods = type.GetMethods(BindingFlags.Static
                                          | BindingFlags.Instance
                                          | BindingFlags.Public
                                          | BindingFlags.NonPublic);
            StringBuilder sb = new StringBuilder();
            foreach(var method in methods)
            {
                string methodName = method.Name;

            var attributes = method.CustomAttributes.Where(a => a.AttributeType == typeof(AuthorAttribute));
                foreach(var attr in attributes)
                {
                    string author = attr.ConstructorArguments.FirstOrDefault().Value.ToString();
                    sb.AppendLine($"Method {methodName} has writen by {author}");
                }
            }

            return sb.ToString();
        }

        private static string GetGustomAttribute(string investigatedClass)
        {
            Type type = GetMyType(investigatedClass);
            var methods = type.GetMethods(BindingFlags.Instance 
                                          | BindingFlags.Static
                                          | BindingFlags.Public
                                          | BindingFlags.NonPublic);
            StringBuilder sb = new StringBuilder();

            foreach (var method in methods)
            {
                var atributes = method.CustomAttributes.Where(a => a.AttributeType == typeof(AuthorAttribute));


                foreach (var attr in atributes)
                {
                    string name = attr.AttributeType.Name.Replace("Attribute", string.Empty);
                    string value = (string)attr.ConstructorArguments.FirstOrDefault().Value;
                    sb.AppendLine($"{name} - {value}");
                }
            }
            return sb.ToString();
        }

        private static string Collector(string investigatedClass)
        {
            Type type = GetMyType(investigatedClass);
            StringBuilder sb = new StringBuilder();
            if(type != null)
            {
                var setters = type.GetMethods(BindingFlags.Instance
                                               | BindingFlags.Static
                                               | BindingFlags.Public
                                               | BindingFlags.NonPublic)
                                    .Where(m => m.Name.StartsWith("get"));
                foreach(var setter in setters)
                {
                    string name = setter.Name;
                    string returnType = setter.ReturnType.Name;
                    sb.AppendLine($"{name} will return {returnType}");
                }

                var getters = type.GetMethods(BindingFlags.Instance
                                               | BindingFlags.Public
                                               | BindingFlags.NonPublic)
                                    .Where(m => m.Name.StartsWith("set"))
                                    .ToArray();

                foreach (var getter in getters)
                {
                    string name = getter.Name;
                    string setType = getter.GetParameters().FirstOrDefault().ParameterType.Name;
                    sb.AppendLine($"{name} will set field of {setType}");
                }
            }

            return sb.ToString();
        }

        private static string GetAllPrivateMethods(string investigatedClass)
        {
            Type type = GetMyType(investigatedClass);
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

            Type investigatedType = GetMyType(investigatedClass);
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

        private static Type GetMyType(string investigatedClass)
        {
            Type type = Assembly.GetCallingAssembly()
                               .GetTypes()
                               .Where(t => t.Name == investigatedClass)
                               .FirstOrDefault();

            return type;
        }
    }
}
