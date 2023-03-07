#region

using rStarUtility.Generic.Infrastructure;
using UnityEngine;

#endregion

namespace UnityEffectArchitecture._04_EventDriven
{
    public class BossHurtEvent : DomainEvent
    {
    #region Public Variables

        public GameObject GameObject    { get; }
        public int        CurrentHealth { get; }

    #endregion

    #region Constructor

        public BossHurtEvent(int currentHealth , GameObject gameObject)
        {
            CurrentHealth = currentHealth;
            GameObject    = gameObject;
        }

    #endregion
    }
}