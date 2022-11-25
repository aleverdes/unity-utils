using UnityEngine;
namespace AffenCode
{
    public static class VectorEx
    {
        public static Vector2 ToXZ(this Vector3 vec)
        {
            return new Vector2(vec.x, vec.z);
        }
        
        public static Vector3 ToX0Z(this Vector2 vec)
        {
            return new Vector3(vec.x, 0, vec.y);
        }
        
        public static Vector3 ToXY0(this Vector2 vec)
        {
            return new Vector3(vec.x, vec.y, 0);
        }

        public static Vector3 WithX(this Vector3 vec, float x)
        {
            return new Vector3(x, vec.y, vec.z);
        }

        public static Vector3 WithY(this Vector3 vec, float y)
        {
            return new Vector3(vec.x, y, vec.z);
        }

        public static Vector3 WithZ(this Vector3 vec, float z)
        {
            return new Vector3(vec.x, vec.y, z);
        }

        public static Vector2 WithX(this Vector2 vec, float x)
        {
            return new Vector2(x, vec.y);
        }

        public static Vector2 WithY(this Vector2 vec, float y)
        {
            return new Vector2(vec.x, y);
        }
    }
}
