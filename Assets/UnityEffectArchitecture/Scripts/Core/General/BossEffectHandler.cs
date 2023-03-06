#region

using UnityEngine;

#endregion

namespace UnityEffectArchitecture.General
{
    public interface BossEffectHandler
    {
    #region Public Methods

        void OnTakeDamage(int currentHealth , GameObject boss);

    #endregion
    }
}