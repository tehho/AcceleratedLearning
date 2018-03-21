using System.Security.Cryptography;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modul6;


namespace ElevatorTest
{
    [TestClass]
    public class UnitTest1
    {
        private string _name = "Bob";
        private readonly int _startFloor = 3;
        private readonly int _minFloor = 1;
        private readonly int _maxFloor = 5;
        private int _maxUses = 10;

        private readonly Elevator _elevator = new Elevator("Bob", 1, 5, 3);


        [TestMethod]
        public void CheckGoUp()
        {
            _elevator.GoUp();
            Assert.AreEqual(_startFloor + 1, _elevator.CurrentFloor);
        }

        [TestMethod]
        public void CheckGoDown()
        {
            _elevator.GoDown();
            Assert.AreEqual(_startFloor - 1, _elevator.CurrentFloor);
        }

        [TestMethod]
        public void CheckStartFloorLessThanMinFloorInConsturctor()
        {
            Assert.ThrowsException<ArgumentException>(CreatNewElevatorStartFloorLessThanMinFloor);
        }

        public Elevator CreatNewElevatorStartFloorLessThanMinFloor()
        {
            return (new Elevator("", 0, 1, -1));
        }

        [TestMethod]
        public void StartFloorTest()
        {
            Assert.AreEqual(_startFloor, _elevator.CurrentFloor);
        }

        [TestMethod]
        public void CheckHighestFloor()
        {
            Assert.AreEqual(_maxFloor, _elevator.MaxFloor);
        }

        [TestMethod]
        public void CheckLowestFloor()
        {
            Assert.AreEqual(_minFloor, _elevator.MinFloor);
        }

    }
}
