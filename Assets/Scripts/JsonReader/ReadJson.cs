using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReadJson : MonoBehaviour
{
    [SerializeField] private TextAsset _charNameFile; // this file contains all the character names possible sorted by Race.
    [SerializeField] private TextAsset _charDetailsFile; // this file contains all the detail names possible sorted by Type (Race, Class, Stats).

    // These Text fields represent the content from the Character.cs Arrays.
    [SerializeField] private Text _raceText;
    [SerializeField] private Text _classText;
    [SerializeField] private Text _statText;
    [SerializeField] private Text _nameText;

    public string charRace; //this string is used by GetRaceNames() if you change this string to a race you got from the race generator you will get the corresponding character names if you call GetRaceNames().

    public Character newChar; // this will be used as our current instance of Character.cs.

    void Start()
    {
        newChar = new Character(); // actually creates the new instance of Character.cs
        newChar = JsonUtility.FromJson<Character>(_charDetailsFile.text); // this reads the _charDetailsFile containing (Race, Class, Stats) the Array names in the json must be the EXACT SAME as the var names in Character.cs
        newChar.charNames = JsonUtility.FromJson<Names>(_charNameFile.text);// this reads the _charNameFile containing (names for all races) the Array names in the json must be the EXACT SAME as the var names in Character.cs

        // clears the text from the text fields
        _statText.text = "";
        _classText.text = "";
        _raceText.text = "";
        _nameText.text = "";

        DetailsToText(); // for each array (except names) puts each index into the corresponding text fields
        
        //puts all names from the Race = charRace into the _nameText field
        foreach (string _name in GetRaceNames())
        {
            if (_name == "ERROR: INVALID RACE")
            {
                break;
            }

            _nameText.text += _name + "\n";
        }
    }

    private void DetailsToText()
    {
        for (int i = 0; i < newChar.charRaces.Length; i++)
        {
            if (i == newChar.charRaces.Length)
            {
                _raceText.text += newChar.charRaces[i];
                break;
            }
            _raceText.text += newChar.charRaces[i] + "\n";
        }

        for (int i = 0; i < newChar.charClasses.Length; i++)
        {
            if (i == newChar.charClasses.Length)
            {
                _classText.text += newChar.charClasses[i];
                break;
            }
            _classText.text += newChar.charClasses[i] + "\n";
        }

        for (int i = 0; i < newChar.charStats.Length; i++)
        {
            if (i == newChar.charStats.Length)
            {
                _statText.text += newChar.charStats[i];
                break;
            }
            _statText.text += newChar.charStats[i] + "\n";
        }
    }

    private string[] GetRaceNames()
    {
        string[] _names = new string[255];

        //compares the charRace with all Races and returns the array of the corresponding race.
        switch (charRace)
        {
            case "Aarakocra": _names = newChar.charNames.Aarakocra; break;
            case "Aasimar": _names = newChar.charNames.Aasimar; break;
            case "Bugbear": _names = newChar.charNames.Bugbear; break;
            case "Centaur": _names = newChar.charNames.Centaur; break;
            case "Changeling": _names = newChar.charNames.Changeling; break;
            case "Dragonborn": _names = newChar.charNames.Dragonborn; break;
            case "Dwarf": _names = newChar.charNames.Dwarf; break;
            case "Elf": _names = newChar.charNames.Elf; break;
            case "Firbolg": _names = newChar.charNames.Firbolg; break;
            case "Genasi": _names = newChar.charNames.Genasi; break;
            case "Gith": _names = newChar.charNames.Gith; break;
            case "Gnome": _names = newChar.charNames.Gnome; break;
            case "Goblin": _names = newChar.charNames.Goblin; break;
            case "Goliath": _names = newChar.charNames.Goliath; break;
            case "Grung": _names = newChar.charNames.Grung; break;
            case "Half_Elf": _names = newChar.charNames.Half_Elf; break;
            case "Half_Orc": _names = newChar.charNames.Half_Orc; break;
            case "Halfling": _names = newChar.charNames.Halfling; break;
            case "Hobgoblin": _names = newChar.charNames.Hobgoblin; break;
            case "Human": _names = newChar.charNames.Human; break;
            case "Kalashtar": _names = newChar.charNames.Kalashtar; break;
            case "Kenku": _names = newChar.charNames.Kenku; break;
            case "Kobold": _names = newChar.charNames.Kobold; break;
            case "Leonin": _names = newChar.charNames.Leonin; break;
            case "Lizardfolk": _names = newChar.charNames.Lizardfolk; break;
            case "Locathah": _names = newChar.charNames.Locathah; break;
            case "Loxodon": _names = newChar.charNames.Loxodon; break;
            case "Minotaur": _names = newChar.charNames.Minotaur; break;
            case "Orc": _names = newChar.charNames.Orc; break;
            case "Satyr": _names = newChar.charNames.Satyr; break;
            case "Shifter": _names = newChar.charNames.Shifter; break;
            case "Simic_Hybrid": _names = newChar.charNames.Simic_Hybrid; break;
            case "Tabaxi": _names = newChar.charNames.Tabaxi; break;
            case "Tiefling": _names = newChar.charNames.Tiefling; break;
            case "Tortle": _names = newChar.charNames.Tortle; break;
            case "Triton": _names = newChar.charNames.Triton; break;
            case "Vedalken": _names = newChar.charNames.Vedalken; break;
            case "Warforged": _names = newChar.charNames.Warforged; break;
            case "Yuan_ti": _names = newChar.charNames.Yuan_ti; break;
            default: _names[0] = "ERROR: INVALID RACE"; break;
        }
        return _names;
    }
}

