#region

using rStarUtility.Util.Extensions;
using UnityEffectArchitecture.General;
using UnityEngine;
using UnityEngine.UI;

#endregion

namespace UnityEffectArchitecture.Scripts.Core
{
    public class GameController : MonoBehaviour
    {
    #region Private Variables

        [SerializeReference]
        private BossBehavior bossBehavior;

        [SerializeField]
        private Button takeDamageButton;

    #endregion

    #region Unity events

        private void Start()
        {
            bossBehavior ??= FindFirstObjectByType<BossBehavior>();
            // Assert.IsNotNull(bossBehavior , "bossBehavior is null");
            if (bossBehavior == null) return;
            takeDamageButton.BindClick(() => bossBehavior.TakeDamage());
        }

    #endregion

    #region Private Methods

        private void OnValidate()
        {
            bossBehavior ??= FindFirstObjectByType<BossBehavior>();
        }

    #endregion
    }
}