namespace LDZ.RubikSolver.Thistlethwaite;

/// <summary>
/// This involves edge pieces only, and is easy, for which reason no tables are given.
/// An edge piece is BAD if in taking it home an odd number of quarter-turns of U and D faces is needed; otherwise it is GOOD (note that badness is well-defined).
/// </summary>
public class ThistlethwaiteGroup1BreadthFirstSolver
{
    public ThistlethwaiteGroup1BreadthFirstSolver(Predicate<RubikCube> isGoal, int maxNodes = int.MaxValue)
    {
        MaxNodes = maxNodes;
        _isGoal = isGoal;
    }

    protected int MaxNodes { get; }
    private readonly Predicate<RubikCube> _isGoal;

    public IEnumerable<Move> Solve(RubikCube cube)
    {
        var searchQueue = new Queue<SearchNode>();
        searchQueue.Enqueue(new SearchNode(cube));

        while (searchQueue.Count > 0 && searchQueue.Count < MaxNodes)
        {
            var currentNode = searchQueue.Dequeue();
            if (_isGoal(currentNode.Cube))
            {
                return currentNode.Moves.Reverse();
            }

            foreach (var move in Move.AllMoves)
            {
                searchQueue.Enqueue(currentNode with
                {
                    Cube = currentNode.Cube.Turn(move),
                    Move = move,
                    Parent = currentNode,
                });
            }
        }

        throw new Exception();
    }
}
