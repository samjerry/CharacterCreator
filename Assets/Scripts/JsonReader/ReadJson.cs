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
        _myChar.charRaces = JsonHelper.FromJson<Character>(_charDetailsFile);
    }
}
