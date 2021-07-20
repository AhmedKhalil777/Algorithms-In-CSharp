using System;

namespace LongestBlockOfOnes
{
    public static class Extensions
    {
        public static T[] SubArray<T>(this T[] array, int offset, int last)
        {
            T[] result = new T[last - offset];
            Array.Copy(array, offset, result, 0, last - offset);
            return result;
        }

    }
}
