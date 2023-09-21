using UnityEngine;

namespace AleVerDes.UnityUtils
{
    public static class RectTransformEx
    {
        public static Rect GetWorldRect(this RectTransform rt, Vector2 scale) 
        {
            var corners = new Vector3[4];
            rt.GetWorldCorners(corners);
            var topLeft = corners[0];

            var rect = rt.rect;
            var scaledSize = new Vector2(scale.x * rect.size.x, scale.y * rect.size.y);
            return new Rect(topLeft, scaledSize);
        }
        
        public static Rect GetWorldRect(this RectTransform rectTransform, float scale)
        {
            Vector3[] corners = new Vector3[4];
            rectTransform.GetWorldCorners(corners);
            // Get the bottom left corner.
            Vector3 position = corners[0];
         
            Vector2 size = new Vector2(
                rectTransform.lossyScale.x * rectTransform.rect.size.x,
                rectTransform.lossyScale.y * rectTransform.rect.size.y);
 
            return new Rect(position * (1f / scale), size * (1f / scale));
        }
        
        public static Rect GetWorldRect(this RectTransform rectTransform)
        {
            Vector3[] corners = new Vector3[4];
            rectTransform.GetWorldCorners(corners);
            // Get the bottom left corner.
            Vector3 position = corners[0];
         
            Vector2 size = new Vector2(
                rectTransform.lossyScale.x * rectTransform.rect.size.x,
                rectTransform.lossyScale.y * rectTransform.rect.size.y);
 
            return new Rect(position, size);
        }
    }
}