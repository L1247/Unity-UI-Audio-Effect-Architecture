#region

using UnityEngine;

#endregion

namespace UnityEffectArchitecture.General
{
    public interface BossEffectHandler
    {
    #region Public Methods

        void BossHurtEffect(int currentHealth , GameObject boss);

    #endregion
    }
}