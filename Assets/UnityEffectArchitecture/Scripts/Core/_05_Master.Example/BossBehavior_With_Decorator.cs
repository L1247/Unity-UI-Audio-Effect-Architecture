#region

using UnityEffectArchitecture.General;

#endregion

namespace UnityEffectArchitecture._05_Master
{
    public class BossBehavior_With_Decorator : BossBehavior
    {
    #region Public Variables

        public override int Health => health;

    #endregion

    #region Private Variables

        private int health = 100;

    #endregion

    #region Public Methods

        public override void TakeDamage()
        {
            health -= 10;
        }

    #endregion
    }
}