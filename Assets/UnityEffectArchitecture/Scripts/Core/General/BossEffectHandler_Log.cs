#region

using UnityEngine;

#endregion

namespace UnityEffectArchitecture.General
{
    public class BossEffectHandler_Log : BossEffectHandler
    {
    #region Private Variables

        private readonly BossEffectHandler bossEffectHandler;

    #endregion

    #region Constructor

        public BossEffectHandler_Log(BossEffectHandler bossEffectHandler)
        {
            this.bossEffectHandler = bossEffectHandler;
        }

    #endregion

    #region Public Methods

        public void BossHurtEffect(int currentHealth , GameObject boss)
        {
            bossEffectHandler.BossHurtEffect(currentHealth , boss);
            Debug.Log($"BossHurt - currentHealth: {currentHealth} , boss: {boss}");
        }

    #endregion
    }
}