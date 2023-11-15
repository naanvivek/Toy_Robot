using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toy_Robot.Board;
using Toy_Robot.Toy;

namespace ToyRoboUnitTest
{
    [TestFixture]
    public class TestBoard
    {

        /// <summary>
        /// Try to put the toy outside of the board
        /// </summary>
        [Test]
        public void TestInvalidBoardPosition()
        {
            // arrange
            ToyBoard squareBoard = new ToyBoard(5, 5);
            Position position = new Position(6, 6);

            // act
            var result = squareBoard.IsValidPosition(position);

            // assert
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Test valid positon 
        /// </summary>
        [Test]
        public void TestValidBoardPosition()
        {
            // arrange
            ToyBoard squareBoard = new ToyBoard(5, 5);
            Position position = new Position(1, 4);

            // act
            var result = squareBoard.IsValidPosition(position);

            // assert
            Assert.IsTrue(result);
        }

    }
}
