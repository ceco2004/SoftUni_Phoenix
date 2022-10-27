namespace _02._GenericArrayCreator
{
    public static class ArrayCreator
    {
        public static T[] Create<T>(int length, T item)
        {
            T[] arr = new T[length];
            return arr;
        }
    }
}
