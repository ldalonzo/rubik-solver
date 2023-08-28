namespace LDZ.RubikSolver.Test;

public class SolvedStateUnitTest
{
    [Theory]
    [InlineData(MoveKind.WhiteClockwise)]
    [InlineData(MoveKind.WhiteCounterClockwise)]
    [InlineData(MoveKind.BlueClockwise)]
    [InlineData(MoveKind.BlueCounterClockwise)]
    [InlineData(MoveKind.GreenClockwise)]
    [InlineData(MoveKind.GreenCounterClockwise)]
    [InlineData(MoveKind.YellowClockwise)]
    [InlineData(MoveKind.YellowCounterClockwise)]
    [InlineData(MoveKind.OrangeClockwise)]
    [InlineData(MoveKind.OrangeCounterClockwise)]
    [InlineData(MoveKind.RedClockwise)]
    [InlineData(MoveKind.RedCounterClockwise)]
    public void Unsolved(MoveKind move)
    {
        var cube = RubikCube.Solved().Turn(move);
        cube.IsSolved.Should().BeFalse();
    }

    [Fact]
    public void Solved()
    {
        var cube = RubikCube.Solved();
        cube.IsSolved.Should().BeTrue();
    }

    [Fact]
    public void SolvedReciprocalMovesRed()
    {
        var cube = RubikCube.Solved()
            .Turn(MoveKind.RedClockwise)
            .Turn(MoveKind.RedCounterClockwise);

        cube.IsSolved.Should().BeTrue();
    }
}
