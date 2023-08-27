namespace LDZ.RubikSolver.Test;

public class TurnCounterClockwiseOrtoUnitTest
{
    private RubikCube Cube { get; } = RubikCube.Solved();

    [Fact]
    public void WhiteGreen()
    {
        var actual = Cube
            .WhiteCounterClockwise()
            .GreenCounterClockwise();
        actual.Should().NotBeSameAs(Cube);

        actual.White.C11.Should().Be(FaceColor.White);
        actual.White.C12.Should().Be(FaceColor.White);
        actual.White.C13.Should().Be(FaceColor.Red);
        actual.White.C21.Should().Be(FaceColor.White);
        actual.White.C22.Should().Be(FaceColor.White);
        actual.White.C23.Should().Be(FaceColor.Red);
        actual.White.C31.Should().Be(FaceColor.White);
        actual.White.C32.Should().Be(FaceColor.White);
        actual.White.C33.Should().Be(FaceColor.Green);

        actual.Green.C11.Should().Be(FaceColor.Orange);
        actual.Green.C12.Should().Be(FaceColor.Green);
        actual.Green.C13.Should().Be(FaceColor.Green);
        actual.Green.C21.Should().Be(FaceColor.Orange);
        actual.Green.C22.Should().Be(FaceColor.Green);
        actual.Green.C23.Should().Be(FaceColor.Green);
        actual.Green.C31.Should().Be(FaceColor.Orange);
        actual.Green.C32.Should().Be(FaceColor.Green);
        actual.Green.C33.Should().Be(FaceColor.Green);

        actual.Red.C11.Should().Be(FaceColor.Yellow);
        actual.Red.C12.Should().Be(FaceColor.Green);
        actual.Red.C13.Should().Be(FaceColor.Green);
        actual.Red.C21.Should().Be(FaceColor.Yellow);
        actual.Red.C22.Should().Be(FaceColor.Red);
        actual.Red.C23.Should().Be(FaceColor.Red);
        actual.Red.C31.Should().Be(FaceColor.Yellow);
        actual.Red.C32.Should().Be(FaceColor.Red);
        actual.Red.C33.Should().Be(FaceColor.Red);
    }

    [Fact]
    public void WhiteOrange()
    {
        var actual = Cube
            .WhiteCounterClockwise()
            .OrangeCounterClockwise();
        actual.Should().NotBeSameAs(Cube);

        actual.White.C11.Should().Be(FaceColor.White);
        actual.White.C12.Should().Be(FaceColor.White);
        actual.White.C13.Should().Be(FaceColor.White);
        actual.White.C21.Should().Be(FaceColor.White);
        actual.White.C22.Should().Be(FaceColor.White);
        actual.White.C23.Should().Be(FaceColor.White);
        actual.White.C31.Should().Be(FaceColor.Orange);
        actual.White.C32.Should().Be(FaceColor.Green);
        actual.White.C33.Should().Be(FaceColor.Green);

        actual.Orange.C11.Should().Be(FaceColor.Blue);
        actual.Orange.C12.Should().Be(FaceColor.Orange);
        actual.Orange.C13.Should().Be(FaceColor.Orange);
        actual.Orange.C21.Should().Be(FaceColor.Blue);
        actual.Orange.C22.Should().Be(FaceColor.Orange);
        actual.Orange.C23.Should().Be(FaceColor.Orange);
        actual.Orange.C31.Should().Be(FaceColor.Blue);
        actual.Orange.C32.Should().Be(FaceColor.Orange);
        actual.Orange.C33.Should().Be(FaceColor.Orange);

        actual.Green.C11.Should().Be(FaceColor.Yellow);
        actual.Green.C12.Should().Be(FaceColor.Orange);
        actual.Green.C13.Should().Be(FaceColor.Orange);
        actual.Green.C21.Should().Be(FaceColor.Yellow);
        actual.Green.C22.Should().Be(FaceColor.Green);
        actual.Green.C23.Should().Be(FaceColor.Green);
        actual.Green.C31.Should().Be(FaceColor.Yellow);
        actual.Green.C32.Should().Be(FaceColor.Green);
        actual.Green.C33.Should().Be(FaceColor.Green);
    }

    [Fact]
    public void WhiteBlue()
    {
        var actual = Cube
            .WhiteCounterClockwise()
            .BlueCounterClockwise();
        actual.Should().NotBeSameAs(Cube);

        actual.White.C11.Should().Be(FaceColor.Blue);
        actual.White.C12.Should().Be(FaceColor.White);
        actual.White.C13.Should().Be(FaceColor.White);
        actual.White.C21.Should().Be(FaceColor.Orange);
        actual.White.C22.Should().Be(FaceColor.White);
        actual.White.C23.Should().Be(FaceColor.White);
        actual.White.C31.Should().Be(FaceColor.Orange);
        actual.White.C32.Should().Be(FaceColor.White);
        actual.White.C33.Should().Be(FaceColor.White);

        actual.Blue.C11.Should().Be(FaceColor.Red);
        actual.Blue.C12.Should().Be(FaceColor.Blue);
        actual.Blue.C13.Should().Be(FaceColor.Blue);
        actual.Blue.C21.Should().Be(FaceColor.Red);
        actual.Blue.C22.Should().Be(FaceColor.Blue);
        actual.Blue.C23.Should().Be(FaceColor.Blue);
        actual.Blue.C31.Should().Be(FaceColor.Red);
        actual.Blue.C32.Should().Be(FaceColor.Blue);
        actual.Blue.C33.Should().Be(FaceColor.Blue);

        actual.Orange.C11.Should().Be(FaceColor.Yellow);
        actual.Orange.C12.Should().Be(FaceColor.Blue);
        actual.Orange.C13.Should().Be(FaceColor.Blue);
        actual.Orange.C21.Should().Be(FaceColor.Yellow);
        actual.Orange.C22.Should().Be(FaceColor.Orange);
        actual.Orange.C23.Should().Be(FaceColor.Orange);
        actual.Orange.C31.Should().Be(FaceColor.Yellow);
        actual.Orange.C32.Should().Be(FaceColor.Orange);
        actual.Orange.C33.Should().Be(FaceColor.Orange);
    }

    [Fact]
    public void WhiteRed()
    {
        var actual = Cube
            .WhiteCounterClockwise()
            .RedCounterClockwise();
        actual.Should().NotBeSameAs(Cube);

        actual.White.C11.Should().Be(FaceColor.Blue);
        actual.White.C12.Should().Be(FaceColor.Blue);
        actual.White.C13.Should().Be(FaceColor.Red);
        actual.White.C21.Should().Be(FaceColor.White);
        actual.White.C22.Should().Be(FaceColor.White);
        actual.White.C23.Should().Be(FaceColor.White);
        actual.White.C31.Should().Be(FaceColor.White);
        actual.White.C32.Should().Be(FaceColor.White);
        actual.White.C33.Should().Be(FaceColor.White);

        actual.Red.C11.Should().Be(FaceColor.Green);
        actual.Red.C12.Should().Be(FaceColor.Red);
        actual.Red.C13.Should().Be(FaceColor.Red);
        actual.Red.C21.Should().Be(FaceColor.Green);
        actual.Red.C22.Should().Be(FaceColor.Red);
        actual.Red.C23.Should().Be(FaceColor.Red);
        actual.Red.C31.Should().Be(FaceColor.Green);
        actual.Red.C32.Should().Be(FaceColor.Red);
        actual.Red.C33.Should().Be(FaceColor.Red);

        actual.Blue.C11.Should().Be(FaceColor.Yellow);
        actual.Blue.C12.Should().Be(FaceColor.Red);
        actual.Blue.C13.Should().Be(FaceColor.Red);
        actual.Blue.C21.Should().Be(FaceColor.Yellow);
        actual.Blue.C22.Should().Be(FaceColor.Blue);
        actual.Blue.C23.Should().Be(FaceColor.Blue);
        actual.Blue.C31.Should().Be(FaceColor.Yellow);
        actual.Blue.C32.Should().Be(FaceColor.Blue);
        actual.Blue.C33.Should().Be(FaceColor.Blue);
    }

    [Fact]
    public void YellowRed()
    {
        var actual = Cube
            .YellowCounterClockwise()
            .RedCounterClockwise();
        actual.Should().NotBeSameAs(Cube);

        actual.Yellow.C11.Should().Be(FaceColor.Yellow);
        actual.Yellow.C12.Should().Be(FaceColor.Yellow);
        actual.Yellow.C13.Should().Be(FaceColor.Yellow);
        actual.Yellow.C21.Should().Be(FaceColor.Yellow);
        actual.Yellow.C22.Should().Be(FaceColor.Yellow);
        actual.Yellow.C23.Should().Be(FaceColor.Yellow);
        actual.Yellow.C31.Should().Be(FaceColor.Red);
        actual.Yellow.C32.Should().Be(FaceColor.Green);
        actual.Yellow.C33.Should().Be(FaceColor.Green);

        actual.Red.C11.Should().Be(FaceColor.Red);
        actual.Red.C12.Should().Be(FaceColor.Red);
        actual.Red.C13.Should().Be(FaceColor.Blue);
        actual.Red.C21.Should().Be(FaceColor.Red);
        actual.Red.C22.Should().Be(FaceColor.Red);
        actual.Red.C23.Should().Be(FaceColor.Blue);
        actual.Red.C31.Should().Be(FaceColor.Red);
        actual.Red.C32.Should().Be(FaceColor.Red);
        actual.Red.C33.Should().Be(FaceColor.Blue);

        actual.Green.C11.Should().Be(FaceColor.Green);
        actual.Green.C12.Should().Be(FaceColor.Green);
        actual.Green.C13.Should().Be(FaceColor.White);
        actual.Green.C21.Should().Be(FaceColor.Green);
        actual.Green.C22.Should().Be(FaceColor.Green);
        actual.Green.C23.Should().Be(FaceColor.White);
        actual.Green.C31.Should().Be(FaceColor.Red);
        actual.Green.C32.Should().Be(FaceColor.Red);
        actual.Green.C33.Should().Be(FaceColor.White);
    }

    [Fact]
    public void YellowBlue()
    {
        var actual = Cube
            .YellowCounterClockwise()
            .BlueCounterClockwise();
        actual.Should().NotBeSameAs(Cube);

        actual.Yellow.C11.Should().Be(FaceColor.Blue);
        actual.Yellow.C12.Should().Be(FaceColor.Yellow);
        actual.Yellow.C13.Should().Be(FaceColor.Yellow);
        actual.Yellow.C21.Should().Be(FaceColor.Red);
        actual.Yellow.C22.Should().Be(FaceColor.Yellow);
        actual.Yellow.C23.Should().Be(FaceColor.Yellow);
        actual.Yellow.C31.Should().Be(FaceColor.Red);
        actual.Yellow.C32.Should().Be(FaceColor.Yellow);
        actual.Yellow.C33.Should().Be(FaceColor.Yellow);

        actual.Blue.C11.Should().Be(FaceColor.Blue);
        actual.Blue.C12.Should().Be(FaceColor.Blue);
        actual.Blue.C13.Should().Be(FaceColor.Orange);
        actual.Blue.C21.Should().Be(FaceColor.Blue);
        actual.Blue.C22.Should().Be(FaceColor.Blue);
        actual.Blue.C23.Should().Be(FaceColor.Orange);
        actual.Blue.C31.Should().Be(FaceColor.Blue);
        actual.Blue.C32.Should().Be(FaceColor.Blue);
        actual.Blue.C33.Should().Be(FaceColor.Orange);
    }

    [Fact]
    public void YellowOrange()
    {
        var actual = Cube
            .YellowCounterClockwise()
            .OrangeCounterClockwise();
        actual.Should().NotBeSameAs(Cube);

        actual.Yellow.C11.Should().Be(FaceColor.Blue);
        actual.Yellow.C12.Should().Be(FaceColor.Blue);
        actual.Yellow.C13.Should().Be(FaceColor.Orange);
        actual.Yellow.C21.Should().Be(FaceColor.Yellow);
        actual.Yellow.C22.Should().Be(FaceColor.Yellow);
        actual.Yellow.C23.Should().Be(FaceColor.Yellow);
        actual.Yellow.C31.Should().Be(FaceColor.Yellow);
        actual.Yellow.C32.Should().Be(FaceColor.Yellow);
        actual.Yellow.C33.Should().Be(FaceColor.Yellow);

        actual.Orange.C11.Should().Be(FaceColor.Orange);
        actual.Orange.C12.Should().Be(FaceColor.Orange);
        actual.Orange.C13.Should().Be(FaceColor.Green);
        actual.Orange.C21.Should().Be(FaceColor.Orange);
        actual.Orange.C22.Should().Be(FaceColor.Orange);
        actual.Orange.C23.Should().Be(FaceColor.Green);
        actual.Orange.C31.Should().Be(FaceColor.Orange);
        actual.Orange.C32.Should().Be(FaceColor.Orange);
        actual.Orange.C33.Should().Be(FaceColor.Green);
    }

    [Fact]
    public void YellowGreen()
    {
        var actual = Cube
            .YellowCounterClockwise()
            .GreenCounterClockwise();
        actual.Should().NotBeSameAs(Cube);

        actual.Yellow.C11.Should().Be(FaceColor.Yellow);
        actual.Yellow.C12.Should().Be(FaceColor.Yellow);
        actual.Yellow.C13.Should().Be(FaceColor.Orange);
        actual.Yellow.C21.Should().Be(FaceColor.Yellow);
        actual.Yellow.C22.Should().Be(FaceColor.Yellow);
        actual.Yellow.C23.Should().Be(FaceColor.Orange);
        actual.Yellow.C31.Should().Be(FaceColor.Yellow);
        actual.Yellow.C32.Should().Be(FaceColor.Yellow);
        actual.Yellow.C33.Should().Be(FaceColor.Green);

        actual.Green.C11.Should().Be(FaceColor.Green);
        actual.Green.C12.Should().Be(FaceColor.Green);
        actual.Green.C13.Should().Be(FaceColor.Red);
        actual.Green.C21.Should().Be(FaceColor.Green);
        actual.Green.C22.Should().Be(FaceColor.Green);
        actual.Green.C23.Should().Be(FaceColor.Red);
        actual.Green.C31.Should().Be(FaceColor.Green);
        actual.Green.C32.Should().Be(FaceColor.Green);
        actual.Green.C33.Should().Be(FaceColor.Red);
    }
}
