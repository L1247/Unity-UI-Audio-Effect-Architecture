#region

using NSubstitute;
using NUnit.Framework;
using UnityEffectArchitecture._02_Intermediate;
using UnityEffectArchitecture.General;
using UnityEngine;

#endregion

public class _02_IntermediateExampleTests
{
#region Test Methods

    [Test]
    public void Init()
    {
        var domainCouplingView = new GameObject().AddComponent<AllInOneBoss_Domain_View_Segregation>();
        Assert.AreEqual(100 , domainCouplingView.Health);
    }

    [Test]
    public void TakeDamage()
    {
        var domainCouplingView = new GameObject().AddComponent<AllInOneBoss_Domain_View_Segregation>();
        var bossPos            = domainCouplingView.gameObject.transform.position;
        var audioSystem        = Substitute.For<IAudioSystem>();
        var effectSpawner      = Substitute.For<IEffectSpawner>();
        var bossUIPanel        = Substitute.For<IBossUIPanel>();
        domainCouplingView.Init(bossUIPanel , audioSystem , effectSpawner);

        domainCouplingView.TakeDamage();

        Assert.AreEqual(90 , domainCouplingView.Health);
        bossUIPanel.Received(1).UpdateHealthUI(90);
        audioSystem.Received(1).PlayBossHurtAudio();
        effectSpawner.Received(1).SpawnHurtEffect(bossPos);
    }

#endregion
}