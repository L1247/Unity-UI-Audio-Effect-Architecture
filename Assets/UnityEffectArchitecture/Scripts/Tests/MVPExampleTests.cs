#region

using NSubstitute;
using NUnit.Framework;
using UnityEffectArchitecture.General;
using UnityEffectArchitecture.MVP.Example;
using UnityEngine;

#endregion

[TestFixture]
public class MVPExampleTests
{
#region Test Methods

    [Test]
    public void Init()
    {
        var bossBehaviourWithMvp = new GameObject().AddComponent<BossBehaviour_With_MVP_Presenter>();
        bossBehaviourWithMvp.Init();
        Assert.AreEqual(100 , bossBehaviourWithMvp.Health);
    }

    [Test]
    public void TakeDamage()
    {
        var audioSystem   = Substitute.For<IAudioSystem>();
        var effectSpawner = Substitute.For<IEffectSpawner>();
        var bossUIPanel   = Substitute.For<IBossUIPanel>();

        var bossBehaviourWithMvp = new GameObject().AddComponent<BossBehaviour_With_MVP_Presenter>();
        bossBehaviourWithMvp.Init(audioSystem , effectSpawner , bossUIPanel);

        bossBehaviourWithMvp.TakeDamage();

        Assert.AreEqual(90 , bossBehaviourWithMvp.Health);

        bossUIPanel.Received(1).UpdateHealthUI(90);
        audioSystem.Received(1).PlayHurtAudio();
        effectSpawner.Received(1).SpawnHurtEffect(bossBehaviourWithMvp.gameObject);
    }

#endregion
}