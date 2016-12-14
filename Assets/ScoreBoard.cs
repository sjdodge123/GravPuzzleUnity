using UnityEngine;
using System.Collections;
using System;

public static class ScoreBoard
{
    private static int totalScore = 0;
    private static int maxScore = 0;
    private static int currentScore = 0;
    private static int currentGravityWells = 0;

    public static void GravityWellSpawned()
    {
        currentGravityWells++;
    }

    public static void SetMaxScore(int value)
    {
        maxScore = value;
        currentGravityWells = 0;
        currentScore = 0;
    }

    public static void CalculateScore()
    {
        currentScore = maxScore - currentGravityWells * GameVars.GravityWellCost;
        if (currentScore < 0)
        {
            currentScore = 0;
        }
        totalScore += currentScore;
    }

    public static void ClearTotalScore()
    {
        totalScore = 0;
    }

    public static int GetTotalScore()
    {
        return totalScore;
    }
    public static int GetCurrentScore()
    {
        return currentScore;
    }
}
