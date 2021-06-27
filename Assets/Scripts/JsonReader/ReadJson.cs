using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadJson : MonoBehaviour
{
    [SerializeField] private TextAsset _charNameFile;
    [SerializeField] private TextAsset _charDetailsFile;

    void Start()
    {
        Character _myChar = new Character();
        _myChar.charClasses = JsonUtility.FromJson<Character>(_charDetailsFile.text).charClasses;
        //_myChar.charNames = JsonUtility.FromJson<Character>(_charNameFile.text);


        for (int i = 0; i < _myChar.charNames.GetLength(0); i++)
        {
            for (int j = 0; j < _myChar.charNames.GetLength(1); j++)
            {
                Debug.Log(_myChar.charNames[i,j]);
            }
        }
    }
}
