#region

using TMPro;
using UnityEffectArchitecture.General;
using UnityEngine;

#endregion

namespace UnityEffectArchitecture._01_Beginner.Example
{
    /// <summary>
    ///     unable to unittest , only manual testing
    /// </summary>
    public class AllInOneBoss : BossBehavior
    {
    #region Private Variables

        private AudioSource audioSource;

        [SerializeField]
        private int health = 100;

        [SerializeField]
        private AudioClip hurtClip;

        [SerializeField]
        private TMP_Text healthAmountText;

        [SerializeField]
        private GameObject hurtEffect;

    #endregion

    #region Unity events

        private void Start()
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

    #endregion

    #region Public Methods

        public override void TakeDamage()
        {
            health -= 10;
            audioSource.PlayOneShot(hurtClip);
            Instantiate(hurtEffect , gameObject.transform.position , Quaternion.identity);
            healthAmountText.text = health.ToString();
        }

    #endregion
    }
}