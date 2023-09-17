using System.Collections;

namespace LDZ.RubikSolver;

public record RubikCube(Face White, Face Blue, Face Orange, Face Red, Face Green, Face Yellow) : IEnumerable<Face>
{
    public static RubikCube Solved() => new(
        Face.SingleColor(FaceColor.White),
        Face.SingleColor(FaceColor.Blue),
        Face.SingleColor(FaceColor.Orange),
        Face.SingleColor(FaceColor.Red),
        Face.SingleColor(FaceColor.Green),
        Face.SingleColor(FaceColor.Yellow));

    public RubikCube Turn(Move move) => move.Kind switch
    {
        MoveKind.White => TurnWhite(move.Clockwise),
        MoveKind.Blue => TurnBlue(move.Clockwise),
        MoveKind.Orange => TurnOrange(move.Clockwise),
        MoveKind.Green => TurnGreen(move.Clockwise),
        MoveKind.Red => TurnRed(move.Clockwise),
        MoveKind.Yellow => TurnYellow(move.Clockwise),
        _ => throw new ArgumentException(nameof(move.Kind)),
    };

    private RubikCube TurnWhite(bool clockwise) => clockwise
        ? WhiteClockwise()
        : WhiteCounterClockwise();

    private RubikCube WhiteClockwise() => this with
    {
        White = White.WithClockWiseRotation(),
        Blue = Blue with
        {
            C11 = Orange.C31,
            C12 = Orange.C21,
            C13 = Orange.C11
        },
        Red = Red with
        {
            C13 = Blue.C11,
            C23 = Blue.C12,
            C33 = Blue.C13
        },
        Green = Green with
        {
            C31 = Red.C33,
            C32 = Red.C23,
            C33 = Red.C13
        },
        Orange = Orange with
        {
            C11 = Green.C31,
            C21 = Green.C32,
            C31 = Green.C33
        }
    };

    private RubikCube WhiteCounterClockwise() => this with
    {
        White = White.WithCounterClockWiseRotation(),
        Blue = Blue with
        {
            C11 = Red.C13,
            C12 = Red.C23,
            C13 = Red.C33
        },
        Red = Red with
        {
            C13 = Green.C33,
            C23 = Green.C32,
            C33 = Green.C31
        },
        Green = Green with
        {
            C31 = Orange.C11,
            C32 = Orange.C21,
            C33 = Orange.C31
        },
        Orange = Orange with
        {
            C11 = Blue.C13,
            C21 = Blue.C12,
            C31 = Blue.C11
        }
     };

    private RubikCube TurnBlue(bool clockwise) => clockwise
        ? BlueClockwise()
        : BlueCounterClockwise();

    private RubikCube BlueClockwise() => this with
    {
        Blue = Blue.WithClockWiseRotation(),
        Orange = Orange with
        {
            C31 = White.C31,
            C32 = White.C32,
            C33 = White.C33
        },
        Yellow = Yellow with
        {
            C31 = Orange.C31,
            C32 = Orange.C32,
            C33 = Orange.C33
        },
        White = White with
        {
            C31 = Red.C31,
            C32 = Red.C32,
            C33 = Red.C33
        },
        Red = Red with
        {
            C31 = Yellow.C31,
            C32 = Yellow.C32,
            C33 = Yellow.C33
        }
    };

    private RubikCube BlueCounterClockwise() => this with
    {
        Blue = Blue.WithCounterClockWiseRotation(),
        Orange = Orange with
        {
            C31 = Yellow.C31,
            C32 = Yellow.C32,
            C33 = Yellow.C33
        },
        Yellow = Yellow with
        {
            C31 = Red.C31,
            C32 = Red.C32,
            C33 = Red.C33
        },
        White = White with
        {
            C31 = Orange.C31,
            C32 = Orange.C32,
            C33 = Orange.C33
        },
        Red = Red with
        {
            C31 = White.C31,
            C32 = White.C32,
            C33 = White.C33
        }
    };

    private RubikCube TurnOrange(bool clockwise) => clockwise
        ? OrangeClockwise()
        : OrangeCounterClockwise();

    private RubikCube OrangeClockwise() => this with
    {
        Orange = Orange.WithClockWiseRotation(),
        White = White with
        {
            C13 = Blue.C13,
            C23 = Blue.C23,
            C33 = Blue.C33
        },
        Green = Green with
        {
            C13 = White.C13,
            C23 = White.C23,
            C33 = White.C33
        },
        Blue = Blue with
        {
            C13 = Yellow.C31,
            C23 = Yellow.C21,
            C33 = Yellow.C11
        },
        Yellow = Yellow with
        {
            C11 = Green.C33,
            C21 = Green.C23,
            C31 = Green.C13
        }
    };

    private RubikCube OrangeCounterClockwise() => this with
    {
        Orange = Orange.WithCounterClockWiseRotation(),
        White = White with
        {
            C13 = Green.C13,
            C23 = Green.C23,
            C33 = Green.C33
        },
        Green = Green with
        {
            C13 = Yellow.C31,
            C23 = Yellow.C21,
            C33 = Yellow.C11
        },
        Blue = Blue with
        {
            C13 = White.C13,
            C23 = White.C23,
            C33 = White.C33
        },
        Yellow = Yellow with
        {
            C11 = Blue.C33,
            C21 = Blue.C23,
            C31 = Blue.C13
        }
    };

    private RubikCube TurnGreen(bool clockwise) => clockwise
        ? GreenClockwise()
        : GreenCounterClockwise();

    private RubikCube GreenClockwise() => this with
    {
        Green = Green.WithClockWiseRotation(),
        White = White with
        {
            C11 = Orange.C11,
            C12 = Orange.C12,
            C13 = Orange.C13,
        },
        Orange = Orange with
        {
            C11 = Yellow.C11,
            C12 = Yellow.C12,
            C13 = Yellow.C13,
        },
        Yellow = Yellow with
        {
            C11 = Red.C11,
            C12 = Red.C12,
            C13 = Red.C13
        },
        Red = Red with
        {
            C11 = White.C11,
            C12 = White.C12,
            C13 = White.C13
        }
    };

    private RubikCube GreenCounterClockwise() => this with
    {
        Green = Green.WithCounterClockWiseRotation(),
        White = White with
        {
            C11 = Red.C11,
            C12 = Red.C12,
            C13 = Red.C13
        },
        Orange = Orange with
        {
            C11 = White.C11,
            C12 = White.C12,
            C13 = White.C13,
        },
        Yellow = Yellow with
        {
            C11 = Orange.C11,
            C12 = Orange.C12,
            C13 = Orange.C13
        },
        Red = Red with
        {
            C11 = Yellow.C11,
            C12 = Yellow.C12,
            C13 = Yellow.C13
        }
    };

    private RubikCube TurnRed(bool clockwise) => clockwise
        ? RedClockwise()
        : RedCounterClockwise();

    private RubikCube RedClockwise() => this with
    {
        Red = Red.WithClockWiseRotation(),
        White = White with
        {
            C11 = Green.C11,
            C21 = Green.C21,
            C31 = Green.C31
        },
        Blue = Blue with
        {
            C11 = White.C11,
            C21 = White.C21,
            C31 = White.C31
        },
        Green = Green with
        {
            C11 = Yellow.C33,
            C21 = Yellow.C23,
            C31 = Yellow.C13
        },
        Yellow = Yellow with
        {
            C13 = Blue.C31,
            C23 = Blue.C21,
            C33 = Blue.C11
        }
    };

    private RubikCube RedCounterClockwise() => this with
    {
        Red = Red.WithCounterClockWiseRotation(),
        White = White with
        {
            C11 = Blue.C11,
            C21 = Blue.C21,
            C31 = Blue.C31
        },
        Blue = Blue with
        {
            C11 = Yellow.C33,
            C21 = Yellow.C23,
            C31 = Yellow.C13
        },
        Green = Green with
        {
            C11 = White.C11,
            C21 = White.C21,
            C31 = White.C31
        },
        Yellow = Yellow with
        {
            C13 = Green.C31,
            C23 = Green.C21,
            C33 = Green.C11
        }
    };

    private RubikCube TurnYellow(bool clockwise) => clockwise
        ? YellowClockwise()
        : YellowCounterClockwise();

    private RubikCube YellowClockwise() => this with
    {
        Yellow = Yellow.WithClockWiseRotation(),
        Blue = Blue with
        {
            C31 = Red.C11,
            C32 = Red.C21,
            C33 = Red.C31
        },
        Red = Red with
        {
            C11 = Green.C13,
            C21 = Green.C12,
            C31 = Green.C11
        },
        Green = Green with
        {
            C11 = Orange.C13,
            C12 = Orange.C23,
            C13 = Orange.C33
        },
        Orange = Orange with
        {
            C13 = Blue.C33,
            C23 = Blue.C32,
            C33 = Blue.C31
        }
    };

    private RubikCube YellowCounterClockwise() => this with
    {
        Yellow = Yellow.WithCounterClockWiseRotation(),
        Blue = Blue with
        {
            C31 = Orange.C33,
            C32 = Orange.C23,
            C33 = Orange.C13
        },
        Red = Red with
        {
            C11 = Blue.C31,
            C21 = Blue.C32,
            C31 = Blue.C33
        },
        Green = Green with
        {
            C11 = Red.C31,
            C12 = Red.C21,
            C13 = Red.C11
        },
        Orange = Orange with
        {
            C13 = Green.C11,
            C23 = Green.C12,
            C33 = Green.C13
        }
    };

    public bool IsSolved => this.All(f => f.IsSolved);

    public IEnumerator<Face> GetEnumerator()
    {
        yield return White;
        yield return Green;
        yield return Yellow;
        yield return Blue;
        yield return Red;
        yield return Orange;
    }

    IEnumerator IEnumerable.GetEnumerator()
        => GetEnumerator();
}
