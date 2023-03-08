#region

using UniRx;
using UnityEffectArchitecture.General;
using UnityEngine;

#endregion

namespace UnityEffectArchitecture.MVP.Example
{
    public class BossBehaviour_With_MVP_Presenter : BossBehavior
    {
    #region Public Variables

        public override int Health => model.CurrentHp.Value;

    #endregion

    #region Private Variables

        private Model model;
        private View  view;

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
            model = new Model();
            view  = new View(gameObject , audioSystem , effectSpawner , bossUIPanel);
            model.CurrentHp.Skip(1).Subscribe(hp => view.UpdateHealth(hp));
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

        public View(GameObject gameObject , IAudioSystem audio_System , IEffectSpawner effect_Spawner , IBossUIPanel boss_UIPanel)
        {
            this.gameObject = gameObject;
            bossUIPanel     = boss_UIPanel ?? Object.FindFirstObjectByType<BossUIPanel>();
            audioSystem     = audio_System ?? Object.FindFirstObjectByType<AudioSystem>();
            effectSpawner   = effect_Spawner ?? Object.FindFirstObjectByType<EffectSpawner>();
        }

    #endregion

    #region Public Methods

        public void UpdateHealth(int health)
        {
            bossUIPanel.UpdateHealthUI(health);
            audioSystem.PlayHurtAudio();
            effectSpawner.SpawnHurtEffect(gameObject);
        }

    #endregion
    }

    internal class Model
    {
    #region Public Variables

        public IntReactiveProperty CurrentHp { get; }

    #endregion

    #region Constructor

        public Model()
        {
            CurrentHp = new IntReactiveProperty(100);
        }

    #endregion

    #region Public Methods

        public void ReduceHealth(int damage)
        {
            CurrentHp.Value -= damage;
        }

    #endregion
    }
}