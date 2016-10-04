namespace RotatingWalkInMatrix.Contracts
{
    public interface IMatrix
    {
        int[,] Field { get; }

        string MatrixToString();
    }
}
