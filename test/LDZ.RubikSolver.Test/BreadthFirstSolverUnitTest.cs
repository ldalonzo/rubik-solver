namespace LDZ.RubikSolver.Test;

public class BreadthFirstSolverUnitTest
{
    public BreadthFirstSolver Solver { get; } = new BreadthFirstSolver();

    [Fact]
    public void Solved()
    {
        var cube = RubikCube.Solved();
        var solution = Solver.Solve(cube);
        solution.Should().BeEmpty();
    }

    [Theory]
    [InlineData(MoveKind.WhiteClockwise, MoveKind.WhiteCounterClockwise)]
    [InlineData(MoveKind.BlueClockwise, MoveKind.BlueCounterClockwise)]
    [InlineData(MoveKind.GreenClockwise, MoveKind.GreenCounterClockwise)]
    [InlineData(MoveKind.OrangeClockwise, MoveKind.OrangeCounterClockwise)]
    [InlineData(MoveKind.YellowClockwise, MoveKind.YellowCounterClockwise)]
    [InlineData(MoveKind.RedClockwise, MoveKind.RedCounterClockwise)]
    public void OneMoveAway(MoveKind move, MoveKind reciprocal)
    {
        var cube = RubikCube.Solved().Turn(move);
        var solution = Solver.Solve(cube);
        solution.Should().ContainSingle().Which.Should().Be(reciprocal);
    }

    [Fact]
    public void ScrambledTwo()
    {
        var cube = RubikCube.Solved()
            .Turn(MoveKind.WhiteClockwise)
            .Turn(MoveKind.RedClockwise);

        var solution = Solver.Solve(cube);
        solution.Should().BeEquivalentTo(new[]
        {
            MoveKind.RedCounterClockwise,
            MoveKind.WhiteCounterClockwise
        });
    }
}
