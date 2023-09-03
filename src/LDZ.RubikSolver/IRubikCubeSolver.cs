namespace LDZ.RubikSolver;

public interface IRubikCubeSolver
{
    IEnumerable<Move> Solve(RubikCube cube);
}