using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class AxeTests
    {
        private int attackPoints;
        private int durabilityPoints;
        private Axe axe;
        private Dummy dummy;

        [SetUp]
        public void SetUp()
        {
            attackPoints = 10;
            durabilityPoints = 10;
            axe = new Axe(attackPoints, durabilityPoints);
            dummy = new Dummy(100, 100);

        }
        [Test]
        public void ConstructorShouldSetDataProperly()
        {
           Assert.AreEqual(10, axe.AttackPoints);
            Assert.AreEqual(10, axe.DurabilityPoints);
        }
        [Test]
        public void AxeShouldLooseDurabilityPointsAfterEachAttack()
        {
            for (int i = 0; i < 5; i++)
            {
             axe.Attack(dummy);

            }
            Assert.AreEqual(durabilityPoints-5, axe.DurabilityPoints);
        }
        [Test]
        public void AxeShouldThrowNewExceptionWhenDurabilityPointsIsZero()
        {
            axe = new Axe(10, 0);
            Assert.Throws<InvalidOperationException>((()=>
            {
                axe.Attack(dummy);

            }));
        }
        [Test]
        public void AxeShouldThrowNewExceptionWhenDurabilityPointsIsNegative()
        {
            axe = new Axe(10, -5);
            Assert.Throws<InvalidOperationException>((() =>
            {
                axe.Attack(dummy);

            }));

        }
    }
}