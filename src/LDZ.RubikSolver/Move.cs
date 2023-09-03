namespace LDZ.RubikSolver;

public record struct Move(MoveKind Kind, bool Clockwise)
{
    public static IEnumerable<Move> GetMoves()
    {
        foreach (var kind in Enum.GetValues<MoveKind>())
        {
            yield return new Move(kind, true);
            yield return new Move(kind, false);
        }
    }

    public static readonly IReadOnlyCollection<Move> AllMoves = GetMoves().ToList();

    public Move Reverse() => this with { Clockwise = !Clockwise };
}
