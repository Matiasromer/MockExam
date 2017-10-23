using Microsoft.VisualStudio.TestTools.UnitTesting;
using MockExamBoxVolume;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockExamBoxVolume.Tests
{
    [TestClass()]
    public class Service1Tests
    {
        [TestMethod()]
        public void GetSideTest()
        {
            Service1 Test = new Service1();
            double gettest = Test.GetSide(8, 2, 2);
            Assert.AreEqual(gettest, 2);
        }

        [TestMethod()]
        public void GetVolumeTest()
        {
            Service1 Test = new Service1();
            double volumetest = Test.GetVolume(2, 2, 2);
            Assert.AreEqual(volumetest, 8);
        }
    }
}