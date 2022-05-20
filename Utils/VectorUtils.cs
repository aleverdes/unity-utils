using UnityEngine;
namespace AffenCode
{
    public static class VectorUtils
    {
        public static Vector2 RadianToVector2(float radian)
        {
            return new(Mathf.Cos(radian), Mathf.Sin(radian));
        }

        public static Vector2 DegreeToVector2(float degree)
        {
            return RadianToVector2(degree * Mathf.Deg2Rad);
        }
    }
}
