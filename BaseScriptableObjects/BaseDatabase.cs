using System.Collections.Generic;
using AleVerDes.UnityUtils;
using UnityEngine;

namespace SunnyverseGames
{
    public abstract class BaseDatabase<T> : ScriptableObject where T : ScriptableObject
    {
        public T[] Elements;
        
        private Dictionary<T, ushort> _indexes;
        private Dictionary<string, T> _byNames;
        
        public void Reset()
        {
            if (!AssetDatabaseUtils.IsCreated(this))
            {
                return;
            }

            Elements = AssetDatabaseUtils.FindObjects<T>();
        }

        [ContextMenu("Reinitialize")]
        public void Reinitialize()
        {
            _indexes = null;
            _byNames = null;
        }

        public int GetIndexOf(string descriptorName)
        {
            return GetIndexOf(GetElementByName(descriptorName));
        }

        public int GetIndexOf(T descriptor)
        {
            if (_indexes == null)
            {
                _indexes = new Dictionary<T, ushort>();
                for (ushort i = 0; i < Elements.Length; i++)
                {
                    _indexes[Elements[i]] = i;
                }
            }

            return _indexes[descriptor];
        }

        public T GetElementByName(string itemName)
        {
            if (_byNames == null)
            {
                _byNames = new Dictionary<string, T>();
                for (ushort i = 0; i < Elements.Length; i++)
                {
                    _byNames[Elements[i].name] = Elements[i];
                }
            }

            return _byNames[itemName];
        }
    }
}