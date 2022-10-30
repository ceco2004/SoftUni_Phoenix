using System;

namespace _03._EnumAndAtribute.BookExample
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method
        | AttributeTargets.Interface, AllowMultiple = true)]
    public class AuthorAttribute : Attribute
    {
        public string Name { get; set; }
        public AuthorAttribute(string name)
        {
            Name = name;
        }
    }
}
