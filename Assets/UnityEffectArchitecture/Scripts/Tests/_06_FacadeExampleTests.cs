#region

using NSubstitute;
using NUnit.Framework;
using UnityEffectArchitecture._06_Facade.Example;
using UnityEffectArchitecture.General;
using UnityEngine;

#endregion

[TestFixture]
public class _06_FacadeExampleTests
{
#region Test Methods

    [Test]
    public void Init()
    {
        var bossFacade = new GameObject().AddComponent<BossBehaviour_With_Facade>();
        Assert.AreEqual(100 , bossFacade.Health);
    }

    [Test]
    public void KnockBack_When_TakeDamage()
    {
        var bossView = new GameObject().AddComponent<BossView>();
        bossView.Position = new Vector2(0 , 0);
        var bossEffectHandlerForKnockBack = new BossEffectHandlerForKnockBack(bossView , Substitute.For<BossEffectHandler>());
        var bossFacade                    = new GameObject().AddComponent<BossBehaviour_With_Facade>();
        bossFacade.Construct(bossEffectHandlerForKnockBack);
        bossFacade.TakeDamage();
        Assert.AreEqual(new Vector2(1 , 0) , bossView.Position);
    }

    [Test]
    public void TakeDamage()
    {
        var bossFacade = new GameObject().AddComponent<BossBehaviour_With_Facade>();
        var bossPos    = bossFacade.gameObject.transform.position;

        var bossEffectHandlerEffect = Substitute.For<BossEffectHandler>();
        bossFacade.Construct(bossEffectHandlerEffect);
        bossFacade.TakeDamage();

        Assert.AreEqual(90 , bossFacade.Health);
        bossEffectHandlerEffect.Received(1).BossHurtEffect(90 , bossPos);
    }

#endregion
}