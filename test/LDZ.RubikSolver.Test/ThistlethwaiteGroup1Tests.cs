using LDZ.RubikSolver.Thistlethwaite;

namespace LDZ.RubikSolver.Test;

public class ThistlethwaiteGroup1Tests
{
    public static readonly TheoryData<IEnumerable<Move>, bool> EdgePieceWhiteRedIsGoodTestCases = new()
    {
        // Up-face permutations
        { Enumerable.Empty<Move>(),                                    true },
        { new[] {                     Move.U()                     }, false },
        { new[] {                     Move.U(), Move.U(),          },  true },
        { new[] {                     Move.U(), Move.U(), Move.U() }, false },
        { new[] { Move.L(), Move.F()                               },  true },
        { new[] { Move.L(), Move.F(), Move.U()                     }, false },
        { new[] { Move.L(), Move.F(), Move.U(), Move.U(),          },  true },
        { new[] { Move.L(), Move.F(), Move.U(), Move.U(), Move.U() }, false },
        
        // Bottom-face permutations
        { new[] { Move.L(), Move.L()                                    },  true },
        { new[] { Move.L(), Move.L(),      Move.D()                     }, false },
        { new[] { Move.L(), Move.L(),      Move.D(), Move.D(),          },  true },
        { new[] { Move.L(), Move.L(),      Move.D(), Move.D(), Move.D() }, false },
        { new[] { Move.L(), Move.F(false)                               },  true },
        { new[] { Move.L(), Move.F(false), Move.D()                     }, false },
        { new[] { Move.L(), Move.F(false), Move.D(), Move.D(),          },  true },
        { new[] { Move.L(), Move.F(false), Move.D(), Move.D(), Move.D() }, false },

        // Left-face permutations
        { new[] {                               Move.L()                },  true },
        { new[] {                               Move.L(false)           },  true },
        { new[] { Move.L(), Move.F(), Move.U(), Move.L()                }, false },
        { new[] { Move.L(), Move.F(), Move.U(), Move.L(false)           }, false },

        // Right-face permutations
        { new[] { Move.U(), Move.U(),                Move.R()           },  true },
        { new[] { Move.U(), Move.U(),                Move.R(false)      },  true },
        { new[] { Move.U(), Move.F(), Move.R(false), Move.R()           }, false },
        { new[] { Move.U(), Move.F(), Move.R(false), Move.R(false)      }, false }
    };


    [Theory]
    [MemberData(nameof(EdgePieceWhiteRedIsGoodTestCases))]
    public void EdgePieceWhiteRedIsGood(IEnumerable<Move> permutationMoves, bool expected)
    {
        var scrambled = permutationMoves.Aggregate(RubikCube.Solved(), (c, move) => c.Turn(move));
        scrambled.IsEdgePieceGood(c => c.IsEdgeAtHomeWhiteRed()).Should().Be(expected);
    }

    [Fact]
    public void AlreadyInGroup1()
    {
        IEnumerable<Move> permutationMoves = new List<Move>
        {
            Move.L(),
            Move.R(),
            Move.F(),
            Move.U(),
            Move.U(),
        };

        var scrambled = permutationMoves.Aggregate(RubikCube.Solved(), (c, move) => c.Turn(move));

        var group1Solver = new ThistlethwaiteGroup1BreadthFirstSolver(c => c.IsInGroup1());
        var solution = group1Solver.Solve(scrambled);
        solution.Should().BeEmpty();
    }

    [Fact]
    public void SolveGroup1()
    {
        IEnumerable<Move> permutationMoves = new List<Move>
        {
            Move.U()
        };

        var scrambled = permutationMoves.Aggregate(RubikCube.Solved(), (c, move) => c.Turn(move));

        var group1Solver = new ThistlethwaiteGroup1BreadthFirstSolver(c => c.IsInGroup1());
        var solution = group1Solver.Solve(scrambled);
        solution.Should().ContainSingle().Which.Should().Be(Move.U());
    }
}
