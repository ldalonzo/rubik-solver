namespace LDZ.RubikSolver.Test;

public record RubikCube
{
    private static readonly EdgePiece _wr = new EdgePiece(FaceColor.White, FaceColor.Red);
    private static readonly EdgePiece _wb = new EdgePiece(FaceColor.White, FaceColor.Blue);
    private static readonly EdgePiece _wo = new EdgePiece(FaceColor.White, FaceColor.Orange);
    private static readonly EdgePiece _wg = new EdgePiece(FaceColor.White, FaceColor.Green);

    private static readonly EdgePiece _yr = new EdgePiece(FaceColor.Yellow, FaceColor.Red);
    private static readonly EdgePiece _yb = new EdgePiece(FaceColor.Yellow, FaceColor.Blue);
    private static readonly EdgePiece _yo = new EdgePiece(FaceColor.Yellow, FaceColor.Orange);
    private static readonly EdgePiece _yg = new EdgePiece(FaceColor.Yellow, FaceColor.Green);

    private static readonly EdgePiece _ob = new (FaceColor.Blue, FaceColor.Orange);
    private static readonly EdgePiece _br = new (FaceColor.Blue, FaceColor.Red);

    private static readonly EdgePiece _og = new(FaceColor.Orange, FaceColor.Green);
    private static readonly EdgePiece _gr = new(FaceColor.Green, FaceColor.Red);

    private CenterPiece _white = new(
        FaceColor.White,
        _wg,
        _wr,
        _wb,
        _wo);

    private CenterPiece _blue = new(
        FaceColor.Blue,
        _wb,
        _br,
        _yb,
        _ob);

    private CenterPiece _red = new(
        FaceColor.Red,
        _wr,
        _gr,
        _yr,
        _br);

    private CenterPiece _green = new(
        FaceColor.Green,
        _wg,
        _og,
        _yg,
        _gr);

    private CenterPiece _orange = new(
        FaceColor.Orange,
        _wo,
        _ob,
        _yo,
        _og);

    private CenterPiece _yellow = new(
        FaceColor.Yellow,
        _yb,
        _yr,
        _yg,
        _yo);

    public Face Top => new(
        _white.North.Top,
        _white.West.Top,
        _white.Color,
        _white.East.Top);

    public Face Bottom => new(
        _yellow.North.Top,
        _yellow.West.Top,
        _yellow.Color,
        _yellow.East.Top);

    public Face Right => new(
       _orange.North.Front,
       _orange.West.Front,
       _orange.Color,
       _orange.East.Top);

    public Face Back => new(
        _green.North.Front,
        _green.West.Front,
        _green.Color,
        _green.East.Top);

    public Face Front => new(
       _blue.North.Front,
       _blue.West.Top,
       _blue.Color,
       _blue.East.Top);

    public Face Left => new(
        _red.North.Front,
        _red.West.Front,
        _red.Color,
        _red.East.Front);

    public void TurnLeft()
    {
        _red = _red.ClockWise();

        _white = _white with
        {
            West = _red.North
        };

        _blue = _blue with
        {
            West = _red.East
        };

        _green = _green with
        {
            East = _red.West
        };

        _yellow = _yellow with
        {
            West = _red.South
        };
    }

    public void TurnRight()
    {

    }

    public void TurnTop()
    {
        _white = _white.ClockWise();

        _red = _red with
        {
            North = _white.West
        };

        _blue = _blue with
        {
            North = _white.South
        };

        _orange = _orange with
        {
            North = _white.East
        };

        _green = _green with
        {
            North = _white.North
        };
    }

    public void TurnFront()
    {

    }
}
