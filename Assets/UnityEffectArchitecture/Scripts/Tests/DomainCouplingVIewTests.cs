#region

using NUnit.Framework;
using UnityEffectArchitecture.Core;
using UnityEngine;

#endregion

public class DomainCouplingVIewTests
{
#region Test Methods

    [Test]
    public void Init()
    {
        var domainCouplingView = new GameObject().AddComponent<DomainCouplingView>();
        domainCouplingView.Init();
        Assert.IsNotNull(domainCouplingView.HealthAmountText);
        Assert.AreEqual(100 , domainCouplingView.Health);
    }

    [Test]
    public void TakeDamage()
    {
        var domainCouplingView = new GameObject().AddComponent<DomainCouplingView>();
        domainCouplingView.Init();
        domainCouplingView.TakeDamage();
        Assert.AreEqual(90 , domainCouplingView.Health);
        Assert.AreEqual("90" , domainCouplingView.HealthAmountText.text);
    }

#endregion
}