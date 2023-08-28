namespace LDZ.RubikSolver;

public class BreadthFirstSolver
{
    private int MaxNodes { get; } = 12 * 12 * 12 * 12 * 12 * 12;

    public IEnumerable<Move> Solve(RubikCube cube)
    {
        var searchQueue = new Queue<Node>();
        searchQueue.Enqueue(new Node(cube));

        while (searchQueue.Count > 0 && searchQueue.Count < MaxNodes)
        {
            var currentNode = searchQueue.Dequeue();
            if (currentNode.Cube.IsSolved)
            {
                return currentNode.Moves;
            }

            foreach (var move in GetMoves())
            {
                searchQueue.Enqueue(currentNode with
                {
                    Cube = currentNode.Cube.Turn(move.Kind, move.Clockwise),
                    Move = move,
                    Parent = currentNode,
                });
            }
        }

        throw new Exception();
    }

    private IEnumerable<Move> GetMoves()
    {
        foreach (var kind in Enum.GetValues<MoveKind>())
        {
            yield return new Move(kind, true);
            yield return new Move(kind, false);
        }
    }

    private record Node(RubikCube Cube, Node? Parent = null, Move? Move = null)
    {
        public IEnumerable<Move> Moves
        {
            get
            {
                if (Parent != null)
                {
                    foreach (var move in Parent.Moves)
                    {
                        yield return move;
                    }
                }

                if (Move != null)
                {
                    yield return Move;
                }
            }
        }
    }
}
