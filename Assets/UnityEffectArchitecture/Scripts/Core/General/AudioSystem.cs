#region

using UnityEngine;

#endregion

namespace UnityEffectArchitecture.General
{
    public interface IAudioSystem
    {
    #region Public Methods

        void PlayHurtAudio();

    #endregion
    }

    public class AudioSystem : MonoBehaviour , IAudioSystem
    {
    #region Private Variables

        [SerializeField]
        private AudioSource audioSource;

        [SerializeField]
        private AudioClip damageClip;

    #endregion

    #region Public Methods

        public void PlayHurtAudio()
        {
            audioSource.PlayOneShot(damageClip);
        }

    #endregion
    }
}