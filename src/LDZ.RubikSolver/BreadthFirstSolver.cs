namespace LDZ.RubikSolver;

public class BreadthFirstSolver : IRubikCubeSolver
{
    public BreadthFirstSolver(int maxNodes = int.MaxValue)
    {
        MaxNodes = maxNodes;
    }

    protected int MaxNodes { get; }

    public IEnumerable<Move> Solve(RubikCube cube)
    {
        var searchQueue = new Queue<SearchNode>();
        searchQueue.Enqueue(new SearchNode(cube));

        while (searchQueue.Count > 0 && searchQueue.Count < MaxNodes)
        {
            var currentNode = searchQueue.Dequeue();
            if (currentNode.Cube.IsSolved)
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
