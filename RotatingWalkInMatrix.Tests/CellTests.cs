namespace RotatingWalkInMatrix.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Models;
    using Contracts;

    [TestClass]
    public class CellTests
    {
        private Cell firstCell = new Cell(1, 2);
        private Cell secondCell = new Cell(2, 1);

        [TestMethod]
        public void ConstructorShouldReturnValidCellAlwaysWhenIntValuesArePassed()
        {
            Random randomGenerator= new Random();
            int x = randomGenerator.Next(int.MinValue, int.MaxValue);
            int y = randomGenerator.Next(int.MinValue, int.MaxValue);

            var testCell = new Cell(x,y);

            Assert.IsInstanceOfType(testCell, typeof(Cell));
            Assert.AreEqual(x, testCell.CoordinateX);
            Assert.AreEqual(y, testCell.CoordinateY);
        }

        [TestMethod]
        public void AddingTwoCellsShouldReturnANewCellWithProperValuesForXAndY()
        {
            ICell resultingCell = firstCell.SumOfCells(secondCell);

            Assert.AreEqual(3, resultingCell.CoordinateX, "resultingCell.X should be equal to firstCell.X + secondCell.X");
            Assert.AreEqual(3, resultingCell.CoordinateY, "resultingCell.Y should be equal to firstCell.Y + secondCell.Y");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingTwoCellsShouldThrowAnArgumentNullExceptionWhenEitherOfTheOperandsIsNull()
        {
            ICell test = this.firstCell.SumOfCells(null);
        }
    }
}
