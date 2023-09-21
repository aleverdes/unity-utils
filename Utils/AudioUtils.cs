using UnityEngine;

namespace AleVerDes
{
    public static class AudioUtils
    {
        public const string AudioMixerMasterVolumeParameter = "MasterVolume";
        public const string AudioMixerSoundVolumeParameter = "SoundVolume";
        public const string AudioMixerMusicVolumeParameter = "MusicVolume";
        public const string AudioMixerVoiceChatVolumeParameter = "VoiceChatVolume";
        
        public static float ConvertValueToVolume(float value, float volumeModifier = 1f)
        {
            if (value <= FloatEpsilon.Value)
            {
                return -80f;
            }

            return Mathf.Log10(value * volumeModifier) * 20f;
        }
    }
}