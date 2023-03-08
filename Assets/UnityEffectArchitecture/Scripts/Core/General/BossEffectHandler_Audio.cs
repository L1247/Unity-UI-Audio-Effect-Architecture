#region

using UnityEngine;

#endregion

namespace UnityEffectArchitecture.General
{
    public class BossEffectHandler_Audio : BossEffectHandler
    {
    #region Private Variables

        private readonly IAudioSystem audioSystem;

    #endregion

    #region Constructor

        public BossEffectHandler_Audio(IAudioSystem audioSystem)
        {
            this.audioSystem = audioSystem;
        }

    #endregion

    #region Public Methods

        public void BossHurtEffect(int currentHealth , GameObject boss)
        {
            audioSystem.PlayBossHurtAudio();
        }

    #endregion
    }
}