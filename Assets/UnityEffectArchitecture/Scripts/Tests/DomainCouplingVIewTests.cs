#region

using NSubstitute;
using NUnit.Framework;
using UnityEffectArchitecture.Core;
using UnityEffectArchitecture.Core.Misc;
using UnityEngine;

#endregion

public class DomainCouplingVIewTests
{
#region Test Methods

    [Test]
    public void Init()
    {
        var domainCouplingView = new GameObject().AddComponent<DomainCouplingView>();
        domainCouplingView.Init(Substitute.For<IAudioSystem>() , Substitute.For<IEffectSpawner>());
        Assert.IsNotNull(domainCouplingView.HealthAmountText);
        Assert.AreEqual(100 , domainCouplingView.Health);
    }

    [Test]
    public void TakeDamage()
    {
        var domainCouplingView = new GameObject().AddComponent<DomainCouplingView>();
        var audioSystem        = Substitute.For<IAudioSystem>();
        var effectSpawner      = Substitute.For<IEffectSpawner>();
        domainCouplingView.Init(audioSystem , effectSpawner);
        domainCouplingView.TakeDamage();
        Assert.AreEqual(90 , domainCouplingView.Health);
        Assert.AreEqual("90" , domainCouplingView.HealthAmountText.text);
        audioSystem.Received(1).PlayHurtAudio();
        effectSpawner.Received(1).SpawnHurtEffect(domainCouplingView.gameObject);
    }

#endregion
}