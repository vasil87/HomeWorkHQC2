namespace RotatingWalkInMatrix.Models
{
    using System;
    using System.Text;
    using Contracts;

    /// <summary>
    /// Class matrix holds instance of a square matrix and a method to return it as a string.
    /// </summary>
    public class Matrix : IMatrix
    {
        /// <summary>
        /// Matrix Constructor.
        /// </summary>
        /// <param name="size">
        /// The matrix dimensions as rows and cols.
        /// In <seealso cref="System.Int32"/>.
        /// Can`t be less than zero.
        /// </param>
        /// <exception cref="ArgumentOutOfRangeException">Size cannot be less than or equal to zero</exception>
        public Matrix(int size)
        {
            if (size <= 0)
            {
                throw new ArgumentOutOfRangeException("Size " + "cannot be <= 0");
            }

            this.Field = new int[size, size];
        }

        /// <summary>
        /// Fild is the instance of the square matrix.Can`t be set.
        /// </summary>
        public int[,] Field { get; private set; }

        /// <summary>
        /// Represent the matrix as a <seealso cref="System.String"/> in special format.
        /// </summary>
        /// <returns>Matrix as <seealso cref="System.String"/>.</returns>
        public string MatrixToString()
        {
            var printedMatrix = new StringBuilder();
            for (int i = 0; i < this.Field.GetLength(0); i++)
            {
                for (int j = 0; j < this.Field.GetLength(0); j++)
                {
                    printedMatrix.AppendFormat("{0,3}", this.Field[i, j]);
                }

                printedMatrix.Append(Environment.NewLine);
            }

            return printedMatrix.ToString();
        }
    }
}
