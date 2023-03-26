using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
    {
        private int health;
        private int experience;
        Dummy dummy;
        [SetUp]
        public void SetUp()
        {
            health = 10;
            experience = 10;
            dummy = new Dummy(health, experience);
        }
        [Test]
        public void ConstructorShouldReceiveDataProperly()
        {
            Assert.AreEqual(10, health);
            Assert.AreEqual(10, experience);
        }
        [Test]
        public void DummyShouldLooseHealthThroughAttackPoints()
        {
            int attackPoints = 1;
            dummy.TakeAttack(attackPoints);
            Assert.AreEqual(health - 1, dummy.Health);
        }
        [Test]
        public void DummyShouldThrowExceptionWhenHealthIsZero()
        {
            int attackPoints = 0;
            dummy = new Dummy(attackPoints, 10);
            Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(attackPoints));
        }
        [Test]
        public void DummyShouldThrowExceptionWhenHealthIsNegative()
        {
            int attackPoints = -5;
            dummy = new Dummy(attackPoints, 10);
            Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(attackPoints));
        }
        [Test]
        public void DummyShouldGainExperienceWhenIsDead()
        {
            int attackPoints = -5;
            dummy = new Dummy(attackPoints, 10);

            var dummyExperience = dummy.GiveExperience();

            Assert.AreEqual(experience, dummyExperience);
        }
        [Test]
        public void DummyShouldThrowExceptionWhenIsAlive()
        {
            Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());
        }
    }
}