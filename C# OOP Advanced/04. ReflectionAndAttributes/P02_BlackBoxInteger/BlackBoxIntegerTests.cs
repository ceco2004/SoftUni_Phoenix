namespace P02_BlackBoxInteger
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class BlackBoxIntegerTests
    {
        public static void Main()
        {
            //TODO put your reflection code here

            string command = Console.ReadLine();
            Type type = typeof(BlackBoxInteger);
            var constructor = type.GetConstructor(BindingFlags.Instance |BindingFlags.NonPublic, null,  new Type[] { typeof(int)}, null);
            var instance = (BlackBoxInteger)constructor.Invoke(new object[] {0});

            while (command != "END")
            {
                string[] args = command.Split("_", StringSplitOptions.RemoveEmptyEntries);
                
                var method = type.GetMethod(args[0], BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
                method.Invoke(instance, new object [] {int.Parse(args[1])});
                var field = type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic).First();
                int value = (int)field.GetValue(instance);
                Console.WriteLine(value);

                command = Console.ReadLine();
            }
        }
    }
}
