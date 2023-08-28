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
    [InlineData(MoveKind.White, true)]
    [InlineData(MoveKind.Blue, true)]
    [InlineData(MoveKind.Green, true)]
    [InlineData(MoveKind.Orange, true)]
    [InlineData(MoveKind.Yellow, true)]
    [InlineData(MoveKind.Red, true)]
    public void ScrambledOne(MoveKind move, bool clockwise)
    {
        var cube = RubikCube.Solved().Turn(move, clockwise);
        var solution = Solver.Solve(cube);
        solution.Should().ContainSingle().Which.Should().Be(new Move(move, !clockwise));
    }

    [Theory]
    [InlineData(MoveKind.White, MoveKind.Red)]
    [InlineData(MoveKind.White, MoveKind.Orange)]
    [InlineData(MoveKind.Orange, MoveKind.Yellow)]
    [InlineData(MoveKind.Orange, MoveKind.White)]
    public void ScrambledTwo(MoveKind move1, MoveKind move2)
    {
        var cube = RubikCube.Solved()
            .Turn(move1, true)
            .Turn(move2, true);

        var solution = Solver.Solve(cube).ToList();
        solution.Should().ContainInConsecutiveOrder(new[]
        {
            new Move(move2, false),
            new Move(move1, false)
        });
    }

    [Theory]
    [InlineData(MoveKind.White, MoveKind.Red, MoveKind.Green)]
    [InlineData(MoveKind.White, MoveKind.Orange, MoveKind.Blue)]
    [InlineData(MoveKind.White, MoveKind.Red, MoveKind.White)]
    [InlineData(MoveKind.Blue, MoveKind.Red, MoveKind.Blue)]
    [InlineData(MoveKind.Orange, MoveKind.Green, MoveKind.Orange)]
    [InlineData(MoveKind.Orange, MoveKind.White, MoveKind.Orange)]
    public void ScrambledThree(MoveKind move1, MoveKind move2, MoveKind move3)
    {
        var cube = RubikCube.Solved()
            .Turn(move1, true)
            .Turn(move2, true)
            .Turn(move3, true);

        var solution = Solver.Solve(cube);
        solution.Should().ContainInOrder(new[]
        {
            new Move(move3, false),
            new Move(move2, false),
            new Move(move1, false)
        });
    }
}
