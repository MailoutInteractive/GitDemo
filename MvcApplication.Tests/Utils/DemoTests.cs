using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MvcApplication.Utils;
using NUnit.Framework;

namespace MvcApplication.Tests.Utils
{
    [TestFixture]
    public class DemoTests
    {
        [Test]
        public void It_Should_Add_Two_Integers()
        {
            // Arrange
            int x = 2, y = 3;
            Demo demo = new Demo();
            
            // Act
            int result = demo.Add(x, y);
            
            // Assert
            Assert.That(result, Is.EqualTo(x + y));

        }
    }
}
