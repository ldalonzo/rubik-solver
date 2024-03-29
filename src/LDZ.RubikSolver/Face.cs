﻿using System.Collections;

namespace LDZ.RubikSolver;

public record Face(
    FaceColor C11,
    FaceColor C12,
    FaceColor C13,
    FaceColor C21,
    FaceColor C22,
    FaceColor C23,
    FaceColor C31,
    FaceColor C32,
    FaceColor C33) : IEnumerable<FaceColor>
{
    public static Face SingleColor(FaceColor color) => new(
        color,
        color,
        color,
        color,
        color,
        color,
        color,
        color,
        color);

    public Face WithClockWiseRotation() => this with
    {
        C11 = C31,
        C12 = C21,
        C13 = C11,
        C21 = C32,
        C23 = C12,
        C31 = C33,
        C32 = C23,
        C33 = C13
    };

    public Face WithCounterClockWiseRotation() => this with
    {
        C11 = C13,
        C12 = C23,
        C13 = C33,
        C21 = C12,
        C23 = C32,
        C31 = C11,
        C32 = C21,
        C33 = C31
    };

    public bool IsSolved => this.Distinct().Count() == 1;

    public IEnumerator<FaceColor> GetEnumerator()
    {
        yield return C11;
        yield return C12;
        yield return C13;
        yield return C21;
        yield return C22;
        yield return C23;
        yield return C31;
        yield return C32;
        yield return C33;
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}