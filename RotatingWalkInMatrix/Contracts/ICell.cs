namespace RotatingWalkInMatrix.Contracts
{
    public interface ICell
    {
        int CoordinateX { get; }

        int CoordinateY { get; }

        ICell SumOfCells(ICell cellToSumWith);
    }
}
