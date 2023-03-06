#region

using NUnit.Framework;
using UnityEffectArchitecture._01_Beginner.Example;
using UnityEngine;

#endregion

[TestFixture]
public class _01_BeginnerExampleTests
{
#region Test Methods

    [Test]
    public void Init()
    {
        var allInOneBoss = new GameObject().AddComponent<AllInOneBoss>();
        Assert.AreEqual(100 , allInOneBoss.Health);
    }

    [Test]
    public void TakeDamage()
    {
        var allInOneBoss = new GameObject().AddComponent<AllInOneBoss>();
        allInOneBoss.TakeDamage();
        Assert.AreEqual(90 , allInOneBoss.Health);
    }

#endregion
}