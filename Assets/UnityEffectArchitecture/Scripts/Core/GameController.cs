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

        [SerializeField]
        private AudioSystem audioSystemPrefab;

        [SerializeField]
        private EffectSpawner effectSpawnerPrefab;

    #endregion

    #region Unity events

        private void Awake()
        {
            Instantiate(audioSystemPrefab);
            Instantiate(effectSpawnerPrefab);
        }

        private void Start()
        {
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