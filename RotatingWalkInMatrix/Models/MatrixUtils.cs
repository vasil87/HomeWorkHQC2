namespace RotatingWalkInMatrix.Models
{
    using System;
    using Contracts;
    using Helpers;

    /// <summary>
    /// Utils for work with Matrix.
    /// </summary>
    public class MatrixUtils : IMatrixUtils
    {
        private readonly IMatrix matrix;
        private readonly ICell[] posibleDirections;
        private int currentDirection;
        private ICell startCell;

        /// <summary>
        /// Utils Constructor.
        /// </summary>
        /// <param name="matrixToUse"></param>
        /// <param name="possibleDirections"></param>
        /// <param name="startCell"></param>
        /// <exception cref="ArgumentOutOfRangeException"/>
        public MatrixUtils(IMatrix matrixToUse, ICell[] possibleDirections, ICell startCell)
        {
            if (matrixToUse == null)
            {
                throw new ArgumentNullException("Canno`t use null matrix");
            }
            else
            {
                this.matrix = matrixToUse;
            }

            if (possibleDirections == null)
            {
                throw new ArgumentNullException("Canno`t use null possible directions");
            }
            else
            {
                this.posibleDirections = possibleDirections;
            }

            if (startCell == null)
            {
                throw new ArgumentNullException("Starting cell can`t be null");
            }
            else if (startCell.CoordinateX < 0 ||
                    startCell.CoordinateX > this.matrix.Field.GetLength(0) ||
                    startCell.CoordinateY < 0 ||
                    startCell.CoordinateY > this.matrix.Field.GetLength(0))
            {
                throw new ArgumentException("Starting point should be in the matrix");
            }
            else
            {
                this.startCell = startCell;
            }

            this.currentDirection = 0;
        }

        /// <summary>
        /// Fills the matrix with numbers form 1 to the Size^2 in a scpecific order.
        /// </summary>
        public void FillMatrix()
        {
            ICell currentCell = this.startCell;
            var currentCellValue = 1;

            while (currentCell != null)
            {
                this.matrix.Field[currentCell.CoordinateX, currentCell.CoordinateY] = currentCellValue;
                currentCell = this.Move(currentCell) ?? this.FindFirstEmptyCell();
                currentCellValue++;
            }
        }

        private ICell FindFirstEmptyCell()
        {
            Cell result = new Cell(0, 0);

            for (int i = 0; i < this.matrix.Field.GetLength(0); i++)
            {
                for (int j = 0; j < this.matrix.Field.GetLength(0); j++)
                {
                    if (this.matrix.Field[i, j] == 0)
                    {
                        this.currentDirection = 0;
                        result.CoordinateX = i;
                        result.CoordinateY = j;
                        return result;
                    }
                }
            }

            return null;
        }

        private ICell Move(ICell cell)
        {
            for (int i = 0; i < this.posibleDirections.Length; i++)
            {
                int nextDirection = (this.currentDirection + i) % this.posibleDirections.Length;

                ICell nextCell = cell.SumOfCells(this.posibleDirections[nextDirection]);

                if (this.matrix.IsValidDestination(nextCell))
                {
                    this.currentDirection = nextDirection;
                    return nextCell;
                }
            }

            return null;
        }
    }
}
