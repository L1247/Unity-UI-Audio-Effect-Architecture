#region

using NUnit.Framework;
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
        var bossBehaviourWithMvp = new GameObject().AddComponent<BossBehaviour_With_MVP_Presenter>();
        bossBehaviourWithMvp.Init();

        bossBehaviourWithMvp.TakeDamage();

        Assert.AreEqual(90 , bossBehaviourWithMvp.Health);
    }

#endregion
}