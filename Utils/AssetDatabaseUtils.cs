using System;
using UnityEngine;
using Object = UnityEngine.Object;
using System.IO;

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace AleVerDes
{
    public static class AssetDatabaseUtils
    {
        public static bool IsCreated(ScriptableObject so)
        {
#if UNITY_EDITOR
            return !string.IsNullOrEmpty(AssetDatabase.GetAssetPath(so));
#endif
            return false;
        }

        public static T FindObjectByName<T>(string name) where T : Object
        {
#if UNITY_EDITOR
            var assetGuids = AssetDatabase.FindAssets("t:" + typeof(T).Name);
            foreach (var assetGuid in assetGuids)
            {
                var path = AssetDatabase.GUIDToAssetPath(assetGuid);
                var assetName = Path.GetFileNameWithoutExtension(path);
                if (string.Equals(assetName, name, StringComparison.InvariantCultureIgnoreCase))
                {
                    return AssetDatabase.LoadAssetAtPath<T>(path);
                }
            }
            return null;
#endif
            return null;
        }

        public static T FindObject<T>(string folder = null) where T : Object
        {
#if UNITY_EDITOR
            var assetGuids = string.IsNullOrEmpty(folder) 
                ? AssetDatabase.FindAssets("t:" + typeof(T).Name)  
                : AssetDatabase.FindAssets("t:" + typeof(T).Name, new []{folder});
            foreach (var assetGuid in assetGuids)
            {
                return AssetDatabase.LoadAssetAtPath<T>(AssetDatabase.GUIDToAssetPath(assetGuid));
            }
            return null;
#endif
            return null;
        }

        public static T[] FindObjects<T>(string folder = null) where T : Object
        {
#if UNITY_EDITOR
            var assetGuids = string.IsNullOrEmpty(folder) 
                ? AssetDatabase.FindAssets("t:" + typeof(T).Name) 
                : AssetDatabase.FindAssets("t:" + typeof(T).Name, new []{folder});
            
            var assets = new T[assetGuids.Length];
            for (var i = 0; i < assetGuids.Length; i++)
            {
                var assetGuid = assetGuids[i];
                assets[i] = AssetDatabase.LoadAssetAtPath<T>(AssetDatabase.GUIDToAssetPath(assetGuid));
            }
            return assets;
#endif
            return Array.Empty<T>();
        }

        public static string GetAssetFolder(ScriptableObject scriptableObject)
        {
#if UNITY_EDITOR
            return Path.GetDirectoryName(AssetDatabase.GetAssetPath(scriptableObject));
#endif
            return null;
        }
    }
}