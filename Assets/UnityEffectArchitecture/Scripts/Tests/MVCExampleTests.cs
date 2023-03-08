#region

using NSubstitute;
using NUnit.Framework;
using UnityEffectArchitecture._MVC.Example;
using UnityEffectArchitecture.General;
using UnityEngine;

#endregion

[TestFixture]
public class MVCExampleTests
{
#region Test Methods

    [Test]
    public void Init()
    {
        var bossBehaviourWithMvc = new GameObject().AddComponent<BossBehaviour_With_MVC_Controller>();
        bossBehaviourWithMvc.Init();
        Assert.AreEqual(100 , bossBehaviourWithMvc.Health);
    }

    [Test]
    public void TakeDamage()
    {
        var audioSystem   = Substitute.For<IAudioSystem>();
        var effectSpawner = Substitute.For<IEffectSpawner>();
        var bossUIPanel   = Substitute.For<IBossUIPanel>();

        var bossBehaviourWithMvc = new GameObject().AddComponent<BossBehaviour_With_MVC_Controller>();
        bossBehaviourWithMvc.Init(audioSystem , effectSpawner , bossUIPanel);

        bossBehaviourWithMvc.TakeDamage();

        Assert.AreEqual(90 , bossBehaviourWithMvc.Health);

        bossUIPanel.Received(1).UpdateHealthUI(90);
        audioSystem.Received(1).PlayBossHurtAudio();
        effectSpawner.Received(1).SpawnHurtEffect(bossBehaviourWithMvc.gameObject);
    }

#endregion
}