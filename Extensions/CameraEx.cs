using UnityEngine;

namespace AleVerDes
{
    public static class CameraEx
    {
        public static Rect GetRect(this Camera camera)
        {
            var verticalSize = camera.orthographicSize;
            var horizontalSize = verticalSize * Screen.width / Screen.height;

            var x = camera.transform.position.x;
            var y = camera.transform.position.y;

            return new()
            {
                xMin = x - horizontalSize,
                xMax = x + horizontalSize,
                yMin = y - verticalSize,
                yMax = y + verticalSize
            };
        }
    }
}