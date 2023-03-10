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

        public void BossHurtEffect(int currentHealth , Vector2 bossPos)
        {
            bossEffectHandler.BossHurtEffect(currentHealth , bossPos);
            Debug.Log($"BossHurt - currentHealth: {currentHealth} , bossPos: {bossPos}");
        }

    #endregion
    }
}