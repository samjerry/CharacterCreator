using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Character : MonoBehaviour
{
    public string[,] charNames { get; set; }
    public string[] charRaces { get; set; }
    public string[] charClasses { get; set; }
    public string[] charStats { get; set; }
}
