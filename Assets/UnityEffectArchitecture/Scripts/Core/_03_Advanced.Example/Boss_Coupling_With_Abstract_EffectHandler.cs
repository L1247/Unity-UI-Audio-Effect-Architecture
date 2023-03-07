#region

using UnityEffectArchitecture.General;
using Zenject;

#endregion

namespace UnityEffectArchitecture._03_Advanced
{
    public class Boss_Coupling_With_Abstract_EffectHandler : BossBehavior
    {
    #region Public Variables

        public override int Health => health;

    #endregion

    #region Private Variables

        private BossEffectHandler bossEffectHandler;

        private int health = 100;

    #endregion

    #region Public Methods

        [Inject]
        public void Construct(BossEffectHandler bossEffectHandler)
        {
            this.bossEffectHandler = bossEffectHandler;
        }

        public override void TakeDamage()
        {
        #region Domain Logic

            health = Health - 10;

        #endregion

        #region Defensive Programming , Do effect stuffs

            bossEffectHandler?.BossHurtEffect(Health , gameObject);

        #endregion
        }

    #endregion
    }
}