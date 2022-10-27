namespace _04._GenericSwap
{
    public static class SwapElements
    {
        public static void Swap<T>(int firstIndex, int secondIndex, T[] arr)
        {
            if(firstIndex < 0 || secondIndex < 0 || firstIndex > arr.Length - 1 || secondIndex > arr.Length - 1)
            {
                throw new System.ArgumentOutOfRangeException($"Index must be between 0 and {arr.Length - 1}");
            }
            T firstIndexElement = arr[firstIndex];
            arr[firstIndex] = arr[secondIndex];
            arr[secondIndex] = firstIndexElement;
        }
    }
}
