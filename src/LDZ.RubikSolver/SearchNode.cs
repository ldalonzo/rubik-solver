namespace LDZ.RubikSolver;

internal sealed record SearchNode(RubikCube Cube, SearchNode? Parent = null, Move? Move = null)
{
    public IEnumerable<Move> Moves
    {
        get
        {
            if (Move != null)
            {
                yield return Move.Value;
            }

            if (Parent != null)
            {
                foreach (var move in Parent.Moves)
                {
                    yield return move;
                }
            }
        }
    }
}
