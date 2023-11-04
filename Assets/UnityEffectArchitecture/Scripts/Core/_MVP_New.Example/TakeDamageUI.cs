#region

using rStarUtility.Util.Extensions;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#endregion

namespace UnityEffectArchitecture.Scripts.Core._MVP_New.Example
{
    public class TakeDamageUI : MonoBehaviour
    {
    #region Public Variables

        public UnityAction takeDamageBtnClicked;

    #endregion

    #region Private Variables

        [SerializeField]
        private Button takeDamageBtn;

    #endregion

    #region Unity events

        private void Start()
        {
            // raise takeDamageBtnClicked 
            takeDamageBtn.BindClick(() => takeDamageBtnClicked?.Invoke());
        }

    #endregion
    }
}