namespace RotatingWalkInMatrix.Models
{
    using System;
    using System.Text;
    using Contracts;

    public class Matrix : IMatrix
    {
        /// <exception cref="ArgumentOutOfRangeException">Size cannot be less than or equal to zero</exception>
        public Matrix(int size)
        {
            if (size <= 0)
            {
                throw new ArgumentOutOfRangeException("Size " + "cannot be <= 0");
            }

            this.Field = new int[size, size];
        }

        public int[,] Field { get; private set; }

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
