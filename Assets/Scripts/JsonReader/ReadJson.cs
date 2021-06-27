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

        for (int i = 0; i < _myChar.charClasses.Length; i++)
        {
            if (i == _myChar.charClasses.Length)
            {
                _classText.text += _myChar.charClasses[i];
                break;
            }
            _classText.text += _myChar.charClasses[i] + "\n";
        }

        for (int i = 0; i < _myChar.charStats.Length; i++)
        {
            if (i == _myChar.charStats.Length)
            {
                _statText.text += _myChar.charStats[i];
                break;
            }
            _statText.text += _myChar.charStats[i] + "\n";
        }
    }
}

