using NUnit.Framework;

namespace SoftwareSecurityAssignment
{
    [TestFixture]
    public class StateEngineTest
    {
        [SetUp]
        public void Setup ()
        { }

        [Test]
        public void Test ()
        {
            StateEngineMock mock = new StateEngineMock ();
            Assert.Pass ();
        }
    }
}