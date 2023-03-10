#region

using UnityEngine;

#endregion

namespace UnityEffectArchitecture.General
{
    public class BossEffectHandler_UI : BossEffectHandler
    {
    #region Private Variables

        private readonly IBossUIPanel      bossUIPanel;
        private readonly BossEffectHandler bossEffectHandler;

    #endregion

    #region Constructor

        public BossEffectHandler_UI(IBossUIPanel bossUIPanel , BossEffectHandler bossEffectHandler)
        {
            this.bossEffectHandler = bossEffectHandler;
            this.bossUIPanel       = bossUIPanel;
        }

    #endregion

    #region Public Methods

        public void BossHurtEffect(int currentHealth , Vector2 bossPos)
        {
            bossEffectHandler.BossHurtEffect(currentHealth , bossPos);
            bossUIPanel.UpdateHealthUI(currentHealth);
        }

    #endregion
    }
}