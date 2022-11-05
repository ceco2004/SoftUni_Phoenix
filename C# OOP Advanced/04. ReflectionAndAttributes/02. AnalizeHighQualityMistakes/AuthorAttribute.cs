using System;

namespace _02._AnalizeHighQualityMistakes
{
    [AttributeUsage(AttributeTargets.All,  AllowMultiple = true)]
    public class AuthorAttribute : Attribute
    {
        public string Name { get; private set; }

        public AuthorAttribute(string name)
        {
            Name = name;
        }
    }
}
