using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadJson : MonoBehaviour
{
    [SerializeField] private TextAsset _charNameFile;
    [SerializeField] private TextAsset _charDetailsFile;

    //[SerializeField] private TextAsset _charRacesFile;
   // [SerializeField] private TextAsset _charClassesFile;
   // [SerializeField] private TextAsset _charStatsFile;


    void Start()
    {
        Character _myChar = new Character(); 
        _myChar = JsonUtility.FromJson<Character>(_charDetailsFile.text);

        DebugArray(_myChar.charRaces);
        DebugArray(_myChar.charClasses);
        DebugArray(_myChar.charStats);
    }

    private void DebugArray(string[] _array)
    {
        foreach (string _key in _array)
        {
            Debug.Log(_key);
        }
    }
}

