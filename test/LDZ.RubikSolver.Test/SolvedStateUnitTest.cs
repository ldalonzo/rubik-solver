namespace LDZ.RubikSolver.Test;

public class SolvedStateUnitTest
{
    [Theory]
    [InlineData(MoveKind.White, true)]
    [InlineData(MoveKind.White, false)]
    [InlineData(MoveKind.Blue, true)]
    [InlineData(MoveKind.Blue, false)]
    [InlineData(MoveKind.Green, true)]
    [InlineData(MoveKind.Green, false)]
    [InlineData(MoveKind.Yellow, true)]
    [InlineData(MoveKind.Yellow, false)]
    [InlineData(MoveKind.Orange, true)]
    [InlineData(MoveKind.Orange, false)]
    [InlineData(MoveKind.Red, true)]
    [InlineData(MoveKind.Red, false)]
    public void Unsolved(MoveKind move, bool clockwise)
    {
        var cube = RubikCube.Solved().Turn(move, clockwise);
        cube.IsSolved.Should().BeFalse();
    }

    [Fact]
    public void Solved()
    {
        var cube = RubikCube.Solved();
        cube.IsSolved.Should().BeTrue();
    }

    [Theory]
    [InlineData(MoveKind.White)]
    [InlineData(MoveKind.Red)]
    [InlineData(MoveKind.Orange)]
    [InlineData(MoveKind.Blue)]
    [InlineData(MoveKind.Green)]
    [InlineData(MoveKind.Yellow)]
    public void SolvedOneReciprocalMoves(MoveKind kind)
    {
        var cube = RubikCube.Solved()
            .Turn(kind, true)
            .Turn(kind, false);

        cube.IsSolved.Should().BeTrue();
    }

    [Theory]
    [InlineData(MoveKind.Orange, MoveKind.Green, MoveKind.Orange)]
    [InlineData(MoveKind.Orange, MoveKind.Yellow, MoveKind.Orange)]
    [InlineData(MoveKind.Orange, MoveKind.Blue, MoveKind.Orange)]
    [InlineData(MoveKind.Orange, MoveKind.White, MoveKind.Orange)]
    [InlineData(MoveKind.Orange, MoveKind.Red, MoveKind.Orange)]
    [InlineData(MoveKind.Yellow, MoveKind.White, MoveKind.Yellow)]
    [InlineData(MoveKind.Yellow, MoveKind.Green, MoveKind.Yellow)]
    [InlineData(MoveKind.Yellow, MoveKind.Blue, MoveKind.Yellow)]
    [InlineData(MoveKind.Yellow, MoveKind.Red, MoveKind.Yellow)]
    [InlineData(MoveKind.Yellow, MoveKind.Orange, MoveKind.Yellow)]
    [InlineData(MoveKind.Red, MoveKind.White, MoveKind.Red)]
    [InlineData(MoveKind.Red, MoveKind.Green, MoveKind.Red)]
    [InlineData(MoveKind.Red, MoveKind.Blue, MoveKind.Red)]
    [InlineData(MoveKind.Red, MoveKind.Yellow, MoveKind.Red)]
    [InlineData(MoveKind.Red, MoveKind.Orange, MoveKind.Red)]
    [InlineData(MoveKind.Green, MoveKind.Orange, MoveKind.Green)]
    [InlineData(MoveKind.Green, MoveKind.Yellow, MoveKind.Green)]
    [InlineData(MoveKind.Green, MoveKind.Blue, MoveKind.Green)]
    [InlineData(MoveKind.Green, MoveKind.White, MoveKind.Green)]
    [InlineData(MoveKind.Green, MoveKind.Red, MoveKind.Green)]
    [InlineData(MoveKind.Blue, MoveKind.Orange, MoveKind.Blue)]
    [InlineData(MoveKind.Blue, MoveKind.Yellow, MoveKind.Blue)]
    [InlineData(MoveKind.Blue, MoveKind.Green,   MoveKind.Blue)]
    [InlineData(MoveKind.Blue, MoveKind.White,  MoveKind.Blue)]
    [InlineData(MoveKind.Blue, MoveKind.Red,    MoveKind.Blue)]
    [InlineData(MoveKind.White, MoveKind.Orange, MoveKind.White)]
    [InlineData(MoveKind.White, MoveKind.Yellow, MoveKind.White)]
    [InlineData(MoveKind.White, MoveKind.Green,  MoveKind.White)]
    [InlineData(MoveKind.White, MoveKind.Blue,   MoveKind.White)]
    [InlineData(MoveKind.White, MoveKind.Red,    MoveKind.White)]
    public void SolvedThreeReciprocalMoves(MoveKind move1, MoveKind move2, MoveKind move3)
    {
        var scrambled = RubikCube.Solved()
            .Turn(move1, true)
            .Turn(move2, true)
            .Turn(move3, true);

        var actual = scrambled
            .Turn(move3, false)
            .Turn(move2, false)
            .Turn(move1, false);

        actual.IsSolved.Should().BeTrue();
    }
}

