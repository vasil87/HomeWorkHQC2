namespace RotatingWalkInMatrix.Models
{
    using System;
    using Contracts;

    /// <summary>
    /// Holds data for a point in the Decard System axis-X(abcis) and axis-Y(ordinate)
    /// </summary>
    public class Cell : ICell
    {  
        /// <summary>
        /// Initialize a cell in the Decard Space with x(abcis),y(ordinate)
        /// </summary>
        /// <param name="x">Abcis <seealso cref="System.Int32"/> value</param>
        /// <param name="y">Ordinate <seealso cref="System.Int32"/> value</param>
        public Cell(int x, int y)
        {
            this.CoordinateX = x;
            this.CoordinateY = y;
        }

        /// <summary>
        /// Abcis <seealso cref="System.Int32"/> value
        /// </summary>
        public int CoordinateX { get; set; }

        /// <summary>
        /// Ordinate <seealso cref="System.Int32"/> value
        /// </summary>
        public int CoordinateY { get; set; }

        /// <summary>
        /// Returns sum of the cell coordinates with another cell coordinates as a new Cell.
        /// </summary>
        /// <param name="cellToSumWith">The cell to sum with. </param>
        /// <returns>ICell</returns>
        /// <exception cref="ArgumentNullException"/>
        public ICell SumOfCells(ICell cellToSumWith)
        {
            if (cellToSumWith == null)
            {
                throw new ArgumentNullException("Can`t add with null cell");
            }

            int resultCoordinateX = cellToSumWith.CoordinateX + this.CoordinateX;

            int resultCoordinatey = cellToSumWith.CoordinateY + this.CoordinateY;

            return new Cell(resultCoordinateX, resultCoordinatey);
        }
    }
}
