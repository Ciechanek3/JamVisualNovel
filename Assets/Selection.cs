using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Selection : MonoBehaviour
{
    public void IncrementStat(int value)
    {
        Stats.IncrementStat(value);
    }
}
