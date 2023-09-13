using System;
using UnityEngine;

namespace AffenCode
{
    public static class TransformEx
    {
        public static Transform FindRecursive(this Transform self, string exactName) => self.FindRecursive(child => child.name == exactName);

        public static Transform FindRecursive(this Transform self, Predicate<Transform> selector)
        {
            foreach (Transform child in self)
            {
                if (selector(child))
                {
                    return child;
                }

                var finding = child.FindRecursive(selector);

                if (finding != null)
                {
                    return finding;
                }
            }

            return null;
        }

        public static void ResetPosition(this Transform self)
        {
            self.localPosition = Vector3.zero;
        }

        public static void ResetRotation(this Transform self)
        {
            self.localPosition = Vector3.zero;
        }

        public static void ResetScale(this Transform self)
        {
            self.localPosition = Vector3.zero;
        }

        public static void Reset(this Transform self)
        {
            self.localPosition = Vector3.zero;
            self.localRotation = Quaternion.identity;
            self.localScale = Vector3.one;
        }
    }
}