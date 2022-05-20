using UnityEngine;
namespace AffenCode
{
    public static class ColorEx
    {
        public static Color WithR(this Color color, float value)
        {
            return new Color(value, color.g, color.b, color.a);
        }
        
        public static Color WithG(this Color color, float value)
        {
            return new Color(color.r, value, color.b, color.a);
        }
        
        public static Color WithB(this Color color, float value)
        {
            return new Color(color.r, color.g, value, color.a);
        }
        
        public static Color WithA(this Color color, float value)
        {
            return new Color(color.r, color.g, color.b, value);
        }
    }
}
