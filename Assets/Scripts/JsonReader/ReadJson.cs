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

    [SerializeField] public string charRace;
    void Start()
    {
        Character _myChar = new Character();
        _myChar = JsonUtility.FromJson<Character>(_charDetailsFile.text);
        _myChar.charNames = JsonUtility.FromJson<Names>(_charNameFile.text);

        

        _statText.text = "";
        _classText.text = "";
        _raceText.text = "";

        DetailsToText(_myChar);
        
        foreach (var item in GetRaceNames(_myChar, charRace))
        {
            Debug.Log(item);
        }

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

    private string[] GetRaceNames(Character _myChar, string _race)
    {
        string[] _names;

        switch (_race)
        {
            case "Aaracockra": _names = _myChar.charNames.Aaracockra; break;
            case "Aasimar": _names = _myChar.charNames.Aasimar; break;
            case "Bugbear": _names = _myChar.charNames.Bugbear; break;
            case "Centaur": _names = _myChar.charNames.Centaur; break;
            case "Changeling": _names = _myChar.charNames.Changeling; break;
            case "Dragonborn": _names = _myChar.charNames.Dragonborn; break;
            case "Dwarf": _names = _myChar.charNames.Dwarf; break;
            case "Elf": _names = _myChar.charNames.Elf; break;
            case "Firbolg": _names = _myChar.charNames.Firbolg; break;
            case "Genasi": _names = _myChar.charNames.Genasi; break;
            case "Gith": _names = _myChar.charNames.Gith; break;
            case "Gnome": _names = _myChar.charNames.Gnome; break;
            case "Goblin": _names = _myChar.charNames.Goblin; break;
            case "Goliath": _names = _myChar.charNames.Goliath; break;
            case "Half-Elf": _names = _myChar.charNames.Half_Elf; break;
            case "Half-Orc": _names = _myChar.charNames.Half_Orc; break;
            case "Halfling": _names = _myChar.charNames.Halfling; break;
            case "Hobgoblin": _names = _myChar.charNames.Hobgoblin; break;
            case "Kalashtar": _names = _myChar.charNames.Kalashtar; break;
            case "Kenku": _names = _myChar.charNames.Kenku; break;
            case "Kobold": _names = _myChar.charNames.Kobold; break;
            case "Lizardfolk": _names = _myChar.charNames.Lizardfolk; break;
            case "Locathah": _names = _myChar.charNames.Locathah; break;
            case "Loxodon": _names = _myChar.charNames.Loxodon; break;
            case "Minotaur": _names = _myChar.charNames.Minotaur; break;
            case "Orc": _names = _myChar.charNames.Orc; break;
            case "Pureblood": _names = _myChar.charNames.Pureblood; break;
            case "Shifter": _names = _myChar.charNames.Shifter; break;
            case "Simic-Hybrid": _names = _myChar.charNames.Simic_Hybrid; break;
            case "Tabaxi": _names = _myChar.charNames.Tabaxi; break;
            case "Tiefling": _names = _myChar.charNames.Tiefling; break;
            case "Tortle": _names = _myChar.charNames.Tortle; break;
            case "Triton": _names = _myChar.charNames.Triton; break;
            case "Vedalken": _names = _myChar.charNames.Vedalken; break;
            case "Verdan": _names = _myChar.charNames.Verdan; break;
            case "Warforged": _names = _myChar.charNames.Warforged; break;
            case "Yuan-ti": _names = _myChar.charNames.Yuan_ti; break;
            default: _names = null; break;
        }
        return _names;
    }
}

