using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReadJson : MonoBehaviour
{
    [SerializeField] private TextAsset _subclassFile; // this file contains all the subclass names possible sorted by Class.
    [SerializeField] private TextAsset _charNameFile; // this file contains all the character names possible sorted by Race.
    [SerializeField] private TextAsset _charDetailsFile; // this file contains all the detail names possible sorted by Type (Race, Class, Stats).

    // These Text fields represent the content from the Character.cs Arrays.
    [SerializeField] private Text _raceText;
    [SerializeField] private Text _classText;
    [SerializeField] private Text _subclassText;
    [SerializeField] private Text _statText;
    [SerializeField] private Text _nameText;
    [SerializeField] private Text _storyText;

    public string charRace; //this string is used by GetRaceNames() if you change this string to the race you got from the race generator you will get the corresponding character names if you call GetRaceNames().
    public string charClass; //this string is used by GetSubclasses() if you change this string to the class you got from the class generator you will get the corresponding Subclasses if you call GetSubclasses().

    public Character newChar; // this will be used as our current instance of Character.cs.

    void Start()
    {
        newChar = new Character(); // actually creates the new instance of Character.cs
        newChar = JsonUtility.FromJson<Character>(_charDetailsFile.text); // this reads the _charDetailsFile containing (Race, Class, Stats) the Array names in the json must be the EXACT SAME as the var names in Character.cs
        newChar.charNames = JsonUtility.FromJson<Names>(_charNameFile.text); // this reads the _charNameFile containing (names for all races) the Array names in the json must be the EXACT SAME as the var names in Character.cs
        newChar.charSubclasses = JsonUtility.FromJson<Subclasses>(_subclassFile.text); // this reads the _subclassFile containing (names for all subclasses) the Array names in the json must be the EXACT SAME as the var names in Character.cs

        // clears the text from the text fields
        _statText.text = "";
        _classText.text = "";
        _subclassText.text = "";
        _raceText.text = "";
        _nameText.text = "";
        _storyText.text = "";

        DetailsToText(); // for each array (except names) puts each index into the corresponding text fields

        //puts all names from the Race = charRace into the _nameText field
        foreach (string _name in GetRaceNames())
        {
            if (_name == "ERROR: INVALID RACE")
            {
                _nameText.text = _name;
                break;
            }

            _nameText.text += _name + "\n";
        }

        foreach (string _subclasses in GetSubclasses(charClass))
        {
            if (_subclasses == "ERROR: INVALID RACE")
            {
                _nameText.text = _subclasses;
                break;
            }

            _nameText.text += _subclasses + "\n";
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

        _storyText.text = GameObject.Find("BackstoryGenerator").GetComponent<BackstoryGenerator>().GenerateBackstory(newChar); // randomize the character backstory
    }

    public string[] GetRaceNames()
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

    public string[] GetSubclasses(string _class)
    {
        string[] _subclasses = new string[50];

        switch (_class)
        {
            case "Artificer": _subclasses = newChar.charSubclasses.Artificer; break;
            case "Barbarian": _subclasses = newChar.charSubclasses.Barbarian; break;
            case "Bard": _subclasses = newChar.charSubclasses.Bard; break;
            case "Blood_Hunter": _subclasses = newChar.charSubclasses.Blood_Hunter; break;
            case "Cleric": _subclasses = newChar.charSubclasses.Cleric; break;
            case "Druid": _subclasses = newChar.charSubclasses.Druid; break;
            case "Fighter": _subclasses = newChar.charSubclasses.Fighter; break;
            case "Monk": _subclasses = newChar.charSubclasses.Monk; break;
            case "Paladin": _subclasses = newChar.charSubclasses.Paladin; break;
            case "Ranger": _subclasses = newChar.charSubclasses.Ranger; break;
            case "Rogue": _subclasses = newChar.charSubclasses.Rogue; break;
            case "Sorcerer": _subclasses = newChar.charSubclasses.Sorcerer; break;
            case "Warlock": _subclasses = newChar.charSubclasses.Warlock; break;
            case "Wizard": _subclasses = newChar.charSubclasses.Wizard; break;
            default: _subclasses[0] = "ERROR: INVALID CLASS"; break;
        }

        return _subclasses;
    } 
}

