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
    }
}
