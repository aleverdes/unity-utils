using UnityEngine;

namespace AleVerDes
{
    public static class TextUtils
    {
        public static string SetColor(this string str, Color color)
        {
            return str.SetColor("#" + ColorUtility.ToHtmlStringRGBA(color));
        }

        public static string SetColor(this string str, string hexColor)
        {
            if (!hexColor.StartsWith("#"))
            {
                hexColor = "#" + hexColor;
            }

            return $"<color={hexColor}>{str}</color>";
        }
    }
}