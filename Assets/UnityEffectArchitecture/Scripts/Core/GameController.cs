#region

using rStarUtility.Util.Extensions;
using UnityEffectArchitecture.Core;
using UnityEngine;
using UnityEngine.UI;

#endregion

namespace UnityEffectArchitecture.Scripts.Core
{
    public class GameController : MonoBehaviour
    {
    #region Private Variables

        [SerializeField]
        private DomainCouplingView domainCouplingView;

        [SerializeField]
        private Button takeDamageButton;

    #endregion

    #region Unity events

        private void Start()
        {
            takeDamageButton.BindClick(() => domainCouplingView.TakeDamage());
        }

    #endregion
    }
}