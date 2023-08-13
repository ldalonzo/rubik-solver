namespace LDZ.RubikSolver.Test;

public class UnitTest1
{
    [Fact]
    public void InitialCube_White()
    {
        var cube = new RubikCube();
        cube.Should().NotBeNull();

        cube.Top.Should().NotBeNull();
        cube.Top.C12.Should().Be(FaceColor.White);

        cube.Top.C21.Should().Be(FaceColor.White);
        cube.Top.C22.Should().Be(FaceColor.White);
        cube.Top.C23.Should().Be(FaceColor.White);
    }

    [Fact]
    public void InitialCube_Blue()
    {
        var cube = new RubikCube();
        cube.Should().NotBeNull();

        cube.Front.Should().NotBeNull();
        cube.Front.C12.Should().Be(FaceColor.Blue);

        cube.Front.C21.Should().Be(FaceColor.Blue);
        cube.Front.C22.Should().Be(FaceColor.Blue);
        cube.Front.C23.Should().Be(FaceColor.Blue);
    }

    [Fact]
    public void InitialCube_Red()
    {
        var cube = new RubikCube();
        cube.Should().NotBeNull();

        cube.Left.Should().NotBeNull();
        cube.Left.C12.Should().Be(FaceColor.Red);

        cube.Left.C21.Should().Be(FaceColor.Red);
        cube.Left.C22.Should().Be(FaceColor.Red);
        cube.Left.C23.Should().Be(FaceColor.Red);
    }

    [Fact]
    public void InitialCube_Orange()
    {
        var cube = new RubikCube();
        cube.Should().NotBeNull();

        cube.Right.Should().NotBeNull();
        cube.Right.C12.Should().Be(FaceColor.Orange);

        cube.Right.C21.Should().Be(FaceColor.Orange);
        cube.Right.C22.Should().Be(FaceColor.Orange);
        cube.Right.C23.Should().Be(FaceColor.Orange);
    }

    [Fact]
    public void InitialCube_Green()
    {
        var cube = new RubikCube();
        cube.Should().NotBeNull();

        cube.Back.Should().NotBeNull();
        cube.Back.C12.Should().Be(FaceColor.Green);

        cube.Back.C21.Should().Be(FaceColor.Green);
        cube.Back.C22.Should().Be(FaceColor.Green);
        cube.Back.C23.Should().Be(FaceColor.Green);
    }

    [Fact]
    public void InitialCube_Yellow()
    {
        var cube = new RubikCube();
        cube.Should().NotBeNull();

        cube.Bottom.Should().NotBeNull();
        cube.Bottom.C12.Should().Be(FaceColor.Yellow);

        cube.Bottom.C21.Should().Be(FaceColor.Yellow);
        cube.Bottom.C22.Should().Be(FaceColor.Yellow);
        cube.Bottom.C23.Should().Be(FaceColor.Yellow);
    }

    [Fact]
    public void TurnLeft()
    {
        var cube = new RubikCube();
        cube.TurnLeft();

        cube.Top.C12.Should().Be(FaceColor.White);
        cube.Top.C21.Should().Be(FaceColor.Green);
        cube.Top.C22.Should().Be(FaceColor.White);
        cube.Top.C23.Should().Be(FaceColor.White);

        cube.Front.C12.Should().Be(FaceColor.Blue);
        cube.Front.C21.Should().Be(FaceColor.White);
        cube.Front.C22.Should().Be(FaceColor.Blue);
        cube.Front.C23.Should().Be(FaceColor.Blue);

        cube.Right.C12.Should().Be(FaceColor.Orange);
        cube.Right.C21.Should().Be(FaceColor.Orange);
        cube.Right.C22.Should().Be(FaceColor.Orange);
        cube.Right.C23.Should().Be(FaceColor.Orange);

        cube.Left.C12.Should().Be(FaceColor.Red);
        cube.Left.C21.Should().Be(FaceColor.Red);
        cube.Left.C22.Should().Be(FaceColor.Red);
        cube.Left.C23.Should().Be(FaceColor.Red);

        cube.Back.C12.Should().Be(FaceColor.Green);
        cube.Back.C21.Should().Be(FaceColor.Green);
        cube.Back.C22.Should().Be(FaceColor.Green);
        cube.Back.C23.Should().Be(FaceColor.Yellow);

        cube.Bottom.C12.Should().Be(FaceColor.Yellow);
        cube.Bottom.C21.Should().Be(FaceColor.Blue);
        cube.Bottom.C22.Should().Be(FaceColor.Yellow);
        cube.Bottom.C23.Should().Be(FaceColor.Yellow);
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
    public void TurnUp()
    {
        var cube = new RubikCube();
        cube.TurnTop();

        cube.Top.C12.Should().Be(FaceColor.White);
        cube.Top.C21.Should().Be(FaceColor.White);
        cube.Top.C22.Should().Be(FaceColor.White);
        cube.Top.C23.Should().Be(FaceColor.White);

        cube.Front.C12.Should().Be(FaceColor.Orange);
        cube.Front.C21.Should().Be(FaceColor.Blue);
        cube.Front.C22.Should().Be(FaceColor.Blue);
        cube.Front.C23.Should().Be(FaceColor.Blue);

        cube.Right.C12.Should().Be(FaceColor.Green);
        cube.Right.C21.Should().Be(FaceColor.Orange);
        cube.Right.C22.Should().Be(FaceColor.Orange);
        cube.Right.C23.Should().Be(FaceColor.Orange);

        cube.Left.C12.Should().Be(FaceColor.Blue);
        cube.Left.C21.Should().Be(FaceColor.Red);
        cube.Left.C22.Should().Be(FaceColor.Red);
        cube.Left.C23.Should().Be(FaceColor.Red);

        cube.Back.C12.Should().Be(FaceColor.Red);
        cube.Back.C21.Should().Be(FaceColor.Green);
        cube.Back.C22.Should().Be(FaceColor.Green);
        cube.Back.C23.Should().Be(FaceColor.Green);

        cube.Bottom.C12.Should().Be(FaceColor.Yellow);
        cube.Bottom.C21.Should().Be(FaceColor.Yellow);
        cube.Bottom.C22.Should().Be(FaceColor.Yellow);
        cube.Bottom.C23.Should().Be(FaceColor.Yellow);
    }

    [Fact]
    public void TurnFront()
    {
        var cube = new RubikCube();
        cube.TurnFront();

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
}
