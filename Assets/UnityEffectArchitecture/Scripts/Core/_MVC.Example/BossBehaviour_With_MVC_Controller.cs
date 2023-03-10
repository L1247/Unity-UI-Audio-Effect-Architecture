#region

using UnityEffectArchitecture.General;
using UnityEngine;

#endregion

namespace UnityEffectArchitecture._MVC.Example
{
    public class BossBehaviour_With_MVC_Controller : BossBehavior
    {
    #region Public Variables

        public override int Health => model.Health;

    #endregion

    #region Private Variables

        private Model model;

    #endregion

    #region Unity events

        private void Start()
        {
            Init();
        }

    #endregion

    #region Public Methods

        public void Init(IAudioSystem audioSystem = null , IEffectSpawner effectSpawner = null , IBossUIPanel bossUIPanel = null)
        {
            var view = new View(gameObject , audioSystem , effectSpawner , bossUIPanel);
            model = new Model(view);
        }

        public override void TakeDamage()
        {
            model.ReduceHealth(10);
        }

    #endregion
    }

    internal class View
    {
    #region Private Variables

        private readonly IAudioSystem audioSystem;

        private readonly IEffectSpawner effectSpawner;

        private readonly IBossUIPanel bossUIPanel;
        private readonly GameObject   gameObject;

    #endregion

    #region Constructor

        public View(GameObject gameObject , IAudioSystem audio_System , IEffectSpawner effect_Spawner , IBossUIPanel boss_UI_Panel)
        {
            this.gameObject = gameObject;
            bossUIPanel     = boss_UI_Panel ?? Object.FindFirstObjectByType<BossUIPanel>();
            audioSystem     = audio_System ?? Object.FindFirstObjectByType<AudioSystem>();
            effectSpawner   = effect_Spawner ?? Object.FindFirstObjectByType<EffectSpawner>();
        }

    #endregion

    #region Public Methods

        public void UpdateHealth(int health)
        {
            bossUIPanel.UpdateHealthUI(health);
            audioSystem.PlayBossHurtAudio();
            effectSpawner.SpawnHurtEffect(gameObject.transform.position);
        }

    #endregion
    }

    internal class Model
    {
    #region Public Variables

        public int Health { get; private set; }

    #endregion

    #region Private Variables

        private readonly View view;

    #endregion

    #region Constructor

        public Model(View view)
        {
            this.view = view;
            Health    = 100;
        }

    #endregion

    #region Public Methods

        public void ReduceHealth(int damage)
        {
            Health -= damage;
            view.UpdateHealth(Health);
        }

    #endregion
    }
}