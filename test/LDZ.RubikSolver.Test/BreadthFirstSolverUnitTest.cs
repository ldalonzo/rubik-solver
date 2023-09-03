namespace LDZ.RubikSolver.Test;

public class BreadthFirstSolverUnitTest
{
    public BreadthFirstSolverUnitTest()
    {
        Solver = new BreadthFirstSolver();
    }

    private IRubikCubeSolver Solver { get; }

    [Fact]
    public void Solved()
    {
        var cube = RubikCube.Solved();
        var solution = Solver.Solve(cube);
        solution.Should().BeEmpty();
    }

    [Theory]
    [InlineData(MoveKind.White, true)]
    [InlineData(MoveKind.Blue, true)]
    [InlineData(MoveKind.Green, true)]
    [InlineData(MoveKind.Orange, true)]
    [InlineData(MoveKind.Yellow, true)]
    [InlineData(MoveKind.Red, true)]
    public void ScrambledOne(MoveKind move, bool clockwise) => SolveWithKnownSolution(
        new Move(move, clockwise));

    [Theory]
    [InlineData(MoveKind.White, MoveKind.Red)]
    [InlineData(MoveKind.White, MoveKind.Orange)]
    [InlineData(MoveKind.Orange, MoveKind.Yellow)]
    [InlineData(MoveKind.Orange, MoveKind.White)]
    public void ScrambledTwo(MoveKind move1, MoveKind move2) => SolveWithKnownSolution(
        new Move(move1, true),
        new Move(move2, true));

    [Theory]
    [InlineData(MoveKind.White, MoveKind.Red, MoveKind.Green)]
    [InlineData(MoveKind.White, MoveKind.Orange, MoveKind.Blue)]
    [InlineData(MoveKind.White, MoveKind.Red, MoveKind.White)]
    [InlineData(MoveKind.Blue, MoveKind.Red, MoveKind.Blue)]
    [InlineData(MoveKind.Orange, MoveKind.Green, MoveKind.Orange)]
    [InlineData(MoveKind.Orange, MoveKind.White, MoveKind.Orange)]
    public void ScrambledThree(MoveKind move1, MoveKind move2, MoveKind move3) => SolveWithKnownSolution(
        new Move(move1, true),
        new Move(move2, true),
        new Move(move3, true));

    [Fact]
    public void ScrambledFour() => SolveWithKnownSolution(
        new Move(MoveKind.Yellow, true),
        new Move(MoveKind.Red, true),
        new Move(MoveKind.Yellow, false),
        new Move(MoveKind.Red, false));

    [Fact]
    public void ScrambledFive() => SolveWithKnownSolution(
        new Move(MoveKind.Yellow, true),
        new Move(MoveKind.Red, true),
        new Move(MoveKind.Yellow, false),
        new Move(MoveKind.Red, false),
        new Move(MoveKind.Blue, true));

    private void SolveWithKnownSolution(params Move[] expectedSolution)
    {
        var scrambled = expectedSolution
            .Reverse()
            .Aggregate(RubikCube.Solved(), (c, move) => c.Turn(move.Reverse()));

        var solution = Solver.Solve(scrambled);

        var cube = solution.Aggregate(scrambled, (c, move) => c.Turn(move));
        cube.IsSolved.Should().BeTrue();

        solution.Should().ContainInConsecutiveOrder(expectedSolution);
    }
}
