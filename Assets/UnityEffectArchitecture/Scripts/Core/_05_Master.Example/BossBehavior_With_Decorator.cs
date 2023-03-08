#region

using UnityEffectArchitecture.General;
using Zenject;

#endregion

namespace UnityEffectArchitecture._05_Master
{
    public class BossBehavior_With_Decorator : BossBehavior
    {
    #region Public Variables

        public override int Health => health;

    #endregion

    #region Private Variables

        private int               health = 100;
        private BossEffectHandler bossEffectHandler;

    #endregion

    #region Public Methods

        [Inject]
        public void Construct(BossEffectHandler bossEffectHandler)
        {
            this.bossEffectHandler = bossEffectHandler;
        }

        public override void TakeDamage()
        {
            health -= 10;
            bossEffectHandler.BossHurtEffect(health , gameObject);
        }

    #endregion
    }
}