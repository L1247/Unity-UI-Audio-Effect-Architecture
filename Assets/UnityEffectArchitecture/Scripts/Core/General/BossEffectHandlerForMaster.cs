#region

using UnityEngine;

#endregion

namespace UnityEffectArchitecture.General
{
    public class BossEffectHandler_Audio : BossEffectHandler
    {
    #region Private Variables

        private readonly IAudioSystem      audioSystem;
        private readonly BossEffectHandler bossEffectHandler;

    #endregion

    #region Constructor

        public BossEffectHandler_Audio(BossEffectHandler bossEffectHandler , IAudioSystem audioSystem)
        {
            this.bossEffectHandler = bossEffectHandler;
            this.audioSystem       = audioSystem;
        }

    #endregion

    #region Public Methods

        public void BossHurtEffect(int currentHealth , GameObject boss)
        {
            bossEffectHandler.BossHurtEffect(currentHealth , boss);
            audioSystem.PlayHurtAudio();
        }

    #endregion
    }

    public class BossEffectHandler_UI : BossEffectHandler
    {
    #region Private Variables

        private readonly IBossUIPanel bossUIPanel;

    #endregion

    #region Constructor

        public BossEffectHandler_UI(IBossUIPanel bossUIPanel)
        {
            this.bossUIPanel = bossUIPanel;
        }

    #endregion

    #region Public Methods

        public void BossHurtEffect(int currentHealth , GameObject boss)
        {
            bossUIPanel.UpdateHealthUI(currentHealth);
        }

    #endregion
    }
}