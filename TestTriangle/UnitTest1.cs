using NUnit.Framework;

namespace TestTriangle
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void creatingTheTriangle()
        {
            var triangle = new Triangle();
        }
    }
}