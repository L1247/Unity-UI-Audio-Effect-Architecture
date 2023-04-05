#region

using UnityEngine;

#endregion

namespace UnityEffectArchitecture._06_Facade.Example
{
    public class BossView : MonoBehaviour
    {
    #region Public Variables

        public Vector2 Position
        {
            get => transform.position;
            set => transform.position = value;
        }

    #endregion
    }
}