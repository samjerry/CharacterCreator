using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Character : MonoBehaviour
{
    public string[,] charNames;
    public string[] charRaces;
    public string[] charClasses;
    public string[] charStats;

    public string charName;
    public string charRace;
    public string charClass;
    public string charStatPrio;
}
