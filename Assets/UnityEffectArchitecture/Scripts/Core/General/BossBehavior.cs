#region

using System;
using UnityEngine;

#endregion

namespace UnityEffectArchitecture.General
{
    [Serializable]
    public abstract class BossBehavior : MonoBehaviour
    {
    #region Private Variables

        private int Health { get; }

    #endregion

    #region Public Methods

        public abstract void TakeDamage();

    #endregion
    }
}