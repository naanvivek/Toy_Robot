using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toy_Robot.Toy;

namespace ToyRoboUnitTest
{
    [TestFixture]
    public class TestToyRobot
    {
        /// <summary>
        /// Test toy turn left
        /// </summary>
        [Test]
        public void TestValidToyTurnLeft()
        {
            // arrange
            var robot = new ToyRobot { Direction = Direction.West, Position = new Position(2, 2) };

            // act
            robot.RotateLeft();

            // assert
            Assert.AreEqual(Direction.South, robot.Direction);
        }

        /// <summary>
        /// Test toy turn right
        /// </summary>
        [Test]
        public void TestValidToyTurnRight()
        {
            // arrange
            var robot = new ToyRobot { Direction = Direction.West, Position = new Position(2, 2) };

            // act
            robot.RotateRight();

            // assert
            Assert.AreEqual(Direction.North, robot.Direction);
        }


        /// <summary>
        /// Test move
        /// </summary>
        [Test]
        public void TestValidToyMove()
        {
            // arrange
            var robot = new ToyRobot { Direction = Direction.East, Position = new Position(2, 2) };

            // act
            var nextPosition = robot.GetNextPosition();

            // assert
            Assert.AreEqual(3, nextPosition.X);
            Assert.AreEqual(2, nextPosition.Y);
        }

        /// <summary>
        /// Test set toy position and direction
        /// </summary>
        [Test]
        public void TestValidToyPositionAndDirection()
        {
            // arrange
            var position = new Position(3, 3);
            var robot = new ToyRobot();

            // act
            robot.Place(position, Direction.North);

            // assert
            Assert.AreEqual(3, robot.Position.X);
            Assert.AreEqual(3, robot.Position.Y);
            Assert.AreEqual(Direction.North, robot.Direction);
        }

    }
}
