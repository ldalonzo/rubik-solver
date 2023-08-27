namespace LDZ.RubikSolver.Test;

public class InitialCubeUnitTest
{
    private RubikCube Cube { get; } = RubikCube.Solved();

    [Fact]
    public void WhiteFace()
    {
        Cube.White.C11.Should().Be(FaceColor.White);
        Cube.White.C12.Should().Be(FaceColor.White);
        Cube.White.C13.Should().Be(FaceColor.White);
        Cube.White.C21.Should().Be(FaceColor.White);
        Cube.White.C22.Should().Be(FaceColor.White);
        Cube.White.C23.Should().Be(FaceColor.White);
        Cube.White.C31.Should().Be(FaceColor.White);
        Cube.White.C32.Should().Be(FaceColor.White);
        Cube.White.C33.Should().Be(FaceColor.White);
    }

    [Fact]
    public void BlueFace()
    {
        Cube.Blue.C11.Should().Be(FaceColor.Blue);
        Cube.Blue.C12.Should().Be(FaceColor.Blue);
        Cube.Blue.C13.Should().Be(FaceColor.Blue);
        Cube.Blue.C21.Should().Be(FaceColor.Blue);
        Cube.Blue.C22.Should().Be(FaceColor.Blue);
        Cube.Blue.C23.Should().Be(FaceColor.Blue);
        Cube.Blue.C31.Should().Be(FaceColor.Blue);
        Cube.Blue.C32.Should().Be(FaceColor.Blue);
        Cube.Blue.C33.Should().Be(FaceColor.Blue);
    }

    [Fact]
    public void OrangeFace()
    {
        Cube.Orange.C11.Should().Be(FaceColor.Orange);
        Cube.Orange.C12.Should().Be(FaceColor.Orange);
        Cube.Orange.C13.Should().Be(FaceColor.Orange);
        Cube.Orange.C21.Should().Be(FaceColor.Orange);
        Cube.Orange.C22.Should().Be(FaceColor.Orange);
        Cube.Orange.C23.Should().Be(FaceColor.Orange);
        Cube.Orange.C31.Should().Be(FaceColor.Orange);
        Cube.Orange.C32.Should().Be(FaceColor.Orange);
        Cube.Orange.C33.Should().Be(FaceColor.Orange);
    }

    [Fact]
    public void RedFace()
    {
        Cube.Red.C11.Should().Be(FaceColor.Red);
        Cube.Red.C12.Should().Be(FaceColor.Red);
        Cube.Red.C13.Should().Be(FaceColor.Red);
        Cube.Red.C21.Should().Be(FaceColor.Red);
        Cube.Red.C22.Should().Be(FaceColor.Red);
        Cube.Red.C23.Should().Be(FaceColor.Red);
        Cube.Red.C31.Should().Be(FaceColor.Red);
        Cube.Red.C32.Should().Be(FaceColor.Red);
        Cube.Red.C33.Should().Be(FaceColor.Red);
    }

    [Fact]
    public void GreenFace()
    {
        Cube.Green.C11.Should().Be(FaceColor.Green);
        Cube.Green.C12.Should().Be(FaceColor.Green);
        Cube.Green.C13.Should().Be(FaceColor.Green);
        Cube.Green.C21.Should().Be(FaceColor.Green);
        Cube.Green.C22.Should().Be(FaceColor.Green);
        Cube.Green.C23.Should().Be(FaceColor.Green);
        Cube.Green.C31.Should().Be(FaceColor.Green);
        Cube.Green.C32.Should().Be(FaceColor.Green);
        Cube.Green.C33.Should().Be(FaceColor.Green);
    }

    [Fact]
    public void YellowFace()
    {
        Cube.Yellow.C11.Should().Be(FaceColor.Yellow);
        Cube.Yellow.C12.Should().Be(FaceColor.Yellow);
        Cube.Yellow.C13.Should().Be(FaceColor.Yellow);
        Cube.Yellow.C21.Should().Be(FaceColor.Yellow);
        Cube.Yellow.C22.Should().Be(FaceColor.Yellow);
        Cube.Yellow.C23.Should().Be(FaceColor.Yellow);
        Cube.Yellow.C31.Should().Be(FaceColor.Yellow);
        Cube.Yellow.C32.Should().Be(FaceColor.Yellow);
        Cube.Yellow.C33.Should().Be(FaceColor.Yellow);
    }
}
