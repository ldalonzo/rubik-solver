namespace LDZ.RubikSolver.Test;


public record RubikCube(Face White, Face Blue, Face Orange, Face Red, Face Green, Face Yellow)
{
    public static RubikCube Solved() => new(
        Face.SingleColor(FaceColor.White),
        Face.SingleColor(FaceColor.Blue),
        Face.SingleColor(FaceColor.Orange),
        Face.SingleColor(FaceColor.Red),
        Face.SingleColor(FaceColor.Green),
        Face.SingleColor(FaceColor.Yellow));

    public RubikCube WhiteClockwise() => this with
    {
        White = White.WithClockWiseRotation(),
        Blue = Blue.WithTopRowFrom(Orange),
        Red = Red.WithTopRowFrom(Blue),
        Green = Green.WithTopRowFrom(Red),
        Orange = Orange.WithTopRowFrom(Green)
    };

    public RubikCube WhiteCounterClockwise() => this with
    {
        White = White.WithCounterClockWiseRotation(),
        Blue = Blue.WithTopRowFrom(Red),
        Red = Red.WithTopRowFrom(Green),
        Green = Green.WithTopRowFrom(Orange),
        Orange = Orange.WithTopRowFrom(Blue)
    };

    public RubikCube BlueClockwise() => this with
    {
        Blue = Blue.WithClockWiseRotation(),
        Orange = Orange.WithLeftColumnFrom(White),
        Yellow = Yellow.WithLeftColumnFrom(Orange),
        White = White with
        {
            C11 = Red.C33,
            C21 = Red.C23,
            C31 = Red.C13
        },
        Red = Red.WithRightColumnFromLeftColumnInverted(Yellow)
    };

    public RubikCube BlueCounterClockwise() => this with
    {
        Blue = Blue.WithCounterClockWiseRotation(),
        Orange = Orange.WithLeftColumnFrom(Yellow),
        Yellow = Yellow with
        {
            C11 = Red.C33,
            C21 = Red.C23,
            C31 = Red.C13
        },
        White = White with
        {
            C11 = Orange.C11,
            C21 = Orange.C21,
            C31 = Orange.C31
        },
        Red = Red.WithRightColumnFromLeftColumnInverted(White)
    };

    public RubikCube OrangeClockwise() => this with
    {
        Orange = Orange.WithClockWiseRotation(),
        White = White with
        {
            C31 = Blue.C33,
            C32 = Blue.C23,
            C33 = Blue.C13
        },
        Green = Green with
        {
            C11 = White.C31,
            C21 = White.C32,
            C31 = White.C33
        },
        Blue = Blue.WithRightColumnFromLeftColumn(Yellow),
        Yellow = Yellow with
        {
            C11 = Green.C31,
            C12 = Green.C21,
            C13 = Green.C11
        }
    };

    public RubikCube OrangeCounterClockwise() => this with
    {
        Orange = Orange.WithCounterClockWiseRotation(),
        White = White with
        {
            C31 = Green.C11,
            C32 = Green.C21,
            C33 = Green.C31
        },
        Green = Green with
        {
            C11 = Yellow.C13,
            C21 = Yellow.C12,
            C31 = Yellow.C11
        },
        Blue = Blue with
        {
            C13 = White.C33,
            C23 = White.C32,
            C33 = White.C31
        },
        Yellow = Yellow with
        {
            C11 = Blue.C13,
            C12 = Blue.C23,
            C13 = Blue.C33
        }
    };

    public RubikCube GreenClockwise() => this with
    {
        Green = Green.WithClockWiseRotation(),
        White = White.WithRightColumnFrom(Orange),
        Orange = Orange.WithRightColumnFrom(Yellow),
        Yellow = Yellow with
        {
            C13 = Red.C31,
            C23 = Red.C21,
            C33 = Red.C11
        },
        Red = Red with
        {
            C11 = White.C33,
            C21 = White.C23,
            C31 = White.C13
        }
    };

    public RubikCube GreenCounterClockwise() => this with
    {
        Green = Green.WithCounterClockWiseRotation(),
        White = White with
        {
            C13 = Red.C31,
            C23 = Red.C21,
            C33 = Red.C11
        },
        Orange = Orange.WithRightColumnFrom(White),
        Yellow = Yellow.WithRightColumnFrom(Orange),
        Red = Red with
        {
            C11 = Yellow.C33,
            C21 = Yellow.C23,
            C31 = Yellow.C13
        }
    };

    public RubikCube RedClockwise() => this with
    {
        Red = Red.WithClockWiseRotation(),
        White = White with
        {
            C11 = Green.C13,
            C12 = Green.C23,
            C13 = Green.C33
        },
        Blue = Blue.WithLeftColumnFrom(White),
        Green = Green with
        {
            C13 = Yellow.C33,
            C23 = Yellow.C32,
            C33 = Yellow.C31
        },
        Yellow = Yellow with
        {
            C31 = Blue.C11,
            C32 = Blue.C21,
            C33 = Blue.C31
        }
    };

    public RubikCube RedCounterClockwise() => this with
    {
        Red = Red.WithCounterClockWiseRotation(),
        White = White with
        {
            C11 = Blue.C31,
            C12 = Blue.C21,
            C13 = Blue.C11
        },
        Blue = Blue with
        {
            C11 = Yellow.C31,
            C21 = Yellow.C32,
            C31 = Yellow.C33
        },
        Green = Green.WithRightColumnFromLeftColumn(White),
        Yellow = Yellow with
        {
            C31 = Green.C33,
            C32 = Green.C23,
            C33 = Green.C13
        }
    };

    public RubikCube YellowClockwise() => this with
    {
        Yellow = Yellow.WithClockWiseRotation(),
        Blue = Blue.WithBottomRowFrom(Red),
        Red = Red.WithBottomRowFrom(Green),
        Green = Green.WithBottomRowFrom(Orange),
        Orange = Orange.WithBottomRowFrom(Blue)
    };

    public RubikCube YellowCounterClockwise() => this with
    {
        Yellow = Yellow.WithCounterClockWiseRotation(),
        Blue = Blue with
        {
            C31 = Orange.C31,
            C32 = Orange.C32,
            C33 = Orange.C33
        },
        Red = Red.WithBottomRowFrom(Blue),
        Green = Green.WithBottomRowFrom(Red),
        Orange = Orange.WithBottomRowFrom(Green)
    };
}

