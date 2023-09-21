using System.Runtime.CompilerServices;
using UnityEngine;

namespace AleVerDes.UnityUtils
{
    public static class FastDistance
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Check(Vector2 a, Vector2 b, float minDistance)
        {
            var num1 = Mathf.Abs(a.x - b.x);
            if (num1 > minDistance)
            {
                return false;
            }

            var num2 = Mathf.Abs(a.y - b.y);
            if (num2 > minDistance)
            {
                return false;
            }

            return num1 * num1 + num2 * num2 < minDistance * minDistance;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Check(Vector3 a, Vector3 b, float minDistance)
        {
            var num1 = Mathf.Abs(a.x - b.x);
            if (num1 > minDistance)
            {
                return false;
            }

            var num2 = Mathf.Abs(a.y - b.y);
            if (num2 > minDistance)
            {
                return false;
            }

            var num3 = Mathf.Abs(a.z - b.z);
            if (num3 > minDistance)
            {
                return false;
            }

            return num1 * num1 + num2 * num2 + num3 * num3 < minDistance * minDistance;
        }
    }
}