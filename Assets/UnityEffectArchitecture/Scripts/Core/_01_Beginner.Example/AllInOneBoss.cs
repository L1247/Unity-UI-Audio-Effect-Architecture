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
    #region Public Variables

        public override int Health => health;

    #endregion

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
        #region Domain Logic

            health -= 10;

        #endregion

        #region Defensive Programming , Do effect stuffs

            audioSource?.PlayOneShot(hurtClip);
            if (hurtEffect is not null) Instantiate(hurtEffect , gameObject.transform.position , Quaternion.identity);
            if (healthAmountText) healthAmountText.text = health.ToString();

        #endregion
        }

    #endregion
    }
}