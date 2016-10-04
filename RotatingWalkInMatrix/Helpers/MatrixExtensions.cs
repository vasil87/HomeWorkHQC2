namespace RotatingWalkInMatrix.Helpers
{
    using System;
    using Contracts;

    /// <summary>
    /// Extension Methods for work with Square Matrix.
    /// </summary>
    public static class IMatrixExtensions
    {  
        /// <summary>
        /// Checks if a destination is in the matrix boundaries and if it is with default value.
        /// </summary>
        /// <param name="matrix">Current Matrix</param>
        /// <param name="cellToCheck">Cell with given cordinates to be checked</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException"/>
        public static bool IsValidDestination(this IMatrix matrix, ICell cellToCheck)
        {
            if (cellToCheck == null)
            {
                throw new ArgumentNullException("The cell can`t be null");
            }

            return CellIsInBoundaries(matrix, cellToCheck) && matrix.Field[cellToCheck.CoordinateX, cellToCheck.CoordinateY] == 0;
        }

        private static bool CellIsInBoundaries(this IMatrix matrix, ICell cellToCheck)
        {
            return cellToCheck.CoordinateX >= 0 && cellToCheck.CoordinateX < matrix.Field.GetLength(0) &&
                   cellToCheck.CoordinateY >= 0 && cellToCheck.CoordinateY < matrix.Field.GetLength(0);
        }
    }
}
