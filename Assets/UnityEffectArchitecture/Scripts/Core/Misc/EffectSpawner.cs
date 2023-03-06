#region

using UnityEngine;

#endregion

namespace UnityEffectArchitecture.Core.Misc
{
    public interface IEffectSpawner
    {
    #region Public Methods

        void SpawnHurtEffect(GameObject go);

    #endregion
    }

    public class EffectSpawner : MonoBehaviour , IEffectSpawner
    {
    #region Private Variables

        [SerializeField]
        private GameObject hurtEffect;

    #endregion

    #region Public Methods

        public void SpawnHurtEffect(GameObject go)
        {
            Instantiate((Object)hurtEffect , go.transform.position , Quaternion.identity);
        }

    #endregion
    }
}