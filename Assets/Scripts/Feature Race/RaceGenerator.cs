using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RaceGenerator : MonoBehaviour
{
    // Variables used to get the variable charRace from ReadJson
    [SerializeField] private ReadJson _readJson;

    // The Index Number that is going to be randomized 
    [SerializeField] private int _indexNum;


    public string GenerateRace(string _race)
    {
        int _randInt = Randomize(_readJson.newChar.charRaces.Length);
        for (int i = 0; i < _readJson.newChar.charRaces.Length; i++)
        {
            if (i == _randInt)
            { 
                _race = _readJson.newChar.charRaces[i];
            }
        }
        return _race;
    }

    int Randomize(int _arrayLength)
    {
        _indexNum = Random.Range(0, _arrayLength); 
        return _indexNum;
    }
}




