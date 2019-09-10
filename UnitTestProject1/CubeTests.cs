using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CubeIntersection;

namespace CubeIntersectionTests
{
    [TestClass]
    public class CubeTests
    {
        [TestMethod]
        public void TestCollided()
        {
            //First cube will be the same for all the tests
            var testcube1 = new Cube(0, 0, 0, 10);

            //Black box testing
            var testcube2 = new Cube(0, 0, 0, 4);
            Assert.AreEqual(true, testcube1.Collided(testcube2));
            testcube2 = new Cube(0, 0, 0, 10);
            Assert.AreEqual(true, testcube1.Collided(testcube2));
            testcube2 = new Cube(0, 0, 0, 20);
            Assert.AreEqual(true, testcube1.Collided(testcube2));


            testcube2 = new Cube(5, 0, 0, 1);
            Assert.AreEqual(true, testcube1.Collided(testcube2));
            testcube2 = new Cube(5, 5, 0, 1);
            Assert.AreEqual(true, testcube1.Collided(testcube2));
            testcube2 = new Cube(5, 5, 5, 1);
            Assert.AreEqual(true, testcube1.Collided(testcube2));

            testcube2 = new Cube(6, 0, 0, 2);
            Assert.AreEqual(false, testcube1.Collided(testcube2));
            testcube2 = new Cube(6, 5, 3, 2);
            Assert.AreEqual(false, testcube1.Collided(testcube2));
            testcube2 = new Cube(6, 6, 6, 2);
            Assert.AreEqual(false, testcube1.Collided(testcube2));

            testcube2 = new Cube(24, -10, 42, 2);
            Assert.AreEqual(false, testcube1.Collided(testcube2));
        }
    }
}
