#region

using NSubstitute;
using NUnit.Framework;
using UnityEffectArchitecture._05_Master;
using UnityEffectArchitecture.General;
using UnityEngine;

#endregion

[TestFixture]
public class _05_MasterExampleTests
{
#region Test Methods

    [Test]
    public void Init()
    {
        var bossBehavior_With_Decorator = new GameObject().AddComponent<BossBehavior_With_Decorator>();
        Assert.AreEqual(100 , bossBehavior_With_Decorator.Health);
    }

    [Test]
    public void TakeDamage()
    {
        var audioSystem   = Substitute.For<IAudioSystem>();
        var bossUIPanel   = Substitute.For<IBossUIPanel>();
        var effectSpawner = Substitute.For<IEffectSpawner>();

        var bossEffectHandlerAudio  = new BossEffectHandler_Audio(audioSystem);
        var bossEffectHandlerUI     = new BossEffectHandler_UI(bossUIPanel , bossEffectHandlerAudio);
        var bossEffectHandlerEffect = new BossEffectHandler_Effect(effectSpawner , bossEffectHandlerUI);

        var bossBehavior_With_Decorator = new GameObject().AddComponent<BossBehavior_With_Decorator>();
        var bossPos                     = bossBehavior_With_Decorator.gameObject.transform.position;
        bossBehavior_With_Decorator.Construct(bossEffectHandlerEffect);

        bossBehavior_With_Decorator.TakeDamage();

        Assert.AreEqual(90 , bossBehavior_With_Decorator.Health);
        audioSystem.Received(1).PlayBossHurtAudio();
        bossUIPanel.Received(1).UpdateHealthUI(90);
        effectSpawner.Received(1).SpawnHurtEffect(bossPos);
    }

#endregion
}