﻿using System;

public static class Squares
{
    public static int SquareOfSums(int max)
    {
        var sum = 0;
        for (var i = 1; i <= max; i++) 
        {
            sum = sum + i;
        }

        var square = Math.Pow(sum, 2);

        return (int) square;
    }

    public static int SumOfSquares(int max)
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public static int DifferenceOfSquares(int max)
    {
        throw new NotImplementedException("You need to implement this function.");
    }
}