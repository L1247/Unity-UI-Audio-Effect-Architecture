#region

using UnityEngine;

#endregion

namespace UnityEffectArchitecture.General
{
    public class BossEffectHandlerForAdvanced : BossEffectHandler
    {
    #region Private Variables

        private readonly IAudioSystem   audioSystem;
        private readonly IEffectSpawner effectSpawner;
        private readonly IBossUIPanel   bossUIPanel;

    #endregion

    #region Constructor

        public BossEffectHandlerForAdvanced(IAudioSystem audioSystem , IEffectSpawner effectSpawner , IBossUIPanel bossUIPanel)
        {
            this.audioSystem   = audioSystem;
            this.effectSpawner = effectSpawner;
            this.bossUIPanel   = bossUIPanel;
        }

    #endregion

    #region Public Methods

        public void OnTakeDamage(int currentHealth , GameObject boss)
        {
            bossUIPanel?.UpdateHealthUI(currentHealth);
            audioSystem?.PlayHurtAudio();
            effectSpawner?.SpawnHurtEffect(boss);
        }

    #endregion
    }
}