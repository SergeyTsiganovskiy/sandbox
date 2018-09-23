using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using NUnit.Framework;

namespace sandbox
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void Method1()
        {
            Assert.IsTrue(1 > 0);
        }

        [Test]
        public void Method2()
        {
            Assert.IsTrue(1 > 0);
        }

        [Test]
        public void Method3()
        {
            Assert.IsTrue(1 < 0);
        }

        [Test]
        public void Method4()
        {
            Assert.IsTrue(1 < 0);
        }

        [Test]
        public void Method5()
        {
            Assert.IsTrue(1 > 0);
        }
    }
}
