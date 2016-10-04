namespace RotatingWalkInMatrix.Common
{
    using Contracts;
    using Models;

    /// <summary>
    /// Static Clas that holds all posible directions in a matrix acording to a specific rule.
    /// </summary>
    public static class PossibleDirections
    {
        public static readonly ICell[] AllDirections;

        /// <summary>
        /// All the directions as an Array of Cells.
        /// </summary>
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
