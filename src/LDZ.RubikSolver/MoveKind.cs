namespace LDZ.RubikSolver;

public enum MoveKind
{
    White,
    Blue,
    Green,
    Orange,
    Red,
    Yellow
}

public record Move(MoveKind Kind, bool Clockwise);
