 namespace P01_HarvestingFields
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Text;

    public class HarvestingFieldsTest
    {
        public static void Main()
        {
            //TODO put your reflection code here

            string command = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            Type type = typeof(HarvestingFields);

            while(command != "HARVEST")
            {
                switch (command)
                {
                    case "private":
                        GetAllPrivate(sb, type);
                        break;
                    case "protected":
                        GetAllProtected(sb, type);
                        break;
                    case "public":
                        GetAllPublic(sb, type);
                        break;
                    case "all":
                        GetAllFields(sb, type);
                        break;
                }
                Console.WriteLine(sb.ToString());
                sb.Clear();
                command = Console.ReadLine();
            }
        }

        private static void GetAllFields(StringBuilder sb, Type type)
        {
            var fields = GetFields(type);
            AddFieldsToStringBuilder(fields, sb);
        }

        private static void AddFieldsToStringBuilder(FieldInfo[] fields, StringBuilder sb)
        {
            foreach (var field in fields)
            {
                string fType = field.FieldType.Name;
                string fName = field.Name;
                string fAttribute = field.Attributes.ToString();
                sb.AppendLine($"{fAttribute} {fType} {fName}");
            }
        }

        private static void GetAllPublic(StringBuilder sb, Type type)
        {
            var fields = GetFields(type);
            AddFieldsToStringBuilder(fields.Where(f => f.IsPublic).ToArray(), sb);
        }

        private static void GetAllProtected(StringBuilder sb, Type type)
        {
            var fields = GetFields(type);
            AddFieldsToStringBuilder(fields.Where(f => f.IsFamily).ToArray(), sb);
        }

        private static void GetAllPrivate(StringBuilder sb, Type type)
        {
            var fields = GetFields(type);
            AddFieldsToStringBuilder(fields.Where(f => f.IsPrivate).ToArray(), sb);
        }

        private static FieldInfo[] GetFields(Type type)
        {
            var fields = type.GetFields(BindingFlags.Instance
                                        | BindingFlags.Static
                                        | BindingFlags.NonPublic
                                        | BindingFlags.Public);
            return fields;
        }
    }
}
