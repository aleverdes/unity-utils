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

        public static float Vector2ToDegree(Vector2 vector2)
        {
            return Vector2.SignedAngle(vector2, Vector2.up);
        }

        public static float Vector2ToDegree(Vector2 vector2, Vector2 axis)
        {
            return Vector2.SignedAngle(vector2, axis);
        }
    }
}
