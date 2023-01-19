using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class OD_PersistantStats
{
    public static int score = 0;
    public static int remainingSubBlock = 6;

    public static void _IncreaseScore()
    {
        score += 1;
    }

    public static void _DecreaseSubBlockCount()
    {
        remainingSubBlock -= 1;
    }
}
