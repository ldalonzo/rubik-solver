namespace LDZ.RubikSolver.Test;

public class TurnClockwiseOrthoUnitTest
{
    private RubikCube Cube { get; } = RubikCube.Solved();

    [Fact]
    public void WhiteGreen()
    {
        var actual = Cube
            .Turn(MoveKind.White, true)
            .Turn(MoveKind.Green, true);
        actual.Should().NotBeSameAs(Cube);

        actual.White.C11.Should().Be(FaceColor.White);
        actual.White.C12.Should().Be(FaceColor.White);
        actual.White.C13.Should().Be(FaceColor.Green);
        actual.White.C21.Should().Be(FaceColor.White);
        actual.White.C22.Should().Be(FaceColor.White);
        actual.White.C23.Should().Be(FaceColor.Orange);
        actual.White.C31.Should().Be(FaceColor.White);
        actual.White.C32.Should().Be(FaceColor.White);
        actual.White.C33.Should().Be(FaceColor.Orange);

        actual.Green.C11.Should().Be(FaceColor.Green);
        actual.Green.C12.Should().Be(FaceColor.Green);
        actual.Green.C13.Should().Be(FaceColor.Red);
        actual.Green.C21.Should().Be(FaceColor.Green);
        actual.Green.C22.Should().Be(FaceColor.Green);
        actual.Green.C23.Should().Be(FaceColor.Red);
        actual.Green.C31.Should().Be(FaceColor.Green);
        actual.Green.C32.Should().Be(FaceColor.Green);
        actual.Green.C33.Should().Be(FaceColor.Red);

        actual.Orange.C11.Should().Be(FaceColor.Green);
        actual.Orange.C12.Should().Be(FaceColor.Green);
        actual.Orange.C13.Should().Be(FaceColor.Yellow);
        actual.Orange.C21.Should().Be(FaceColor.Orange);
        actual.Orange.C22.Should().Be(FaceColor.Orange);
        actual.Orange.C23.Should().Be(FaceColor.Yellow);
        actual.Orange.C31.Should().Be(FaceColor.Orange);
        actual.Orange.C32.Should().Be(FaceColor.Orange);
        actual.Orange.C33.Should().Be(FaceColor.Yellow);
    }

    [Fact]
    public void WhiteRed()
    {
        var actual = Cube
            .Turn(MoveKind.White, true)
            .Turn(MoveKind.Red, true);
        actual.Should().NotBeSameAs(Cube);

        actual.White.C11.Should().Be(FaceColor.Red);
        actual.White.C12.Should().Be(FaceColor.Green);
        actual.White.C13.Should().Be(FaceColor.Green);
        actual.White.C21.Should().Be(FaceColor.White);
        actual.White.C22.Should().Be(FaceColor.White);
        actual.White.C23.Should().Be(FaceColor.White);
        actual.White.C31.Should().Be(FaceColor.White);
        actual.White.C32.Should().Be(FaceColor.White);
        actual.White.C33.Should().Be(FaceColor.White);

        actual.Red.C11.Should().Be(FaceColor.Red);
        actual.Red.C12.Should().Be(FaceColor.Red);
        actual.Red.C13.Should().Be(FaceColor.Blue);
        actual.Red.C21.Should().Be(FaceColor.Red);
        actual.Red.C22.Should().Be(FaceColor.Red);
        actual.Red.C23.Should().Be(FaceColor.Blue);
        actual.Red.C31.Should().Be(FaceColor.Red);
        actual.Red.C32.Should().Be(FaceColor.Red);
        actual.Red.C33.Should().Be(FaceColor.Blue);

        actual.Green.C11.Should().Be(FaceColor.Red);
        actual.Green.C12.Should().Be(FaceColor.Red);
        actual.Green.C13.Should().Be(FaceColor.Yellow);
        actual.Green.C21.Should().Be(FaceColor.Green);
        actual.Green.C22.Should().Be(FaceColor.Green);
        actual.Green.C23.Should().Be(FaceColor.Yellow);
        actual.Green.C31.Should().Be(FaceColor.Green);
        actual.Green.C32.Should().Be(FaceColor.Green);
        actual.Green.C33.Should().Be(FaceColor.Yellow);
    }

    [Fact]
    public void WhiteBlue()
    {
        var actual = Cube
            .Turn(MoveKind.White, true)
            .Turn(MoveKind.Blue, true);
        actual.Should().NotBeSameAs(Cube);

        actual.White.C11.Should().Be(FaceColor.Red);
        actual.White.C12.Should().Be(FaceColor.White);
        actual.White.C13.Should().Be(FaceColor.White);
        actual.White.C21.Should().Be(FaceColor.Red);
        actual.White.C22.Should().Be(FaceColor.White);
        actual.White.C23.Should().Be(FaceColor.White);
        actual.White.C31.Should().Be(FaceColor.Blue);
        actual.White.C32.Should().Be(FaceColor.White);
        actual.White.C33.Should().Be(FaceColor.White);

        actual.Blue.C11.Should().Be(FaceColor.Blue);
        actual.Blue.C12.Should().Be(FaceColor.Blue);
        actual.Blue.C13.Should().Be(FaceColor.Orange);
        actual.Blue.C21.Should().Be(FaceColor.Blue);
        actual.Blue.C22.Should().Be(FaceColor.Blue);
        actual.Blue.C23.Should().Be(FaceColor.Orange);
        actual.Blue.C31.Should().Be(FaceColor.Blue);
        actual.Blue.C32.Should().Be(FaceColor.Blue);
        actual.Blue.C33.Should().Be(FaceColor.Orange);

        actual.Red.C11.Should().Be(FaceColor.Blue);
        actual.Red.C12.Should().Be(FaceColor.Blue);
        actual.Red.C13.Should().Be(FaceColor.Yellow);
        actual.Red.C21.Should().Be(FaceColor.Red);
        actual.Red.C22.Should().Be(FaceColor.Red);
        actual.Red.C23.Should().Be(FaceColor.Yellow);
        actual.Red.C31.Should().Be(FaceColor.Red);
        actual.Red.C32.Should().Be(FaceColor.Red);
        actual.Red.C33.Should().Be(FaceColor.Yellow);
    }

    [Fact]
    public void WhiteOrange()
    {
        var actual = Cube
            .Turn(MoveKind.White, true)
            .Turn(MoveKind.Orange, true);
        actual.Should().NotBeSameAs(Cube);

        actual.White.C11.Should().Be(FaceColor.White);
        actual.White.C12.Should().Be(FaceColor.White);
        actual.White.C13.Should().Be(FaceColor.White);
        actual.White.C21.Should().Be(FaceColor.White);
        actual.White.C22.Should().Be(FaceColor.White);
        actual.White.C23.Should().Be(FaceColor.White);
        actual.White.C31.Should().Be(FaceColor.Blue);
        actual.White.C32.Should().Be(FaceColor.Blue);
        actual.White.C33.Should().Be(FaceColor.Orange);

        actual.Orange.C11.Should().Be(FaceColor.Orange);
        actual.Orange.C12.Should().Be(FaceColor.Orange);
        actual.Orange.C13.Should().Be(FaceColor.Green);
        actual.Orange.C21.Should().Be(FaceColor.Orange);
        actual.Orange.C22.Should().Be(FaceColor.Orange);
        actual.Orange.C23.Should().Be(FaceColor.Green);
        actual.Orange.C31.Should().Be(FaceColor.Orange);
        actual.Orange.C32.Should().Be(FaceColor.Orange);
        actual.Orange.C33.Should().Be(FaceColor.Green);

        actual.Blue.C11.Should().Be(FaceColor.Orange);
        actual.Blue.C12.Should().Be(FaceColor.Orange);
        actual.Blue.C13.Should().Be(FaceColor.Yellow);
        actual.Blue.C21.Should().Be(FaceColor.Blue);
        actual.Blue.C22.Should().Be(FaceColor.Blue);
        actual.Blue.C23.Should().Be(FaceColor.Yellow);
        actual.Blue.C31.Should().Be(FaceColor.Blue);
        actual.Blue.C32.Should().Be(FaceColor.Blue);
        actual.Blue.C33.Should().Be(FaceColor.Yellow);
    }

    [Fact]
    public void YellowRed()
    {
        var actual = Cube
            .Turn(MoveKind.Yellow, true)
            .Turn(MoveKind.Red, true);
        actual.Should().NotBeSameAs(Cube);

        actual.Yellow.C11.Should().Be(FaceColor.Yellow);
        actual.Yellow.C12.Should().Be(FaceColor.Yellow);
        actual.Yellow.C13.Should().Be(FaceColor.Yellow);
        actual.Yellow.C21.Should().Be(FaceColor.Yellow);
        actual.Yellow.C22.Should().Be(FaceColor.Yellow);
        actual.Yellow.C23.Should().Be(FaceColor.Yellow);
        actual.Yellow.C31.Should().Be(FaceColor.Blue);
        actual.Yellow.C32.Should().Be(FaceColor.Blue);
        actual.Yellow.C33.Should().Be(FaceColor.Red);

        actual.Red.C11.Should().Be(FaceColor.Green);
        actual.Red.C12.Should().Be(FaceColor.Red);
        actual.Red.C13.Should().Be(FaceColor.Red);
        actual.Red.C21.Should().Be(FaceColor.Green);
        actual.Red.C22.Should().Be(FaceColor.Red);
        actual.Red.C23.Should().Be(FaceColor.Red);
        actual.Red.C31.Should().Be(FaceColor.Green);
        actual.Red.C32.Should().Be(FaceColor.Red);
        actual.Red.C33.Should().Be(FaceColor.Red);

        actual.Blue.C11.Should().Be(FaceColor.White);
        actual.Blue.C12.Should().Be(FaceColor.Blue);
        actual.Blue.C13.Should().Be(FaceColor.Blue);
        actual.Blue.C21.Should().Be(FaceColor.White);
        actual.Blue.C22.Should().Be(FaceColor.Blue);
        actual.Blue.C23.Should().Be(FaceColor.Blue);
        actual.Blue.C31.Should().Be(FaceColor.White);
        actual.Blue.C32.Should().Be(FaceColor.Red);
        actual.Blue.C33.Should().Be(FaceColor.Red);
    }

    [Fact]
    public void YellowBlue()
    {
        var actual = Cube
            .Turn(MoveKind.Yellow, true)
            .Turn(MoveKind.Blue, true);
        actual.Should().NotBeSameAs(Cube);

        actual.Yellow.C11.Should().Be(FaceColor.Orange);
        actual.Yellow.C12.Should().Be(FaceColor.Yellow);
        actual.Yellow.C13.Should().Be(FaceColor.Yellow);
        actual.Yellow.C21.Should().Be(FaceColor.Orange);
        actual.Yellow.C22.Should().Be(FaceColor.Yellow);
        actual.Yellow.C23.Should().Be(FaceColor.Yellow);
        actual.Yellow.C31.Should().Be(FaceColor.Blue);
        actual.Yellow.C32.Should().Be(FaceColor.Yellow);
        actual.Yellow.C33.Should().Be(FaceColor.Yellow);

        actual.Blue.C11.Should().Be(FaceColor.Red);
        actual.Blue.C12.Should().Be(FaceColor.Blue);
        actual.Blue.C13.Should().Be(FaceColor.Blue);
        actual.Blue.C21.Should().Be(FaceColor.Red);
        actual.Blue.C22.Should().Be(FaceColor.Blue);
        actual.Blue.C23.Should().Be(FaceColor.Blue);
        actual.Blue.C31.Should().Be(FaceColor.Red);
        actual.Blue.C32.Should().Be(FaceColor.Blue);
        actual.Blue.C33.Should().Be(FaceColor.Blue);

        actual.Orange.C11.Should().Be(FaceColor.White);
        actual.Orange.C12.Should().Be(FaceColor.Orange);
        actual.Orange.C13.Should().Be(FaceColor.Orange);
        actual.Orange.C21.Should().Be(FaceColor.White);
        actual.Orange.C22.Should().Be(FaceColor.Orange);
        actual.Orange.C23.Should().Be(FaceColor.Orange);
        actual.Orange.C31.Should().Be(FaceColor.White);
        actual.Orange.C32.Should().Be(FaceColor.Blue);
        actual.Orange.C33.Should().Be(FaceColor.Blue);
    }

    [Fact]
    public void YellowOrange()
    {
        var actual = Cube
            .Turn(MoveKind.Yellow, true)
            .Turn(MoveKind.Orange, true);
        actual.Should().NotBeSameAs(Cube);

        actual.Yellow.C11.Should().Be(FaceColor.Orange);
        actual.Yellow.C12.Should().Be(FaceColor.Green);
        actual.Yellow.C13.Should().Be(FaceColor.Green);
        actual.Yellow.C21.Should().Be(FaceColor.Yellow);
        actual.Yellow.C22.Should().Be(FaceColor.Yellow);
        actual.Yellow.C23.Should().Be(FaceColor.Yellow);
        actual.Yellow.C31.Should().Be(FaceColor.Yellow);
        actual.Yellow.C32.Should().Be(FaceColor.Yellow);
        actual.Yellow.C33.Should().Be(FaceColor.Yellow);

        actual.Orange.C11.Should().Be(FaceColor.Blue);
        actual.Orange.C12.Should().Be(FaceColor.Orange);
        actual.Orange.C13.Should().Be(FaceColor.Orange);
        actual.Orange.C21.Should().Be(FaceColor.Blue);
        actual.Orange.C22.Should().Be(FaceColor.Orange);
        actual.Orange.C23.Should().Be(FaceColor.Orange);
        actual.Orange.C31.Should().Be(FaceColor.Blue);
        actual.Orange.C32.Should().Be(FaceColor.Orange);
        actual.Orange.C33.Should().Be(FaceColor.Orange);

        actual.Green.C11.Should().Be(FaceColor.White);
        actual.Green.C12.Should().Be(FaceColor.Green);
        actual.Green.C13.Should().Be(FaceColor.Green);
        actual.Green.C21.Should().Be(FaceColor.White);
        actual.Green.C22.Should().Be(FaceColor.Green);
        actual.Green.C23.Should().Be(FaceColor.Green);
        actual.Green.C31.Should().Be(FaceColor.White);
        actual.Green.C32.Should().Be(FaceColor.Orange);
        actual.Green.C33.Should().Be(FaceColor.Orange);
    }

    [Fact]
    public void YellowGreen()
    {
        var actual = Cube
            .Turn(MoveKind.Yellow, true)
            .Turn(MoveKind.Green, true);
        actual.Should().NotBeSameAs(Cube);

        actual.Yellow.C11.Should().Be(FaceColor.Yellow);
        actual.Yellow.C12.Should().Be(FaceColor.Yellow);
        actual.Yellow.C13.Should().Be(FaceColor.Green);
        actual.Yellow.C21.Should().Be(FaceColor.Yellow);
        actual.Yellow.C22.Should().Be(FaceColor.Yellow);
        actual.Yellow.C23.Should().Be(FaceColor.Red);
        actual.Yellow.C31.Should().Be(FaceColor.Yellow);
        actual.Yellow.C32.Should().Be(FaceColor.Yellow);
        actual.Yellow.C33.Should().Be(FaceColor.Red);

        actual.Green.C11.Should().Be(FaceColor.Orange);
        actual.Green.C12.Should().Be(FaceColor.Green);
        actual.Green.C13.Should().Be(FaceColor.Green);
        actual.Green.C21.Should().Be(FaceColor.Orange);
        actual.Green.C22.Should().Be(FaceColor.Green);
        actual.Green.C23.Should().Be(FaceColor.Green);
        actual.Green.C31.Should().Be(FaceColor.Orange);
        actual.Green.C32.Should().Be(FaceColor.Green);
        actual.Green.C33.Should().Be(FaceColor.Green);

        actual.Red.C11.Should().Be(FaceColor.White);
        actual.Red.C12.Should().Be(FaceColor.Red);
        actual.Red.C13.Should().Be(FaceColor.Red);
        actual.Red.C21.Should().Be(FaceColor.White);
        actual.Red.C22.Should().Be(FaceColor.Red);
        actual.Red.C23.Should().Be(FaceColor.Red);
        actual.Red.C31.Should().Be(FaceColor.White);
        actual.Red.C32.Should().Be(FaceColor.Green);
        actual.Red.C33.Should().Be(FaceColor.Green);
    }
}
