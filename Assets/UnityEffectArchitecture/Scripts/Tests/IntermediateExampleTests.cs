#region

using NSubstitute;
using NUnit.Framework;
using UnityEffectArchitecture._02_Intermediate;
using UnityEffectArchitecture.General;
using UnityEngine;

#endregion

public class IntermediateExampleTests
{
#region Test Methods

    [Test]
    public void Init()
    {
        var domainCouplingView = new GameObject().AddComponent<DomainCouplingView>();
        Assert.AreEqual(100 , domainCouplingView.Health);
    }

    [Test]
    public void TakeDamage()
    {
        var domainCouplingView = new GameObject().AddComponent<DomainCouplingView>();
        var audioSystem        = Substitute.For<IAudioSystem>();
        var effectSpawner      = Substitute.For<IEffectSpawner>();
        var bossUIPanel        = Substitute.For<IBossUIPanel>();
        domainCouplingView.Init(bossUIPanel , audioSystem , effectSpawner);

        domainCouplingView.TakeDamage();

        Assert.AreEqual(90 , domainCouplingView.Health);
        bossUIPanel.Received(1).UpdateHealthUI(90);
        audioSystem.Received(1).PlayHurtAudio();
        effectSpawner.Received(1).SpawnHurtEffect(domainCouplingView.gameObject);
    }

#endregion
}