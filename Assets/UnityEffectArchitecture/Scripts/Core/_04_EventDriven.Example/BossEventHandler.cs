#region

using rStarUtility.Generic.Infrastructure;
using UnityEffectArchitecture.General;

#endregion

namespace UnityEffectArchitecture._04_EventDriven
{
    public class BossEventHandler : DomainEventHandler
    {
    #region Private Variables

        private readonly BossEffectHandler bossEffectHandler;

    #endregion

    #region Constructor

        public BossEventHandler(IDomainEventBus domainEventBus , BossEffectHandler bossEffectHandler) : base(domainEventBus)
        {
            this.bossEffectHandler = bossEffectHandler;
            domainEventBus.Register<BossHurtEvent>(OnBossHurt);
        }

    #endregion

    #region Private Methods

        private void OnBossHurt(BossHurtEvent hurtEvent)
        {
            bossEffectHandler.BossHurtEffect(hurtEvent.CurrentHealth , hurtEvent.GameObject);
        }

    #endregion
    }
}