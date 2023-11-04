#region

using UnityEffectArchitecture.General;
using UnityEngine;

#endregion

namespace UnityEffectArchitecture.Scripts.Core._MVP_New.Example
{
    public class MVP_New_Presenter : MonoBehaviour
    {
    #region Private Variables

        [SerializeField]
        private MVP_New_Model model;

        [SerializeField]
        private TakeDamageUI takeDamageUI;

        [SerializeField]
        private BossUIPanel bossUIPanel;

    #endregion

    #region Unity events

        private void Awake()
        {
            model.HealthChanged               += currentHealth => bossUIPanel.UpdateHealthUI(currentHealth);
            takeDamageUI.takeDamageBtnClicked += () => model.TakeDamage();
        }

    #endregion
    }
}