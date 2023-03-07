#region

using NSubstitute;
using NUnit.Framework;
using rStarUtility.Generic.Infrastructure;
using UnityEffectArchitecture._04_EventDriven;
using UnityEngine;

#endregion

[TestFixture]
public class _04_EventDrivenExampleTests
{
#region Test Methods

    [Test]
    public void Init()
    {
        var bossBehaviourWithEventDriven = new GameObject().AddComponent<BossBehaviour_With_EventDriven>();
        Assert.AreEqual(100 , bossBehaviourWithEventDriven.Health);
    }

    [Test]
    public void TakeDamage()
    {
        var bossBehaviourWithEventDriven = new GameObject().AddComponent<BossBehaviour_With_EventDriven>();
        var domainEventBus               = Substitute.For<IDomainEventBus>();
        bossBehaviourWithEventDriven.Construct(domainEventBus);
        BossHurtEvent bossHurtEvent = null;
        domainEventBus.Post(Arg.Do<BossHurtEvent>(evt => bossHurtEvent = evt));

        bossBehaviourWithEventDriven.TakeDamage();

        Assert.AreEqual(90 , bossBehaviourWithEventDriven.Health);

        domainEventBus.Received(1).Post(Arg.Is<DomainEvent>(d => d.GetType() == typeof(BossHurtEvent)));
        Assert.NotNull(bossHurtEvent);
        Assert.AreEqual(90 , bossHurtEvent.CurrentHealth);
        Assert.AreEqual(bossBehaviourWithEventDriven.gameObject , bossHurtEvent.GameObject);
    }

#endregion
}