#region

using UnityEngine;

#endregion

namespace UnityEffectArchitecture.General
{
    public interface IEffectSpawner
    {
    #region Public Methods

        void SpawnHurtEffect(Vector2 pos);

    #endregion
    }

    public class EffectSpawner : MonoBehaviour , IEffectSpawner
    {
    #region Private Variables

        [SerializeField]
        private GameObject hurtEffect;

    #endregion

    #region Public Methods

        public void SpawnHurtEffect(Vector2 pos)
        {
            Instantiate((Object)hurtEffect , pos , Quaternion.identity);
        }

    #endregion
    }
}