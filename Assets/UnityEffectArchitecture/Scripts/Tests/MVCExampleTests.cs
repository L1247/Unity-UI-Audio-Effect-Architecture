#region

using NUnit.Framework;
using UnityEffectArchitecture.Scripts.Core._MVC.Example;
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
        var bossBehaviourWithMvc = new GameObject().AddComponent<BossBehaviour_With_MVC_Controller>();
        bossBehaviourWithMvc.Init();

        bossBehaviourWithMvc.TakeDamage();

        Assert.AreEqual(90 , bossBehaviourWithMvc.Health);
    }

#endregion
}