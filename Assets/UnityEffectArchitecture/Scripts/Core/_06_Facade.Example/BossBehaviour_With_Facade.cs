#region

using UnityEffectArchitecture.General;
using UnityEngine.Assertions;
using Zenject;

#endregion

namespace UnityEffectArchitecture._06_Facade.Example
{
    public class BossBehaviour_With_Facade : BossBehavior
    {
    #region Public Variables

        public override int Health => health;

    #endregion

    #region Private Variables

        private int               health = 100;
        private BossEffectHandler bossEffectHandlerEffect;

    #endregion

    #region Public Methods

        [Inject]
        public void Construct(BossEffectHandler bossEffectHandlerEffect)
        {
            this.bossEffectHandlerEffect = bossEffectHandlerEffect;
            Assert.IsNotNull(this.bossEffectHandlerEffect);
        }

        public override void TakeDamage()
        {
            health -= 10;
            bossEffectHandlerEffect.BossHurtEffect(Health , transform.position);
        }

    #endregion
    }
}