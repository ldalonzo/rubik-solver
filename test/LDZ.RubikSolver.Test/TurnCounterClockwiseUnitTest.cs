﻿namespace LDZ.RubikSolver.Test;

public class TurnCounterClockwiseUnitTest
{
    private RubikCube Cube { get; } = RubikCube.Solved();

    [Fact]
    public void White()
    {
        var actual = Cube
            .Turn(MoveKind.White, false);
        actual.Should().NotBeSameAs(Cube);

        actual.White.C11.Should().Be(FaceColor.White);
        actual.White.C12.Should().Be(FaceColor.White);
        actual.White.C13.Should().Be(FaceColor.White);
        actual.White.C21.Should().Be(FaceColor.White);
        actual.White.C22.Should().Be(FaceColor.White);
        actual.White.C23.Should().Be(FaceColor.White);
        actual.White.C31.Should().Be(FaceColor.White);
        actual.White.C32.Should().Be(FaceColor.White);
        actual.White.C33.Should().Be(FaceColor.White);

        actual.Yellow.C11.Should().Be(FaceColor.Yellow);
        actual.Yellow.C12.Should().Be(FaceColor.Yellow);
        actual.Yellow.C13.Should().Be(FaceColor.Yellow);
        actual.Yellow.C21.Should().Be(FaceColor.Yellow);
        actual.Yellow.C22.Should().Be(FaceColor.Yellow);
        actual.Yellow.C23.Should().Be(FaceColor.Yellow);
        actual.Yellow.C31.Should().Be(FaceColor.Yellow);
        actual.Yellow.C32.Should().Be(FaceColor.Yellow);
        actual.Yellow.C33.Should().Be(FaceColor.Yellow);

        actual.Blue.C11.Should().Be(FaceColor.Red);
        actual.Blue.C12.Should().Be(FaceColor.Red);
        actual.Blue.C13.Should().Be(FaceColor.Red);
        actual.Blue.C21.Should().Be(FaceColor.Blue);
        actual.Blue.C22.Should().Be(FaceColor.Blue);
        actual.Blue.C23.Should().Be(FaceColor.Blue);
        actual.Blue.C31.Should().Be(FaceColor.Blue);
        actual.Blue.C32.Should().Be(FaceColor.Blue);
        actual.Blue.C33.Should().Be(FaceColor.Blue);

        actual.Red.C11.Should().Be(FaceColor.Green);
        actual.Red.C12.Should().Be(FaceColor.Green);
        actual.Red.C13.Should().Be(FaceColor.Green);
        actual.Red.C21.Should().Be(FaceColor.Red);
        actual.Red.C22.Should().Be(FaceColor.Red);
        actual.Red.C23.Should().Be(FaceColor.Red);
        actual.Red.C31.Should().Be(FaceColor.Red);
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

        actual.Orange.C11.Should().Be(FaceColor.Blue);
        actual.Orange.C12.Should().Be(FaceColor.Blue);
        actual.Orange.C13.Should().Be(FaceColor.Blue);
        actual.Orange.C21.Should().Be(FaceColor.Orange);
        actual.Orange.C22.Should().Be(FaceColor.Orange);
        actual.Orange.C23.Should().Be(FaceColor.Orange);
        actual.Orange.C31.Should().Be(FaceColor.Orange);
        actual.Orange.C32.Should().Be(FaceColor.Orange);
        actual.Orange.C33.Should().Be(FaceColor.Orange);
    }

    [Fact]
    public void Yellow()
    {
        var actual = Cube.Turn(MoveKind.Yellow, false);
        actual.Should().NotBeSameAs(Cube);

        actual.Yellow.C11.Should().Be(FaceColor.Yellow);
        actual.Yellow.C12.Should().Be(FaceColor.Yellow);
        actual.Yellow.C13.Should().Be(FaceColor.Yellow);
        actual.Yellow.C21.Should().Be(FaceColor.Yellow);
        actual.Yellow.C22.Should().Be(FaceColor.Yellow);
        actual.Yellow.C23.Should().Be(FaceColor.Yellow);
        actual.Yellow.C31.Should().Be(FaceColor.Yellow);
        actual.Yellow.C32.Should().Be(FaceColor.Yellow);
        actual.Yellow.C33.Should().Be(FaceColor.Yellow);

        actual.White.C11.Should().Be(FaceColor.White);
        actual.White.C12.Should().Be(FaceColor.White);
        actual.White.C13.Should().Be(FaceColor.White);
        actual.White.C21.Should().Be(FaceColor.White);
        actual.White.C22.Should().Be(FaceColor.White);
        actual.White.C23.Should().Be(FaceColor.White);
        actual.White.C31.Should().Be(FaceColor.White);
        actual.White.C32.Should().Be(FaceColor.White);
        actual.White.C33.Should().Be(FaceColor.White);

        actual.Blue.C11.Should().Be(FaceColor.Blue);
        actual.Blue.C12.Should().Be(FaceColor.Blue);
        actual.Blue.C13.Should().Be(FaceColor.Blue);
        actual.Blue.C21.Should().Be(FaceColor.Blue);
        actual.Blue.C22.Should().Be(FaceColor.Blue);
        actual.Blue.C23.Should().Be(FaceColor.Blue);
        actual.Blue.C31.Should().Be(FaceColor.Orange);
        actual.Blue.C32.Should().Be(FaceColor.Orange);
        actual.Blue.C33.Should().Be(FaceColor.Orange);

        actual.Red.C11.Should().Be(FaceColor.Red);
        actual.Red.C12.Should().Be(FaceColor.Red);
        actual.Red.C13.Should().Be(FaceColor.Red);
        actual.Red.C21.Should().Be(FaceColor.Red);
        actual.Red.C22.Should().Be(FaceColor.Red);
        actual.Red.C23.Should().Be(FaceColor.Red);
        actual.Red.C31.Should().Be(FaceColor.Blue);
        actual.Red.C32.Should().Be(FaceColor.Blue);
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

        actual.Orange.C11.Should().Be(FaceColor.Orange);
        actual.Orange.C12.Should().Be(FaceColor.Orange);
        actual.Orange.C13.Should().Be(FaceColor.Orange);
        actual.Orange.C21.Should().Be(FaceColor.Orange);
        actual.Orange.C22.Should().Be(FaceColor.Orange);
        actual.Orange.C23.Should().Be(FaceColor.Orange);
        actual.Orange.C31.Should().Be(FaceColor.Green);
        actual.Orange.C32.Should().Be(FaceColor.Green);
        actual.Orange.C33.Should().Be(FaceColor.Green);
    }

    [Fact]
    public void Blue()
    {
        var actual = Cube.Turn(MoveKind.Blue, false);
        actual.Should().NotBeSameAs(Cube);

        actual.Blue.C11.Should().Be(FaceColor.Blue);
        actual.Blue.C12.Should().Be(FaceColor.Blue);
        actual.Blue.C13.Should().Be(FaceColor.Blue);
        actual.Blue.C21.Should().Be(FaceColor.Blue);
        actual.Blue.C22.Should().Be(FaceColor.Blue);
        actual.Blue.C23.Should().Be(FaceColor.Blue);
        actual.Blue.C31.Should().Be(FaceColor.Blue);
        actual.Blue.C32.Should().Be(FaceColor.Blue);
        actual.Blue.C33.Should().Be(FaceColor.Blue);

        actual.Green.C11.Should().Be(FaceColor.Green);
        actual.Green.C12.Should().Be(FaceColor.Green);
        actual.Green.C13.Should().Be(FaceColor.Green);
        actual.Green.C21.Should().Be(FaceColor.Green);
        actual.Green.C22.Should().Be(FaceColor.Green);
        actual.Green.C23.Should().Be(FaceColor.Green);
        actual.Green.C31.Should().Be(FaceColor.Green);
        actual.Green.C32.Should().Be(FaceColor.Green);
        actual.Green.C33.Should().Be(FaceColor.Green);

        actual.White.C11.Should().Be(FaceColor.Orange);
        actual.White.C12.Should().Be(FaceColor.White);
        actual.White.C13.Should().Be(FaceColor.White);
        actual.White.C21.Should().Be(FaceColor.Orange);
        actual.White.C22.Should().Be(FaceColor.White);
        actual.White.C23.Should().Be(FaceColor.White);
        actual.White.C31.Should().Be(FaceColor.Orange);
        actual.White.C32.Should().Be(FaceColor.White);
        actual.White.C33.Should().Be(FaceColor.White);

        actual.Red.C11.Should().Be(FaceColor.Red);
        actual.Red.C12.Should().Be(FaceColor.Red);
        actual.Red.C13.Should().Be(FaceColor.White);
        actual.Red.C21.Should().Be(FaceColor.Red);
        actual.Red.C22.Should().Be(FaceColor.Red);
        actual.Red.C23.Should().Be(FaceColor.White);
        actual.Red.C31.Should().Be(FaceColor.Red);
        actual.Red.C32.Should().Be(FaceColor.Red);
        actual.Red.C33.Should().Be(FaceColor.White);

        actual.Orange.C11.Should().Be(FaceColor.Yellow);
        actual.Orange.C12.Should().Be(FaceColor.Orange);
        actual.Orange.C13.Should().Be(FaceColor.Orange);
        actual.Orange.C21.Should().Be(FaceColor.Yellow);
        actual.Orange.C22.Should().Be(FaceColor.Orange);
        actual.Orange.C23.Should().Be(FaceColor.Orange);
        actual.Orange.C31.Should().Be(FaceColor.Yellow);
        actual.Orange.C32.Should().Be(FaceColor.Orange);
        actual.Orange.C33.Should().Be(FaceColor.Orange);

        actual.Yellow.C11.Should().Be(FaceColor.Red);
        actual.Yellow.C12.Should().Be(FaceColor.Yellow);
        actual.Yellow.C13.Should().Be(FaceColor.Yellow);
        actual.Yellow.C21.Should().Be(FaceColor.Red);
        actual.Yellow.C22.Should().Be(FaceColor.Yellow);
        actual.Yellow.C23.Should().Be(FaceColor.Yellow);
        actual.Yellow.C31.Should().Be(FaceColor.Red);
        actual.Yellow.C32.Should().Be(FaceColor.Yellow);
        actual.Yellow.C33.Should().Be(FaceColor.Yellow);
    }

    [Fact]
    public void Orange()
    {
        var actual = Cube.Turn(MoveKind.Orange, false);
        actual.Should().NotBeSameAs(Cube);

        actual.Orange.C11.Should().Be(FaceColor.Orange);
        actual.Orange.C12.Should().Be(FaceColor.Orange);
        actual.Orange.C13.Should().Be(FaceColor.Orange);
        actual.Orange.C21.Should().Be(FaceColor.Orange);
        actual.Orange.C22.Should().Be(FaceColor.Orange);
        actual.Orange.C23.Should().Be(FaceColor.Orange);
        actual.Orange.C31.Should().Be(FaceColor.Orange);
        actual.Orange.C32.Should().Be(FaceColor.Orange);
        actual.Orange.C33.Should().Be(FaceColor.Orange);

        actual.Red.C11.Should().Be(FaceColor.Red);
        actual.Red.C12.Should().Be(FaceColor.Red);
        actual.Red.C13.Should().Be(FaceColor.Red);
        actual.Red.C21.Should().Be(FaceColor.Red);
        actual.Red.C22.Should().Be(FaceColor.Red);
        actual.Red.C23.Should().Be(FaceColor.Red);
        actual.Red.C31.Should().Be(FaceColor.Red);
        actual.Red.C32.Should().Be(FaceColor.Red);
        actual.Red.C33.Should().Be(FaceColor.Red);

        actual.White.C11.Should().Be(FaceColor.White);
        actual.White.C12.Should().Be(FaceColor.White);
        actual.White.C13.Should().Be(FaceColor.White);
        actual.White.C21.Should().Be(FaceColor.White);
        actual.White.C22.Should().Be(FaceColor.White);
        actual.White.C23.Should().Be(FaceColor.White);
        actual.White.C31.Should().Be(FaceColor.Green);
        actual.White.C32.Should().Be(FaceColor.Green);
        actual.White.C33.Should().Be(FaceColor.Green);

        actual.Green.C11.Should().Be(FaceColor.Yellow);
        actual.Green.C12.Should().Be(FaceColor.Green);
        actual.Green.C13.Should().Be(FaceColor.Green);
        actual.Green.C21.Should().Be(FaceColor.Yellow);
        actual.Green.C22.Should().Be(FaceColor.Green);
        actual.Green.C23.Should().Be(FaceColor.Green);
        actual.Green.C31.Should().Be(FaceColor.Yellow);
        actual.Green.C32.Should().Be(FaceColor.Green);
        actual.Green.C33.Should().Be(FaceColor.Green);

        actual.Blue.C11.Should().Be(FaceColor.Blue);
        actual.Blue.C12.Should().Be(FaceColor.Blue);
        actual.Blue.C13.Should().Be(FaceColor.White);
        actual.Blue.C21.Should().Be(FaceColor.Blue);
        actual.Blue.C22.Should().Be(FaceColor.Blue);
        actual.Blue.C23.Should().Be(FaceColor.White);
        actual.Blue.C31.Should().Be(FaceColor.Blue);
        actual.Blue.C32.Should().Be(FaceColor.Blue);
        actual.Blue.C33.Should().Be(FaceColor.White);

        actual.Yellow.C11.Should().Be(FaceColor.Blue);
        actual.Yellow.C12.Should().Be(FaceColor.Blue);
        actual.Yellow.C13.Should().Be(FaceColor.Blue);
        actual.Yellow.C21.Should().Be(FaceColor.Yellow);
        actual.Yellow.C22.Should().Be(FaceColor.Yellow);
        actual.Yellow.C23.Should().Be(FaceColor.Yellow);
        actual.Yellow.C31.Should().Be(FaceColor.Yellow);
        actual.Yellow.C32.Should().Be(FaceColor.Yellow);
        actual.Yellow.C33.Should().Be(FaceColor.Yellow);
    }

    [Fact]
    public void Green()
    {
        var actual = Cube.Turn(MoveKind.Green, false);
        actual.Should().NotBeSameAs(Cube);

        actual.Green.C11.Should().Be(FaceColor.Green);
        actual.Green.C12.Should().Be(FaceColor.Green);
        actual.Green.C13.Should().Be(FaceColor.Green);
        actual.Green.C21.Should().Be(FaceColor.Green);
        actual.Green.C22.Should().Be(FaceColor.Green);
        actual.Green.C23.Should().Be(FaceColor.Green);
        actual.Green.C31.Should().Be(FaceColor.Green);
        actual.Green.C32.Should().Be(FaceColor.Green);
        actual.Green.C33.Should().Be(FaceColor.Green);

        actual.Blue.C11.Should().Be(FaceColor.Blue);
        actual.Blue.C12.Should().Be(FaceColor.Blue);
        actual.Blue.C13.Should().Be(FaceColor.Blue);
        actual.Blue.C21.Should().Be(FaceColor.Blue);
        actual.Blue.C22.Should().Be(FaceColor.Blue);
        actual.Blue.C23.Should().Be(FaceColor.Blue);
        actual.Blue.C31.Should().Be(FaceColor.Blue);
        actual.Blue.C32.Should().Be(FaceColor.Blue);
        actual.Blue.C33.Should().Be(FaceColor.Blue);

        actual.White.C11.Should().Be(FaceColor.White);
        actual.White.C12.Should().Be(FaceColor.White);
        actual.White.C13.Should().Be(FaceColor.Red);
        actual.White.C21.Should().Be(FaceColor.White);
        actual.White.C22.Should().Be(FaceColor.White);
        actual.White.C23.Should().Be(FaceColor.Red);
        actual.White.C31.Should().Be(FaceColor.White);
        actual.White.C32.Should().Be(FaceColor.White);
        actual.White.C33.Should().Be(FaceColor.Red);

        actual.Red.C11.Should().Be(FaceColor.Yellow);
        actual.Red.C12.Should().Be(FaceColor.Red);
        actual.Red.C13.Should().Be(FaceColor.Red);
        actual.Red.C21.Should().Be(FaceColor.Yellow);
        actual.Red.C22.Should().Be(FaceColor.Red);
        actual.Red.C23.Should().Be(FaceColor.Red);
        actual.Red.C31.Should().Be(FaceColor.Yellow);
        actual.Red.C32.Should().Be(FaceColor.Red);
        actual.Red.C33.Should().Be(FaceColor.Red);

        actual.Orange.C11.Should().Be(FaceColor.Orange);
        actual.Orange.C12.Should().Be(FaceColor.Orange);
        actual.Orange.C13.Should().Be(FaceColor.White);
        actual.Orange.C21.Should().Be(FaceColor.Orange);
        actual.Orange.C22.Should().Be(FaceColor.Orange);
        actual.Orange.C23.Should().Be(FaceColor.White);
        actual.Orange.C31.Should().Be(FaceColor.Orange);
        actual.Orange.C32.Should().Be(FaceColor.Orange);
        actual.Orange.C33.Should().Be(FaceColor.White);

        actual.Yellow.C11.Should().Be(FaceColor.Yellow);
        actual.Yellow.C12.Should().Be(FaceColor.Yellow);
        actual.Yellow.C13.Should().Be(FaceColor.Orange);
        actual.Yellow.C21.Should().Be(FaceColor.Yellow);
        actual.Yellow.C22.Should().Be(FaceColor.Yellow);
        actual.Yellow.C23.Should().Be(FaceColor.Orange);
        actual.Yellow.C31.Should().Be(FaceColor.Yellow);
        actual.Yellow.C32.Should().Be(FaceColor.Yellow);
        actual.Yellow.C33.Should().Be(FaceColor.Orange);
    }

    [Fact]
    public void Red()
    {
        var actual = Cube.Turn(MoveKind.Red, false);
        actual.Should().NotBeSameAs(Cube);

        actual.Red.C11.Should().Be(FaceColor.Red);
        actual.Red.C12.Should().Be(FaceColor.Red);
        actual.Red.C13.Should().Be(FaceColor.Red);
        actual.Red.C21.Should().Be(FaceColor.Red);
        actual.Red.C22.Should().Be(FaceColor.Red);
        actual.Red.C23.Should().Be(FaceColor.Red);
        actual.Red.C31.Should().Be(FaceColor.Red);
        actual.Red.C32.Should().Be(FaceColor.Red);
        actual.Red.C33.Should().Be(FaceColor.Red);

        actual.Orange.C11.Should().Be(FaceColor.Orange);
        actual.Orange.C12.Should().Be(FaceColor.Orange);
        actual.Orange.C13.Should().Be(FaceColor.Orange);
        actual.Orange.C21.Should().Be(FaceColor.Orange);
        actual.Orange.C22.Should().Be(FaceColor.Orange);
        actual.Orange.C23.Should().Be(FaceColor.Orange);
        actual.Orange.C31.Should().Be(FaceColor.Orange);
        actual.Orange.C32.Should().Be(FaceColor.Orange);
        actual.Orange.C33.Should().Be(FaceColor.Orange);

        actual.White.C11.Should().Be(FaceColor.Blue);
        actual.White.C12.Should().Be(FaceColor.Blue);
        actual.White.C13.Should().Be(FaceColor.Blue);
        actual.White.C21.Should().Be(FaceColor.White);
        actual.White.C22.Should().Be(FaceColor.White);
        actual.White.C23.Should().Be(FaceColor.White);
        actual.White.C31.Should().Be(FaceColor.White);
        actual.White.C32.Should().Be(FaceColor.White);
        actual.White.C33.Should().Be(FaceColor.White);

        actual.Blue.C11.Should().Be(FaceColor.Yellow);
        actual.Blue.C12.Should().Be(FaceColor.Blue);
        actual.Blue.C13.Should().Be(FaceColor.Blue);
        actual.Blue.C21.Should().Be(FaceColor.Yellow);
        actual.Blue.C22.Should().Be(FaceColor.Blue);
        actual.Blue.C23.Should().Be(FaceColor.Blue);
        actual.Blue.C31.Should().Be(FaceColor.Yellow);
        actual.Blue.C32.Should().Be(FaceColor.Blue);
        actual.Blue.C33.Should().Be(FaceColor.Blue);

        actual.Green.C11.Should().Be(FaceColor.Green);
        actual.Green.C12.Should().Be(FaceColor.Green);
        actual.Green.C13.Should().Be(FaceColor.White);
        actual.Green.C21.Should().Be(FaceColor.Green);
        actual.Green.C22.Should().Be(FaceColor.Green);
        actual.Green.C23.Should().Be(FaceColor.White);
        actual.Green.C31.Should().Be(FaceColor.Green);
        actual.Green.C32.Should().Be(FaceColor.Green);
        actual.Green.C33.Should().Be(FaceColor.White);

        actual.Yellow.C11.Should().Be(FaceColor.Yellow);
        actual.Yellow.C12.Should().Be(FaceColor.Yellow);
        actual.Yellow.C13.Should().Be(FaceColor.Yellow);
        actual.Yellow.C21.Should().Be(FaceColor.Yellow);
        actual.Yellow.C22.Should().Be(FaceColor.Yellow);
        actual.Yellow.C23.Should().Be(FaceColor.Yellow);
        actual.Yellow.C31.Should().Be(FaceColor.Green);
        actual.Yellow.C32.Should().Be(FaceColor.Green);
        actual.Yellow.C33.Should().Be(FaceColor.Green);
    }
}
