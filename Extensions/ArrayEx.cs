using UnityEngine;
namespace AffenCode
{
    public static class ArrayEx
    {
        public static T[] Shuffle<T> (this T[] array)
        {
            for (int t = 0; t < array.Length; t++ )
            {
                var r = Random.Range(t, array.Length);
                (array[t], array[r]) = (array[r], array[t]);
            }

            return array;
        }

        public static T GetRandomElement<T>(this T[] array)
        {
            return array[Random.Range(0, array.Length)];
        }
    }
}
