using System;

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

    public static int SquareOfSums(int max)
    {
        var sum = 0;
        for (var i = 1; i <= max; i++)
        {
            sum = sum + i;
        }

        var square = Math.Pow(sum, 2);

        return (int)square;
    }

    public static int SumOfSquares(int max)
    {
        var sum = 0;
        for (var i = 1; i <= max; i++)
        {
            sum = sum + (int) Math.Pow(i, 2);
        }

        return sum;
    }

    public static int DifferenceOfSquares(int max)
    {
        var squaredSums = SquareOfSums(max);
        var sumsSquared = SumOfSquares(max);
        var difference = squaredSums - sumsSquared;

        return difference;
    }
}