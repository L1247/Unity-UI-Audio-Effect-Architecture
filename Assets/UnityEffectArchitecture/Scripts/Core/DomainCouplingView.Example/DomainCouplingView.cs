#region

using TMPro;
using UnityEffectArchitecture.Core.Misc;
using UnityEngine;

#endregion

namespace UnityEffectArchitecture.Core
{
    public class DomainCouplingView : MonoBehaviour
    {
    #region Public Variables

        public int      Health           => health;
        public TMP_Text HealthAmountText => healthAmountText;

    #endregion

    #region Private Variables

        private IAudioSystem audioSystem;

        private IEffectSpawner effectSpawner;

        [SerializeField]
        private TMP_Text healthAmountText;

        [SerializeField]
        private int health = 100;

        [SerializeField]
        private AudioSystem audioSystemPrefab;

        [SerializeField]
        private EffectSpawner effectSpawnerPrefab;

    #endregion

    #region Unity events

        private void Start()
        {
            audioSystem   = Instantiate(audioSystemPrefab);
            effectSpawner = Instantiate(effectSpawnerPrefab);
        }

    #endregion

    #region Public Methods

        public void Init(IAudioSystem audioSystem , IEffectSpawner effectSpawner)
        {
            healthAmountText   = gameObject.AddComponent<TextMeshProUGUI>();
            this.audioSystem   = audioSystem;
            this.effectSpawner = effectSpawner;
        }

        public void TakeDamage()
        {
            health                = Health - 10;
            HealthAmountText.text = Health.ToString();
            audioSystem.PlayHurtAudio();
            effectSpawner.SpawnHurtEffect(gameObject);
        }

    #endregion
    }
}