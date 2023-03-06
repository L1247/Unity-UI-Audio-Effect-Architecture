#region

using TMPro;
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

        [SerializeField]
        private TMP_Text healthAmountText;

        [SerializeField]
        private int health = 100;

        [SerializeField]
        private AudioSource audioSource;

        [SerializeField]
        private AudioClip damageClip;

    #endregion

    #region Public Methods

        public void Init()
        {
            healthAmountText = gameObject.AddComponent<TextMeshProUGUI>();
        }

        public void TakeDamage()
        {
            health                = Health - 10;
            HealthAmountText.text = Health.ToString();
            audioSource.PlayOneShot(damageClip);
        }

    #endregion
    }
}