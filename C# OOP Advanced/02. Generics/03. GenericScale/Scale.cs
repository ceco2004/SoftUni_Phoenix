using System;

namespace _03._GenericScale
{
    public static class Scale
    {
        public static T GetHeavier<T>(T left, T right) where T: IComparable<T>
        {
            if(left.CompareTo(right) > 0)
            {
                return left;
            }
            else if(left.CompareTo(right) < 0)
            {
                return right;
            }

            return default(T);

        }
    }
}
