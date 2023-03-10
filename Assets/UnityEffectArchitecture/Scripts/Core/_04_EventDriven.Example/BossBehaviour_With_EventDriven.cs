#region

using rStarUtility.Generic.Infrastructure;
using UnityEffectArchitecture.General;
using Zenject;

#endregion

namespace UnityEffectArchitecture._04_EventDriven
{
    public class BossBehaviour_With_EventDriven : BossBehavior
    {
    #region Public Variables

        public override int Health => health;

    #endregion

    #region Private Variables

        private IDomainEventBus domainEventBus;

        private int health = 100;

    #endregion

    #region Public Methods

        [Inject]
        public void Construct(IDomainEventBus domainEventBus)
        {
            this.domainEventBus = domainEventBus;
        }

        public override void TakeDamage()
        {
            health -= 10;
            domainEventBus.Post(new BossHurtEvent(health , transform.position));
        }

    #endregion
    }
}