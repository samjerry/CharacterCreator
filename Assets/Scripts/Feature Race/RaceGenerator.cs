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

    public Text testText;

    void Start()
    {
        RandomizeRace();
    }

    void Update()
    {
        //Goes by every Race 
        for (int i = 0; i < _readJson.newChar.charRaces.Length; i++)
        {
            if (i == _indexNum)
            {
                _readJson.charRace = _readJson.newChar.charRaces[i];
                testText.text = _readJson.charRace;
            }
        }
        
        print(_readJson.charRace);

    }
    //Function to randomize a number, so that it later can use it to know which Index number it should take
    int RandomizeRace()
    {
        // Randomized the Index Number
        _indexNum = Random.Range(0, 38);
        return _indexNum;
    }

}
