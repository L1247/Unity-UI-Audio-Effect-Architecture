#region

using NUnit.Framework;
using UnityEffectArchitecture._05_Master;
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
        var bossBehavior_With_Decorator = new GameObject().AddComponent<BossBehavior_With_Decorator>();

        bossBehavior_With_Decorator.TakeDamage();

        Assert.AreEqual(90 , bossBehavior_With_Decorator.Health);
    }

#endregion
}