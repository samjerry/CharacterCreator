using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClassGenerator : MonoBehaviour
{
    // Variables used to get the variable charRace from ReadJson
    [SerializeField] private ReadJson _readJson;

    // The Index Number that is going to be randomized 
    [SerializeField] private int _indexNum;

     public Text textTest;

    // Variable to save the class
    public string charClass;

    void Start()
    {
        Randomize(_readJson.newChar.charClasses.Length);
    }

    void Update()
    {
        //Goes by every Race 
        for (int i = 0; i < _readJson.newChar.charClasses.Length; i++) 
        { 
            if (i == _indexNum)
            {
                charClass = _readJson.newChar.charClasses[i];
                textTest.text = charClass;
            }

        }
       
       
    }

    //Function to randomize a number, so that it later can use it to know which Index number it should take
    int Randomize(int arrayLength)
    {
        // Randomized the Index Number
        _indexNum = Random.Range(0, arrayLength);
        return _indexNum;
    }

}
