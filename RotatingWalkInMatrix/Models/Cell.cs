namespace RotatingWalkInMatrix.Models
{
    using Contracts;

    public class Cell : ICell
    {
        public Cell(int x, int y)
        {
            this.CoordinateX = x;
            this.CoordinateY = y;
        }

        public int CoordinateX { get; set; }

        public int CoordinateY { get; set; }

        public ICell SumOfCells(ICell cellToSumWith)
        {
            int resultCoordinateX = cellToSumWith.CoordinateX + this.CoordinateX;

            int resultCoordinatey = cellToSumWith.CoordinateY + this.CoordinateY;

            return new Cell(resultCoordinateX, resultCoordinatey);
        }
    }
}
