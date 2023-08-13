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
        East = North,
        South = East,
        West = South
    };
}
