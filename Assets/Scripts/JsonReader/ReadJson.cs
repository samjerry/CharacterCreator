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
        _myChar = JsonUtility.FromJson<Character>(_charDetailsFile.text);
        _myChar = JsonUtility.FromJson<Character>(_charNameFile.text);


        foreach (Character character in _myChar.charNames)
        {
            Debug.Log("Found employee: " + _myChar.charNames);
        }
    }
}
