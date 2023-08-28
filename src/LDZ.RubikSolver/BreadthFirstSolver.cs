using System.Collections.Immutable;

namespace LDZ.RubikSolver;

public class BreadthFirstSolver
{
    private int MaxNodes { get; } = 12 * 12 * 12;

    public IEnumerable<MoveKind> Solve(RubikCube cube)
    {
        var searchQueue = new Queue<Node>();
        searchQueue.Enqueue(new Node(cube, ImmutableList.Create<MoveKind>()));

        while (searchQueue.Count > 0 && searchQueue.Count < MaxNodes)
        {
            var currentNode = searchQueue.Dequeue();
            if (currentNode.Cube.IsSolved)
            {
                return currentNode.Moves;
            }

            foreach (var move in Enum.GetValues<MoveKind>())
            {
                searchQueue.Enqueue(currentNode with
                {
                    Cube = currentNode.Cube.Turn(move),
                    Moves = currentNode.Moves.Add(move)
                });
            }
        }

        throw new Exception();
    }

    private record Node(RubikCube Cube, ImmutableList<MoveKind> Moves);
}
