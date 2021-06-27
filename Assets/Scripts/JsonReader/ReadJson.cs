using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadJson : MonoBehaviour
{
    [SerializeField] private TextAsset _charNameFile;
    [SerializeField] private TextAsset _charRacesFile;
    [SerializeField] private TextAsset _charClassesFile;
    [SerializeField] private TextAsset _charStatsFile;


    void Start()
    {
        Character _myChar = new Character();
        _myChar.charRaces = JsonHelper.ParseJsonArray<string[]>(_charRacesFile.text);
    }

}

