using UnityEngine;

public static class Stats
{
    public static int logic = 0;
    public static int empathy = 0;
    public static int humor = 0;

    public static void IncrementStat(int type)
    {
        if (type == 0)
        {
            logic++;
            return;
        }
        if (type == 1)
        {
            empathy++;
            return;
        }
        if (type == 2)
        {
            humor++;
            return;
        }

    }

    public static void Reset()
    {
        logic = 0;
        empathy = 0;
        humor = 0;
    }
}
