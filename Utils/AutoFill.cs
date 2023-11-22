using System;
using System.Linq;
using UnityEngine;
using Object = UnityEngine.Object;

#if UNITY_EDITOR
using UnityEditor.SceneManagement;
#endif

namespace AleVerDes.UnityUtils
{
    public static class AutoFill
    {
        public static void ForComponent<T>(ref T component, Type type) where T : Component
        {
#if UNITY_EDITOR
            if (PrefabStageUtility.GetCurrentPrefabStage() != null)
                component = (T) PrefabStageUtility
                    .GetCurrentPrefabStage()
                    .FindComponentsOfType<Transform>()
                    .FirstOrDefault(x => x.GetComponent(type))?
                    .GetComponent(type);
#endif
            component = (T) Object.FindObjectOfType(type);
        }
        
        public static void ForScriptableObject<T>(ref T scriptableObject, Type type) where T : ScriptableObject
        {
            scriptableObject = AssetDatabaseUtils.FindObject<T>();
        }
    }
}