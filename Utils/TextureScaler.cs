using UnityEngine;

namespace AleVerDes.UnityUtils
{
    public static class TextureScaler
    {
        /// <summary>
        /// Returns a scaled copy of given texture.
        /// </summary>
        /// <param name="source">Source texture to scale</param>
        /// <param name="width">Destination texture width</param>
        /// <param name="height">Destination texture height</param>
        /// <param name="mode">Filtering mode</param>
        public static Texture2D Scale(Texture2D source, int width, int height, FilterMode mode = FilterMode.Trilinear)
        {
            Rect textureRect = new(0, 0, width, height);
            ScaleTexture(source, width, height, mode);

            Texture2D result = new(width, height, TextureFormat.ARGB32, true);
            result.Reinitialize(width, height);
            result.ReadPixels(textureRect, 0, 0, true);
            return result;
        }
 
        /// <summary>
        /// Scales the texture data of the given texture.
        /// </summary>
        /// <param name="texture">Texure to scale</param>
        /// <param name="width">New width</param>
        /// <param name="height">New height</param>
        /// <param name="mode">Filtering mode</param>
        public static void Rescale(this Texture2D texture, int width, int height, FilterMode mode = FilterMode.Trilinear)
        {
            Rect textureRect = new(0, 0, width, height);
            ScaleTexture(texture, width, height, mode);
 
            texture.Reinitialize(width, height);
            texture.ReadPixels(textureRect, 0, 0, true);
            texture.Apply(true);
        }

        private static void ScaleTexture(Texture2D source, int width, int height, FilterMode filterMode)
        {
            source.filterMode = filterMode;
            source.Apply(true);

            RenderTexture rtt = new(width, height, 32);

            Graphics.SetRenderTarget(rtt);

            GL.LoadPixelMatrix(0, 1, 1, 0);
            GL.Clear(true, true, Color.clear);
            Graphics.DrawTexture(new Rect(0, 0, 1, 1), source);
        }
    }
}