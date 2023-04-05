#region

using UnityEffectArchitecture._06_Facade.Example;
using UnityEngine;

#endregion

namespace UnityEffectArchitecture.General
{
    public class BossEffectHandlerForKnockBack : BossEffectHandler
    {
    #region Private Variables

        private readonly BossView          bossView;
        private readonly BossEffectHandler bossEffectHandler;

    #endregion

    #region Constructor

        public BossEffectHandlerForKnockBack(BossView bossView , BossEffectHandler bossEffectHandler)
        {
            this.bossEffectHandler = bossEffectHandler;
            this.bossView          = bossView;
        }

    #endregion

    #region Public Methods

        public void BossHurtEffect(int currentHealth , Vector2 bossPos)
        {
            bossView.Position = bossPos + Vector2.right;
            bossEffectHandler.BossHurtEffect(currentHealth , bossPos);
            // Position mapping way
            // bossEffectHandler.BossHurtEffect(currentHealth , bossView.Position);
        }

    #endregion
    }
}