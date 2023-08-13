namespace LDZ.RubikSolver.Test;

public record CenterPiece(
    FaceColor Color,
    EdgePiece North,
    EdgePiece West,
    EdgePiece South,
    EdgePiece East)
{
    public CenterPiece ClockWise() => this with
    {
        North = West,
        West = South,
        South = East,
        East = North
    };
}
