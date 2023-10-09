using Microsoft.VisualStudio.TestTools.UnitTesting;
using Carvromvroom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carvromvroom.Tests
{
    [TestClass()]
    public class CarTests
    {

        [TestMethod()]
        public void ValidateModelTest()
        {
            var car = new Car { Model = "Ferraria" };
            Assert.IsTrue(car.ValidateModel());
        }
        [TestMethod()]
        public void ValidateInvaldModelTest()
        {
            var car = new Car { Model = "Fe" };
            Assert.IsFalse(car.ValidateModel());
        }

        [TestMethod()]
        public void ValidatePriceTest()
        {
            var car = new Car { Price = 7000 };
            Assert.IsTrue(car.ValidatePrice());
        }
        [TestMethod()]
        public void ValidateInvbalidPriceTest()
        {
            var car = new Car { Price = -7000 };
            Assert.IsFalse(car.ValidatePrice());
        }

        [TestMethod()]
        public void ValidateLicensePlateTest()
        {

            var car = new Car { LicensePlate = "A14gf1" };
            Assert.IsTrue(car.ValidateLicensePlate());

        }
        [TestMethod()]
        public void ValidateINVALDLicensePlateTest()
        {

            var car = new Car { LicensePlate = "A1" };
            Assert.IsFalse(car.ValidatePrice());

        }
    }
}
