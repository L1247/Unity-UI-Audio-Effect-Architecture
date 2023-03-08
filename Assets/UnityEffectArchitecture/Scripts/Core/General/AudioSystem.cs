#region

using UnityEngine;

#endregion

namespace UnityEffectArchitecture.General
{
    public interface IAudioSystem
    {
    #region Public Methods

        void PlayBossHurtAudio();

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

        public void PlayBossHurtAudio()
        {
            audioSource.PlayOneShot(damageClip);
        }

    #endregion
    }
}