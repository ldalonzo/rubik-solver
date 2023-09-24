namespace LDZ.RubikSolver;

public record struct Move(MoveKind Kind, bool Clockwise)
{
    public static Move U(bool clockwise = true) => new(MoveKind.White, clockwise);

    public static Move L(bool clockwise = true) => new(MoveKind.Red, clockwise);

    public static Move R(bool clockwise = true) => new(MoveKind.Orange, clockwise);

    public static Move F(bool clockwise = true) => new(MoveKind.Blue, clockwise);

    public static Move D(bool clockwise = true) => new(MoveKind.Yellow, clockwise);

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
