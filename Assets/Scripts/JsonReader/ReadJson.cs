using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReadJson : MonoBehaviour
{
    [SerializeField] private TextAsset _charNameFile;
    [SerializeField] private TextAsset _charDetailsFile;

    [SerializeField] private Text _raceText;
    [SerializeField] private Text _classText;
    [SerializeField] private Text _statText;

    void Start()
    {
        Character _myChar = new Character(); 
        _myChar = JsonUtility.FromJson<Character>(_charDetailsFile.text);

        _statText.text = "";
        _classText.text = "";
        _raceText.text = "";

        DetailsToText(_myChar);

        //DebugArray(_myChar.charRaces);
        //DebugArray(_myChar.charClasses);
        //DebugArray(_myChar.charStats);
    }

    private void DetailsToText(Character _myChar)
    {
        for (int i = 0; i < _myChar.charRaces.Length; i++)
        {
            if (i == _myChar.charRaces.Length)
            {
                _raceText.text += _myChar.charRaces[i];
                break;
            }
            _raceText.text += _myChar.charRaces[i] + "\n";
        }

        for (int j = 0; j < _myChar.charClasses.Length; j++)
        {
            if (j == _myChar.charClasses.Length)
            {
                _classText.text += _myChar.charClasses[j];
                break;
            }
            _classText.text += _myChar.charClasses[j] + "\n";
        }

        for (int g = 0; g < _myChar.charStats.Length; g++)
        {
            if (g == _myChar.charStats.Length)
            {
                _statText.text += _myChar.charStats[g];
                break;
            }
            _statText.text += _myChar.charStats[g] + "\n";
        }
    }

    private void DebugArray(string[] _array)
    {
        foreach (string _key in _array)
        {
            Debug.Log(_key);
        }
    }
}

