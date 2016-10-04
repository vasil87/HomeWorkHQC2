namespace RotatingWalkInMatrix
{
    using System;
    using Common;
    using Contracts;
    using Models;

    public class RotatingWalkInMatrix
    {
        private const int NumberOfMatrixRowsAndCows = 6;
        private const int StartingPositionOnRowsAndCows = 0;

        public static void Main()
        {       
            int rowsAndCowsInTheMatrix = NumberOfMatrixRowsAndCows;
            ICell startingCell = new Cell(StartingPositionOnRowsAndCows, StartingPositionOnRowsAndCows);
            IMatrix matrix = new Matrix(rowsAndCowsInTheMatrix);
            IMatrixUtils matrixUtils = new MatrixUtils(matrix, PossibleDirections.AllDirections, startingCell);

            matrixUtils.FillMatrix();

            Console.WriteLine(matrix.MatrixToString());
        }
    }
}
