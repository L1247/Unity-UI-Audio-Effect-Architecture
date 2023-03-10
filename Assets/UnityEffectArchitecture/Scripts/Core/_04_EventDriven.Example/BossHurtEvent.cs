#region

using rStarUtility.Generic.Infrastructure;
using UnityEngine;

#endregion

namespace UnityEffectArchitecture._04_EventDriven
{
    public class BossHurtEvent : DomainEvent
    {
    #region Public Variables

        public int CurrentHealth { get; }

        public Vector2 BossPos { get; }

    #endregion

    #region Constructor

        public BossHurtEvent(int currentHealth , Vector2 bossPos)
        {
            CurrentHealth = currentHealth;
            BossPos       = bossPos;
        }

    #endregion
    }
}