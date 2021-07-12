using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClassGenerator : MonoBehaviour
{
    // Variables used to get the variable charRace from ReadJson
    [SerializeField] private ReadJson _readJson;

    // The Index Number that is going to be randomized 
    [SerializeField] private int IndexNum;

     public Text _TextTest;

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
            if (i == IndexNum)
            {
                charClass = _readJson.newChar.charClasses[i];
                _TextTest.text = charClass;
            }

        }
       
       
    }

    //Function to randomize a number, so that it later can use it to know which Index number it should take
    int Randomize(int arrayLength)
    {
        // Randomized the Index Number
        IndexNum = Random.Range(0, arrayLength);
        return IndexNum;
    }

}
