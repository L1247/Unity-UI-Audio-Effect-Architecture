#region

using NUnit.Framework;
using UnityEffectArchitecture._03_Advanced;
using UnityEngine;

#endregion

[TestFixture]
public class _03_AdvancedExampleTests
{
#region Test Methods

    [Test]
    public void Init()
    {
        var bossCouplingWithAbstractEffect = new GameObject().AddComponent<Boss_Coupling_With_Abstract_Effect>();
        Assert.AreEqual(100 , bossCouplingWithAbstractEffect.Health);
    }

    [Test]
    public void TakeDamage()
    {
        var bossCouplingWithAbstractEffect = new GameObject().AddComponent<Boss_Coupling_With_Abstract_Effect>();
        bossCouplingWithAbstractEffect.TakeDamage();
        Assert.AreEqual(90 , bossCouplingWithAbstractEffect.Health);
    }

#endregion
}