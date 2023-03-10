#region

using UnityEngine;

#endregion

namespace UnityEffectArchitecture.General
{
    public class BossEffectHandler_Effect : BossEffectHandler
    {
    #region Private Variables

        private readonly IEffectSpawner    effectSpawner;
        private readonly BossEffectHandler bossEffectHandler;

    #endregion

    #region Constructor

        public BossEffectHandler_Effect(IEffectSpawner effectSpawner , BossEffectHandler bossEffectHandler)
        {
            this.effectSpawner     = effectSpawner;
            this.bossEffectHandler = bossEffectHandler;
        }

    #endregion

    #region Public Methods

        public void BossHurtEffect(int currentHealth , Vector2 bossPos)
        {
            bossEffectHandler.BossHurtEffect(currentHealth , bossPos);
            effectSpawner.SpawnHurtEffect(bossPos);
        }

    #endregion
    }
}