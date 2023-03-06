#region

using UnityEngine;

#endregion

namespace UnityEffectArchitecture.Core.Misc
{
    public class HurtEffect : MonoBehaviour
    {
    #region Private Variables

        [SerializeField]
        private AnimationClip clip;

    #endregion

    #region Unity events

        private void Start()
        {
            Destroy(gameObject , clip.length);
        }

    #endregion
    }
}