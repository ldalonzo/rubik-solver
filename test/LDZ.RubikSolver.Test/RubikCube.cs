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

    private static readonly EdgePiece _bo = new (FaceColor.Blue, FaceColor.Orange);
    private static readonly EdgePiece _rb = new (FaceColor.Red, FaceColor.Blue);

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
        _rb,
        _yb,
        _bo);

    private CenterPiece _red = new(
        FaceColor.Red,
        _wr,
        _gr,
        _yr,
        _rb);

    private CenterPiece _green = new(
        FaceColor.Green,
        _wg,
        _og,
        _yg,
        _gr);

    private CenterPiece _orange = new(
        FaceColor.Orange,
        _wo,
        _bo,
        _yo,
        _og);

    private readonly CenterPiece _yellow = new(
        FaceColor.Yellow,
        _yb,
        _yr,
        _yg,
        _yo);

    public Face Top => new Face(
        _white.North.Top,
        _white.Color);

    public Face Bottom => new(
        _yellow.North.Top,
        _yellow.Color);

    public Face Right => new(
       _orange.North.Front,
       _orange.Color);

    public Face Back => new(
        _green.North.Front,
        _green.Color);

    public Face Front => new(
       _blue.North.Front,
       _blue.Color);

    public Face Left => new(
        _red.North.Front,
        _red.Color);

    public void TurnLeft()
    {

    }

    public void TurnRight()
    {

    }

    public void TurnTop()
    {
        _white = _white with
        {
            North = _white.West,
            West = _white.South,
            South = _white.East,
            East = _white.North
        };

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
