namespace LDZ.RubikSolver.Test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var cube = new RubikCube();
        cube.Should().NotBeNull();

        cube.Top.Should().NotBeNull();
        cube.Top.C12.Should().Be(FaceColor.White);
        cube.Top.C22.Should().Be(FaceColor.White);

        cube.Front.Should().NotBeNull();
        cube.Front.C12.Should().Be(FaceColor.Blue);
        cube.Front.C22.Should().Be(FaceColor.Blue);

        cube.Right.Should().NotBeNull();
        cube.Right.C12.Should().Be(FaceColor.Orange);
        cube.Right.C22.Should().Be(FaceColor.Orange);

        cube.Left.Should().NotBeNull();
        cube.Left.C12.Should().Be(FaceColor.Red);
        cube.Left.C22.Should().Be(FaceColor.Red);

        cube.Back.Should().NotBeNull();
        cube.Back.C12.Should().Be(FaceColor.Green);
        cube.Back.C22.Should().Be(FaceColor.Green);

        cube.Bottom.Should().NotBeNull();
        cube.Bottom.C12.Should().Be(FaceColor.Yellow);
        cube.Bottom.C22.Should().Be(FaceColor.Yellow);
    }

    [Fact]
    public void TurnLeft()
    {
        var cube = new RubikCube();
        cube.TurnLeft();

        cube.Top.C12.Should().Be(FaceColor.White);
        cube.Top.C22.Should().Be(FaceColor.White);

        cube.Front.C12.Should().Be(FaceColor.Blue);
        cube.Front.C22.Should().Be(FaceColor.Blue);

        cube.Right.C12.Should().Be(FaceColor.Orange);
        cube.Right.C22.Should().Be(FaceColor.Orange);

        cube.Left.C12.Should().Be(FaceColor.Red);
        cube.Left.C22.Should().Be(FaceColor.Red);

        cube.Back.C12.Should().Be(FaceColor.Green);
        cube.Back.C22.Should().Be(FaceColor.Green);

        cube.Bottom.C12.Should().Be(FaceColor.Yellow);
        cube.Bottom.C22.Should().Be(FaceColor.Yellow);
    }

    [Fact]
    public void TurnRight()
    {
        var cube = new RubikCube();
        cube.TurnRight();

        cube.Top.C12.Should().Be(FaceColor.White);
        cube.Top.C22.Should().Be(FaceColor.White);

        cube.Front.C12.Should().Be(FaceColor.Blue);
        cube.Front.C22.Should().Be(FaceColor.Blue);

        cube.Right.C12.Should().Be(FaceColor.Orange);
        cube.Right.C22.Should().Be(FaceColor.Orange);

        cube.Left.C12.Should().Be(FaceColor.Red);
        cube.Left.C22.Should().Be(FaceColor.Red);

        cube.Back.C12.Should().Be(FaceColor.Green);
        cube.Back.C22.Should().Be(FaceColor.Green);

        cube.Bottom.C12.Should().Be(FaceColor.Yellow);
        cube.Bottom.C22.Should().Be(FaceColor.Yellow);
    }

    [Fact]
    public void TurnTop()
    {
        var cube = new RubikCube();
        cube.TurnTop();

        cube.Top.C12.Should().Be(FaceColor.White);
        cube.Top.C22.Should().Be(FaceColor.White);

        cube.Front.C12.Should().Be(FaceColor.Orange);
        cube.Front.C22.Should().Be(FaceColor.Blue);

        cube.Right.C12.Should().Be(FaceColor.Green);
        cube.Right.C22.Should().Be(FaceColor.Orange);

        cube.Left.C12.Should().Be(FaceColor.Blue);
        cube.Left.C22.Should().Be(FaceColor.Red);

        cube.Back.C12.Should().Be(FaceColor.Red);
        cube.Back.C22.Should().Be(FaceColor.Green);

        cube.Bottom.C12.Should().Be(FaceColor.Yellow);
        cube.Bottom.C22.Should().Be(FaceColor.Yellow);
    }

    [Fact]
    public void TurnFront()
    {
        var cube = new RubikCube();
        cube.TurnFront();

        cube.Top.C22.Should().Be(FaceColor.White);
        cube.Front.C22.Should().Be(FaceColor.Blue);
        cube.Right.C22.Should().Be(FaceColor.Orange);
        cube.Left.C22.Should().Be(FaceColor.Red);
        cube.Back.C22.Should().Be(FaceColor.Green);
        cube.Bottom.C22.Should().Be(FaceColor.Yellow);
    }
}

public record Face(
    FaceColor C12,
    FaceColor C22);


public record CenterPiece(
    FaceColor Color,
    EdgePiece North,
    EdgePiece West,
    EdgePiece South,
    EdgePiece East);

public record EdgePiece(FaceColor Top, FaceColor Front);
