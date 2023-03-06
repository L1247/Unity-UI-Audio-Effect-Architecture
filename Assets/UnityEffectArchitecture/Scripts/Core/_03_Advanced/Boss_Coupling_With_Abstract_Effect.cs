#region

using UnityEffectArchitecture.General;
using UnityEngine;

#endregion

namespace UnityEffectArchitecture._03_Advanced
{
    public class Boss_Coupling_With_Abstract_Effect : BossBehavior
    {
    #region Public Variables

        public override int Health => health;

    #endregion

    #region Private Variables

        [SerializeField]
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