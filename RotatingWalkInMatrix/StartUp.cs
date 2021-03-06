﻿namespace RotatingWalkInMatrix
{
    using System;
    using Common;
    using Contracts;
    using log4net;
    using log4net.Config;
    using Models;

    public class RotatingWalkInMatrix
    {
        private const int NumberOfMatrixRowsAndCows = 6;
        private const int StartingPositionOnRowsAndCows = 0;
        private static readonly ILog Logger = LogManager.GetLogger(typeof(RotatingWalkInMatrix));

        public static void Main()
        {
            XmlConfigurator.Configure();
            IMatrix matrix = default(IMatrix);
            IMatrixUtils matrixUtils = default(IMatrixUtils);

            try
            {
                int rowsAndCowsInTheMatrix = NumberOfMatrixRowsAndCows;
                ICell startingCell = new Cell(StartingPositionOnRowsAndCows, StartingPositionOnRowsAndCows);
                matrix = new Matrix(rowsAndCowsInTheMatrix);
                matrixUtils = new MatrixUtils(matrix, PossibleDirections.AllDirections, startingCell);
                throw new ArgumentException("I Have Error Loging");
            }
            catch (Exception ex)
            {
                Logger.Error("Initializing of Matrix failed", ex);
            }
         
            matrixUtils.FillMatrix();

            Console.WriteLine(matrix.MatrixToString());
        }
    }
}
