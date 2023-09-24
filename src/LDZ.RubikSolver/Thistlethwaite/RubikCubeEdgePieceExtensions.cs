namespace LDZ.RubikSolver.Thistlethwaite;

public static class RubikCubeEdgePieceExtensions
{
    /// <summary>
    /// An edge piece is BAD if in taking it home an odd number of quarter-turns of U and D faces is needed; otherwise it is GOOD.
    /// </summary>
    public static bool IsEdgePieceGood(this RubikCube cube, Predicate<RubikCube> isGoal)
    {
        var solver = new ThistlethwaiteGroup1BreadthFirstSolver(isGoal);
        var solution = solver.Solve(cube).ToList();

        return
            solution.Count(m => m.Kind == MoveKind.White) % 2 == 0 &&
            solution.Count(m => m.Kind == MoveKind.Yellow) % 2 == 0;
    }

    public static bool IsInGroup1(this RubikCube cube) => AreAllEdgesAtHome.All(c => IsEdgePieceGood(cube, c));

    public static bool IsEdgeAtHomeWhiteRed(this RubikCube cube)
        => cube.White.C21 == FaceColor.White && cube.Red.C23 == FaceColor.Red;

    public static bool IsEdgeAtHomeWhiteBlue(this RubikCube cube)
        => cube.White.C32 == FaceColor.White && cube.Blue.C12 == FaceColor.Blue;

    public static bool IsEdgeAtHomeWhiteOrange(this RubikCube cube)
        => cube.White.C23 == FaceColor.White && cube.Orange.C21 == FaceColor.Orange;

    public static bool IsEdgeAtHomeWhiteGreen(this RubikCube cube)
        => cube.White.C12 == FaceColor.White && cube.Green.C32 == FaceColor.Green;

    public static bool IsEdgeAtHomeYellowOrange(this RubikCube cube)
        => cube.Yellow.C21 == FaceColor.Yellow && cube.Orange.C23 == FaceColor.Orange;

    public static bool IsEdgeAtHomeYellowBlue(this RubikCube cube)
        => cube.Yellow.C32 == FaceColor.Yellow && cube.Blue.C32 == FaceColor.Blue;

    public static bool IsEdgeAtHomeYellowRed(this RubikCube cube)
        => cube.Yellow.C23 == FaceColor.Yellow && cube.Red.C21 == FaceColor.Red;

    public static bool IsEdgeAtHomeYellowGreen(this RubikCube cube)
        => cube.Yellow.C12 == FaceColor.Yellow && cube.Green.C23 == FaceColor.Green;

    public static bool IsEdgeAtHomeRedGreen(this RubikCube cube)
        => cube.Red.C12 == FaceColor.Red && cube.Green.C21 == FaceColor.Green;

    public static bool IsEdgeAtHomeRedBlue(this RubikCube cube)
        => cube.Red.C32 == FaceColor.Red && cube.Blue.C21 == FaceColor.Blue;

    public static bool IsEdgeAtHomeOrangeGreen(this RubikCube cube)
        => cube.Orange.C12 == FaceColor.Orange && cube.Green.C23 == FaceColor.Green;

    public static bool IsEdgeAtHomeOrangeBlue(this RubikCube cube)
        => cube.Orange.C32 == FaceColor.Orange && cube.Blue.C23 == FaceColor.Blue;

    private static readonly IReadOnlyCollection<Predicate<RubikCube>> AreAllEdgesAtHome = new Predicate<RubikCube>[]
    {
        IsEdgeAtHomeWhiteRed,
        IsEdgeAtHomeWhiteBlue,
        IsEdgeAtHomeWhiteOrange,
        IsEdgeAtHomeWhiteGreen,

        IsEdgeAtHomeYellowOrange,
        IsEdgeAtHomeYellowBlue,
        IsEdgeAtHomeYellowRed,
        IsEdgeAtHomeYellowGreen,

        IsEdgeAtHomeRedGreen,
        IsEdgeAtHomeRedBlue,

        IsEdgeAtHomeOrangeGreen,
        IsEdgeAtHomeOrangeBlue
    };
}
