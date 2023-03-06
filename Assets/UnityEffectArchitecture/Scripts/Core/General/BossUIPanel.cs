#region

using TMPro;
using UnityEngine;

#endregion

namespace UnityEffectArchitecture.General
{
    public interface IBossUIPanel
    {
    #region Public Methods

        void UpdateHealthUI(int healthAmount);

    #endregion
    }

    public class BossUIPanel : MonoBehaviour , IBossUIPanel
    {
    #region Private Variables

        [SerializeField]
        private TMP_Text healthAmountText;

    #endregion

    #region Public Methods

        public void UpdateHealthUI(int healthAmount)
        {
            healthAmountText.text = healthAmount.ToString();
        }

    #endregion
    }
}