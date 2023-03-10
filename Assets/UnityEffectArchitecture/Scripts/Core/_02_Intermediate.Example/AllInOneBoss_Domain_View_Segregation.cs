#region

using UnityEffectArchitecture.General;
using UnityEngine.Assertions;

#endregion

namespace UnityEffectArchitecture._02_Intermediate
{
    /// <summary>
    ///     interfaces and testable
    /// </summary>
    public class AllInOneBoss_Domain_View_Segregation : BossBehavior
    {
    #region Public Variables

        public override int Health => health;

    #endregion

    #region Private Variables

        private IAudioSystem audioSystem;

        private IEffectSpawner effectSpawner;

        private IBossUIPanel bossUIPanel;

        private int health = 100;

    #endregion

    #region Unity events

        private void Start()
        {
            Init(FindFirstObjectByType<BossUIPanel>() ,
                 FindFirstObjectByType<AudioSystem>() ,
                 FindFirstObjectByType<EffectSpawner>());
        }

    #endregion

    #region Public Methods

        public void Init(IBossUIPanel bossUIPanel , IAudioSystem audioSystem , IEffectSpawner effectSpawner)
        {
            this.bossUIPanel   = bossUIPanel;
            this.audioSystem   = audioSystem;
            this.effectSpawner = effectSpawner;
            Assert.IsNotNull(this.bossUIPanel);
            Assert.IsNotNull(this.audioSystem);
            Assert.IsNotNull(this.effectSpawner);
        }

        public override void TakeDamage()
        {
        #region Domain Logic

            health = Health - 10;

        #endregion

        #region Defensive Programming , Do effect stuffs

            bossUIPanel.UpdateHealthUI(health);
            audioSystem.PlayBossHurtAudio();
            effectSpawner.SpawnHurtEffect(transform.position);

        #endregion
        }

    #endregion
    }
}