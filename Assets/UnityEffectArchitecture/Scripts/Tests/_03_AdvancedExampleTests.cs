#region

using NSubstitute;
using NUnit.Framework;
using UnityEffectArchitecture._03_Advanced;
using UnityEffectArchitecture.General;
using UnityEngine;

#endregion

[TestFixture]
public class _03_AdvancedExampleTests
{
#region Test Methods

    [Test]
    public void Init()
    {
        var bossCouplingWithAbstractEffect = new GameObject().AddComponent<Boss_Coupling_With_Abstract_EffectHandler>();
        Assert.AreEqual(100 , bossCouplingWithAbstractEffect.Health);
    }

    [Test]
    public void TakeDamage()
    {
        var bossCouplingWithAbstractEffect = new GameObject().AddComponent<Boss_Coupling_With_Abstract_EffectHandler>();
        var bossPos                        = bossCouplingWithAbstractEffect.gameObject.transform.position;
        var bossEffectHandler              = Substitute.For<BossEffectHandler>();
        bossCouplingWithAbstractEffect.Construct(bossEffectHandler);
        bossCouplingWithAbstractEffect.TakeDamage();
        Assert.AreEqual(90 , bossCouplingWithAbstractEffect.Health);
        bossEffectHandler.Received(1).BossHurtEffect(90 , bossPos);
    }

#endregion
}