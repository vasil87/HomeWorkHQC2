namespace RotatingWalkInMatrix.Helpers
{
    using Contracts;

    public static class IMatrixExtensions
    {
        public static bool IsValidDestination(this IMatrix matrix, ICell cellToCheck)
        {
            return CellIsInBoundaries(matrix, cellToCheck) && matrix.Field[cellToCheck.CoordinateX, cellToCheck.CoordinateY] == 0;
        }

        private static bool CellIsInBoundaries(this IMatrix matrix, ICell cellToCheck)
        {
            return cellToCheck.CoordinateX >= 0 && cellToCheck.CoordinateX < matrix.Field.GetLength(0) &&
                   cellToCheck.CoordinateY >= 0 && cellToCheck.CoordinateY < matrix.Field.GetLength(0);
        }
    }
}
