namespace RotatingWalkInMatrix.Common
{
    using Contracts;
    using Models;

    public static class PossibleDirections
    {
        public static readonly ICell[] AllDirections;

        static PossibleDirections()
        {
            AllDirections = new ICell[]
                                  {
                                        new Cell(1, 1),
                                        new Cell(1, 0),
                                        new Cell(1, -1),
                                        new Cell(0, -1),
                                        new Cell(-1, -1),
                                        new Cell(-1, 0),
                                        new Cell(-1, 1),
                                        new Cell(0, 1)
                                  };
        }
    }
}
