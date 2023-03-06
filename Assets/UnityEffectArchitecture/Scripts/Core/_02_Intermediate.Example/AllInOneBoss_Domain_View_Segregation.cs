#region

using UnityEffectArchitecture.General;
using UnityEngine;

#endregion

namespace UnityEffectArchitecture._02_Intermediate
{
    /// <summary>
    ///     interfaces and testable
    /// </summary>
    public class AllInOneBoss_Domain_View_Segregation : BossBehavior
    {
    #region Public Variables

        public int Health => health;

    #endregion

    #region Private Variables

        private IAudioSystem audioSystem;

        private IEffectSpawner effectSpawner;

        private IBossUIPanel bossUIPanel;

        [SerializeField]
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
        }

        public override void TakeDamage()
        {
            health = Health - 10;
            bossUIPanel.UpdateHealthUI(health);
            audioSystem.PlayHurtAudio();
            effectSpawner.SpawnHurtEffect(gameObject);
        }

    #endregion
    }
}