namespace LDZ.RubikSolver.Test;

public class TurnClockwiseUnitTest
{
    private RubikCube Cube { get; } = RubikCube.Solved();

    [Fact]
    public void White()
    {
        var actual = Cube.Turn(new Move(MoveKind.White, true));
        actual.Should().NotBeSameAs(Cube);

        actual.White.Should().AllSatisfy(f => f.Should().Be(FaceColor.White));
        actual.Yellow.Should().AllSatisfy(f => f.Should().Be(FaceColor.Yellow));

        actual.Blue.C11.Should().Be(FaceColor.Orange);
        actual.Blue.C12.Should().Be(FaceColor.Orange);
        actual.Blue.C13.Should().Be(FaceColor.Orange);
        actual.Blue.C21.Should().Be(FaceColor.Blue);
        actual.Blue.C22.Should().Be(FaceColor.Blue);
        actual.Blue.C23.Should().Be(FaceColor.Blue);
        actual.Blue.C31.Should().Be(FaceColor.Blue);
        actual.Blue.C32.Should().Be(FaceColor.Blue);
        actual.Blue.C33.Should().Be(FaceColor.Blue);

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
        actual.Green.C13.Should().Be(FaceColor.Green);
        actual.Green.C21.Should().Be(FaceColor.Green);
        actual.Green.C22.Should().Be(FaceColor.Green);
        actual.Green.C23.Should().Be(FaceColor.Green);
        actual.Green.C31.Should().Be(FaceColor.Red);
        actual.Green.C32.Should().Be(FaceColor.Red);
        actual.Green.C33.Should().Be(FaceColor.Red);

        actual.Orange.C11.Should().Be(FaceColor.Green);
        actual.Orange.C12.Should().Be(FaceColor.Orange);
        actual.Orange.C13.Should().Be(FaceColor.Orange);
        actual.Orange.C21.Should().Be(FaceColor.Green);
        actual.Orange.C22.Should().Be(FaceColor.Orange);
        actual.Orange.C23.Should().Be(FaceColor.Orange);
        actual.Orange.C31.Should().Be(FaceColor.Green);
        actual.Orange.C32.Should().Be(FaceColor.Orange);
        actual.Orange.C33.Should().Be(FaceColor.Orange);
    }

    [Fact]
    public void Yellow()
    {
        var actual = Cube.Turn(new Move(MoveKind.Yellow, true));
        actual.Should().NotBeSameAs(Cube);

        actual.Yellow.Should().AllSatisfy(f => f.Should().Be(FaceColor.Yellow));
        actual.White.Should().AllSatisfy(f => f.Should().Be(FaceColor.White));

        actual.Blue.C11.Should().Be(FaceColor.Blue);
        actual.Blue.C12.Should().Be(FaceColor.Blue);
        actual.Blue.C13.Should().Be(FaceColor.Blue);
        actual.Blue.C21.Should().Be(FaceColor.Blue);
        actual.Blue.C22.Should().Be(FaceColor.Blue);
        actual.Blue.C23.Should().Be(FaceColor.Blue);
        actual.Blue.C31.Should().Be(FaceColor.Red);
        actual.Blue.C32.Should().Be(FaceColor.Red);
        actual.Blue.C33.Should().Be(FaceColor.Red);

        actual.Red.C11.Should().Be(FaceColor.Green);
        actual.Red.C12.Should().Be(FaceColor.Red);
        actual.Red.C13.Should().Be(FaceColor.Red);
        actual.Red.C21.Should().Be(FaceColor.Green);
        actual.Red.C22.Should().Be(FaceColor.Red);
        actual.Red.C23.Should().Be(FaceColor.Red);
        actual.Red.C31.Should().Be(FaceColor.Green);
        actual.Red.C32.Should().Be(FaceColor.Red);
        actual.Red.C33.Should().Be(FaceColor.Red);

        actual.Green.C11.Should().Be(FaceColor.Orange);
        actual.Green.C12.Should().Be(FaceColor.Orange);
        actual.Green.C13.Should().Be(FaceColor.Orange);
        actual.Green.C21.Should().Be(FaceColor.Green);
        actual.Green.C22.Should().Be(FaceColor.Green);
        actual.Green.C23.Should().Be(FaceColor.Green);
        actual.Green.C31.Should().Be(FaceColor.Green);
        actual.Green.C32.Should().Be(FaceColor.Green);
        actual.Green.C33.Should().Be(FaceColor.Green);

        actual.Orange.C11.Should().Be(FaceColor.Orange);
        actual.Orange.C12.Should().Be(FaceColor.Orange);
        actual.Orange.C13.Should().Be(FaceColor.Blue);
        actual.Orange.C21.Should().Be(FaceColor.Orange);
        actual.Orange.C22.Should().Be(FaceColor.Orange);
        actual.Orange.C23.Should().Be(FaceColor.Blue);
        actual.Orange.C31.Should().Be(FaceColor.Orange);
        actual.Orange.C32.Should().Be(FaceColor.Orange);
        actual.Orange.C33.Should().Be(FaceColor.Blue);
    }

    [Fact]
    public void Blue()
    {
        var actual = Cube.Turn(new Move(MoveKind.Blue, true));
        actual.Should().NotBeSameAs(Cube);

        actual.Blue.Should().AllSatisfy(f => f.Should().Be(FaceColor.Blue));
        actual.Green.Should().AllSatisfy(f => f.Should().Be(FaceColor.Green));

        actual.White.C11.Should().Be(FaceColor.White);
        actual.White.C12.Should().Be(FaceColor.White);
        actual.White.C13.Should().Be(FaceColor.White);
        actual.White.C21.Should().Be(FaceColor.White);
        actual.White.C22.Should().Be(FaceColor.White);
        actual.White.C23.Should().Be(FaceColor.White);
        actual.White.C31.Should().Be(FaceColor.Red);
        actual.White.C32.Should().Be(FaceColor.Red);
        actual.White.C33.Should().Be(FaceColor.Red);

        actual.Red.C11.Should().Be(FaceColor.Red);
        actual.Red.C12.Should().Be(FaceColor.Red);
        actual.Red.C13.Should().Be(FaceColor.Red);
        actual.Red.C21.Should().Be(FaceColor.Red);
        actual.Red.C22.Should().Be(FaceColor.Red);
        actual.Red.C23.Should().Be(FaceColor.Red);
        actual.Red.C31.Should().Be(FaceColor.Yellow);
        actual.Red.C32.Should().Be(FaceColor.Yellow);
        actual.Red.C33.Should().Be(FaceColor.Yellow);

        actual.Orange.C11.Should().Be(FaceColor.Orange);
        actual.Orange.C12.Should().Be(FaceColor.Orange);
        actual.Orange.C13.Should().Be(FaceColor.Orange);
        actual.Orange.C21.Should().Be(FaceColor.Orange);
        actual.Orange.C22.Should().Be(FaceColor.Orange);
        actual.Orange.C23.Should().Be(FaceColor.Orange);
        actual.Orange.C31.Should().Be(FaceColor.White);
        actual.Orange.C32.Should().Be(FaceColor.White);
        actual.Orange.C33.Should().Be(FaceColor.White);

        actual.Yellow.C11.Should().Be(FaceColor.Yellow);
        actual.Yellow.C12.Should().Be(FaceColor.Yellow);
        actual.Yellow.C13.Should().Be(FaceColor.Yellow);
        actual.Yellow.C21.Should().Be(FaceColor.Yellow);
        actual.Yellow.C22.Should().Be(FaceColor.Yellow);
        actual.Yellow.C23.Should().Be(FaceColor.Yellow);
        actual.Yellow.C31.Should().Be(FaceColor.Orange);
        actual.Yellow.C32.Should().Be(FaceColor.Orange);
        actual.Yellow.C33.Should().Be(FaceColor.Orange);
    }

    [Fact]
    public void Orange()
    {
        var actual = Cube.Turn(new Move(MoveKind.Orange, true));
        actual.Should().NotBeSameAs(Cube);

        actual.Orange.Should().AllSatisfy(f => f.Should().Be(FaceColor.Orange));
        actual.Red.Should().AllSatisfy(f => f.Should().Be(FaceColor.Red));

        actual.White.C11.Should().Be(FaceColor.White);
        actual.White.C12.Should().Be(FaceColor.White);
        actual.White.C13.Should().Be(FaceColor.Blue);
        actual.White.C21.Should().Be(FaceColor.White);
        actual.White.C22.Should().Be(FaceColor.White);
        actual.White.C23.Should().Be(FaceColor.Blue);
        actual.White.C31.Should().Be(FaceColor.White);
        actual.White.C32.Should().Be(FaceColor.White);
        actual.White.C33.Should().Be(FaceColor.Blue);

        actual.Green.C11.Should().Be(FaceColor.Green);
        actual.Green.C12.Should().Be(FaceColor.Green);
        actual.Green.C13.Should().Be(FaceColor.White);
        actual.Green.C21.Should().Be(FaceColor.Green);
        actual.Green.C22.Should().Be(FaceColor.Green);
        actual.Green.C23.Should().Be(FaceColor.White);
        actual.Green.C31.Should().Be(FaceColor.Green);
        actual.Green.C32.Should().Be(FaceColor.Green);
        actual.Green.C33.Should().Be(FaceColor.White);

        actual.Blue.C11.Should().Be(FaceColor.Blue);
        actual.Blue.C12.Should().Be(FaceColor.Blue);
        actual.Blue.C13.Should().Be(FaceColor.Yellow);
        actual.Blue.C21.Should().Be(FaceColor.Blue);
        actual.Blue.C22.Should().Be(FaceColor.Blue);
        actual.Blue.C23.Should().Be(FaceColor.Yellow);
        actual.Blue.C31.Should().Be(FaceColor.Blue);
        actual.Blue.C32.Should().Be(FaceColor.Blue);
        actual.Blue.C33.Should().Be(FaceColor.Yellow);

        actual.Yellow.C11.Should().Be(FaceColor.Green);
        actual.Yellow.C12.Should().Be(FaceColor.Yellow);
        actual.Yellow.C13.Should().Be(FaceColor.Yellow);
        actual.Yellow.C21.Should().Be(FaceColor.Green);
        actual.Yellow.C22.Should().Be(FaceColor.Yellow);
        actual.Yellow.C23.Should().Be(FaceColor.Yellow);
        actual.Yellow.C31.Should().Be(FaceColor.Green);
        actual.Yellow.C32.Should().Be(FaceColor.Yellow);
        actual.Yellow.C33.Should().Be(FaceColor.Yellow);
    }

    [Fact]
    public void Green()
    {
        var actual = Cube.Turn(new Move(MoveKind.Green, true));
        actual.Should().NotBeSameAs(Cube);

        actual.Green.Should().AllSatisfy(f => f.Should().Be(FaceColor.Green));
        actual.Blue.Should().AllSatisfy(f => f.Should().Be(FaceColor.Blue));

        actual.White.C11.Should().Be(FaceColor.Orange);
        actual.White.C12.Should().Be(FaceColor.Orange);
        actual.White.C13.Should().Be(FaceColor.Orange);
        actual.White.C21.Should().Be(FaceColor.White);
        actual.White.C22.Should().Be(FaceColor.White);
        actual.White.C23.Should().Be(FaceColor.White);
        actual.White.C31.Should().Be(FaceColor.White);
        actual.White.C32.Should().Be(FaceColor.White);
        actual.White.C33.Should().Be(FaceColor.White);

        actual.Red.C11.Should().Be(FaceColor.White);
        actual.Red.C12.Should().Be(FaceColor.White);
        actual.Red.C13.Should().Be(FaceColor.White);
        actual.Red.C21.Should().Be(FaceColor.Red);
        actual.Red.C22.Should().Be(FaceColor.Red);
        actual.Red.C23.Should().Be(FaceColor.Red);
        actual.Red.C31.Should().Be(FaceColor.Red);
        actual.Red.C32.Should().Be(FaceColor.Red);
        actual.Red.C33.Should().Be(FaceColor.Red);

        actual.Orange.C11.Should().Be(FaceColor.Yellow);
        actual.Orange.C12.Should().Be(FaceColor.Yellow);
        actual.Orange.C13.Should().Be(FaceColor.Yellow);
        actual.Orange.C21.Should().Be(FaceColor.Orange);
        actual.Orange.C22.Should().Be(FaceColor.Orange);
        actual.Orange.C23.Should().Be(FaceColor.Orange);
        actual.Orange.C31.Should().Be(FaceColor.Orange);
        actual.Orange.C32.Should().Be(FaceColor.Orange);
        actual.Orange.C33.Should().Be(FaceColor.Orange);

        actual.Yellow.C11.Should().Be(FaceColor.Red);
        actual.Yellow.C12.Should().Be(FaceColor.Red);
        actual.Yellow.C13.Should().Be(FaceColor.Red);
        actual.Yellow.C21.Should().Be(FaceColor.Yellow);
        actual.Yellow.C22.Should().Be(FaceColor.Yellow);
        actual.Yellow.C23.Should().Be(FaceColor.Yellow);
        actual.Yellow.C31.Should().Be(FaceColor.Yellow);
        actual.Yellow.C32.Should().Be(FaceColor.Yellow);
        actual.Yellow.C33.Should().Be(FaceColor.Yellow);
    }

    [Fact]
    public void Red()
    {
        var actual = Cube.Turn(new Move(MoveKind.Red, true));
        actual.Should().NotBeSameAs(Cube);

        actual.Red.Should().AllSatisfy(f => f.Should().Be(FaceColor.Red));
        actual.Orange.Should().AllSatisfy(f => f.Should().Be(FaceColor.Orange));

        actual.White.C11.Should().Be(FaceColor.Green);
        actual.White.C12.Should().Be(FaceColor.White);
        actual.White.C13.Should().Be(FaceColor.White);
        actual.White.C21.Should().Be(FaceColor.Green);
        actual.White.C22.Should().Be(FaceColor.White);
        actual.White.C23.Should().Be(FaceColor.White);
        actual.White.C31.Should().Be(FaceColor.Green);
        actual.White.C32.Should().Be(FaceColor.White);
        actual.White.C33.Should().Be(FaceColor.White);

        actual.Blue.C11.Should().Be(FaceColor.White);
        actual.Blue.C12.Should().Be(FaceColor.Blue);
        actual.Blue.C13.Should().Be(FaceColor.Blue);
        actual.Blue.C21.Should().Be(FaceColor.White);
        actual.Blue.C22.Should().Be(FaceColor.Blue);
        actual.Blue.C23.Should().Be(FaceColor.Blue);
        actual.Blue.C31.Should().Be(FaceColor.White);
        actual.Blue.C32.Should().Be(FaceColor.Blue);
        actual.Blue.C33.Should().Be(FaceColor.Blue);

        actual.Green.C11.Should().Be(FaceColor.Yellow);
        actual.Green.C12.Should().Be(FaceColor.Green);
        actual.Green.C13.Should().Be(FaceColor.Green);
        actual.Green.C21.Should().Be(FaceColor.Yellow);
        actual.Green.C22.Should().Be(FaceColor.Green);
        actual.Green.C23.Should().Be(FaceColor.Green);
        actual.Green.C31.Should().Be(FaceColor.Yellow);
        actual.Green.C32.Should().Be(FaceColor.Green);
        actual.Green.C33.Should().Be(FaceColor.Green);

        actual.Yellow.C11.Should().Be(FaceColor.Yellow);
        actual.Yellow.C12.Should().Be(FaceColor.Yellow);
        actual.Yellow.C13.Should().Be(FaceColor.Blue);
        actual.Yellow.C21.Should().Be(FaceColor.Yellow);
        actual.Yellow.C22.Should().Be(FaceColor.Yellow);
        actual.Yellow.C23.Should().Be(FaceColor.Blue);
        actual.Yellow.C31.Should().Be(FaceColor.Yellow);
        actual.Yellow.C32.Should().Be(FaceColor.Yellow);
        actual.Yellow.C33.Should().Be(FaceColor.Blue);
    }
}
